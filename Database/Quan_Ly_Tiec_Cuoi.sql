CREATE DATABASE QUAN_LY_TIEC_CUOI
GO 
USE QUAN_LY_TIEC_CUOI
GO
SET DATEFORMAT DMY
GO
-- Bảng Ca
CREATE TABLE CA
(
	sMaCa varchar(4) PRIMARY KEY NOT NULL,
	sTenca nvarchar(20),
	tGio time
)
-- Bảng Loại Sảnh
CREATE TABLE LOAI_SANH
(
	sMaLoaiSanh varchar(4) PRIMARY KEY NOT NULL,
	sTenLoaiSanh nvarchar(20),
	mDonGiaBanTT money
)
-- Bảng Danh Sách Sảnh
CREATE TABLE DANH_SACH_SANH
(
	sMaSanh varchar(4) PRIMARY KEY NOT NULL,
	sTenSanh nvarchar(20),
	sMaLoaiSanh varchar(4),
		FOREIGN KEY (sMaLoaiSanh) REFERENCES LOAI_SANH(sMaLoaiSanh),
	iSoLuongBanToiDa smallint,
	sGhiChu varchar(50)
)
-- Bảng Tiệc Cưới
CREATE TABLE TIEC_CUOI
(
	sMaTiecCuoi varchar(4) PRIMARY KEY NOT NULL,
	dNgayDatTiec smalldatetime,
	sTenChuRe nvarchar(20),
	sTenCoDau nvarchar(20),
	sDienThoai varchar(11),
	dNgayDaiTiec smalldatetime,
	sMaCa varchar(4),
		FOREIGN KEY (sMaCa) REFERENCES CA(sMaCa),
	sMaSanh varchar(4),
		FOREIGN KEY (sMaSanh) REFERENCES DANH_SACH_SANH(sMaSanh),
	mTienDatCoc money,
	iSLBan smallint,
	iSoBanDuTru smallint,
)
-- Bảng Món Ăn
CREATE TABLE MON_AN
(
	sMaMonAn varchar(4) PRIMARY KEY NOT NULL,
	sTenMonAn nvarchar(20),
	mDonGia money,
	sGhiChu nvarchar(50)
)
-- Bảng Dịch Vụ
CREATE TABLE DICH_VU
(
	sMaDichVu varchar(4) PRIMARY KEY NOT NULL,
	sTenDichVu nvarchar(20),
	mDonGia money
)
-- Bảng Đặt Món
CREATE TABLE DAT_MON
(
	sMaTiecCuoi varchar(4),
		FOREIGN KEY (sMaTiecCuoi) REFERENCES TIEC_CUOI(sMaTiecCuoi),
	sMaMonAn varchar(4),
		FOREIGN KEY (sMaMonAn) REFERENCES MON_AN(sMaMonAn),
	mDonGia money,
	PRIMARY KEY (sMaTiecCuoi,sMaMonAn)
)
-- Bảng Đặt Dịch Vụ
CREATE TABLE DAT_DICH_VU
(
	sMaTiecCuoi varchar(4),
		FOREIGN KEY (sMaTiecCuoi) REFERENCES TIEC_CUOI(sMaTiecCuoi),
	sMaDichVu varchar(4),
		FOREIGN KEY (sMaDichVu) REFERENCES DICH_VU(sMaDichVu),
	iSoLuong smallint,
	mDonGia money,
	PRIMARY KEY (sMaTiecCuoi,sMaDichVu)
)
-- Bảng Hóa Đơn
CREATE TABLE HOA_DON
(
	sMaTiecCuoi varchar(4) PRIMARY KEY NOT NULL,
		FOREIGN KEY (sMaTiecCuoi) REFERENCES TIEC_CUOI(sMaTiecCuoi),
	dNgaylap smalldatetime,
	mDonGiaBan money,
	mTongTienBan money,
	mTTDichVu money,
	mTTHoaDon money,
	dNguoiLap varchar(50),
	dNgayThanhToan smalldatetime, 
	TinhTrang int default 1
)
-- Bảng Báo Cáo Doanh Số Theo Thang
CREATE TABLE BAO_CAO_DS
(
	sMaBaoCao varchar(4) PRIMARY KEY NOT NULL,
	iThang smallint,
	iNam smallint,
	mTongDoanhThu money
)
-- Bảng Doanh Thu Ngày
CREATE TABLE DOANH_THU_NGAY
(
	sMaBaoCao varchar(4),
		FOREIGN KEY (sMaBaoCao) REFERENCES BAO_CAO_DS(sMaBaoCao),
	dNgay smalldatetime,
	iSLTiecCuoi smallint,
	mDoanhThu money,
	iTiLe float,
	PRIMARY KEY (sMaBaoCao,dNgay)
)
-- Bảng Tham Số
CREATE TABLE THAM_SO
(
	sTenThamSo varchar(20) PRIMARY KEY NOT NULL,
	iGiaTri smallint
)
-- Bảng Tài Khoản
CREATE TABLE TAI_KHOAN
(
	sTenDangNhap varchar(20) PRIMARY KEY,
	sMatKhau varchar(20)
)
GO
	INSERT INTO LOAI_SANH VALUES ('1','A','1000000')
	INSERT INTO LOAI_SANH VALUES ('2','B','1100000')
	INSERT INTO LOAI_SANH VALUES ('3','C','1200000')
	INSERT INTO LOAI_SANH VALUES ('4','D','1400000')
	INSERT INTO LOAI_SANH VALUES ('5','E','1600000')
	INSERT INTO TAI_KHOAN VALUES ('Admin','1')
GO
	INSERT INTO CA VALUES ('1','Trưa','11:30')
	INSERT INTO CA VALUES ('2','Toi','17:00')
GO
	INSERT INTO THAM_SO VALUES ('PhanTramPhatTre','1')

	ALTER TABLE DAT_DICH_VU
	ADD mThanhTien money
	ALTER TABLE DAT_MON
	ADD sGhiChu nvarchar(50)
-- Tính Thành Tiền Trong Đặt Dịch Vụ
GO
	CREATE TRIGGER THANHTIEN_DICHVU ON DAT_DICH_VU
	FOR INSERT, UPDATE
	AS
		BEGIN
			DECLARE @MaTiecCuoi varchar(4), @TONG money, @DonGia money, @MaDichVu varchar(4), @SL smallint
			SELECT @MaTiecCuoi = sMaTiecCuoi, @MaDichVu = sMaDichVu, @SL = iSoLuong FROM INSERTED
			SELECT @DonGia = mDonGia FROM DICH_VU WHERE (@MaDichVu = sMaDichVu)
			UPDATE DAT_DICH_VU
			SET mDonGia = @DonGia, mThanhTien = @DonGia*@SL
			WHERE ((@MaTiecCuoi = sMaTiecCuoi) and (@MaDichVu = sMaDichVu))
		END
		
-- Tính tổng tiền bàn
GO
	CREATE TRIGGER TONGTIENBAN ON HOA_DON
	FOR INSERT, UPDATE
	AS
		BEGIN
			DECLARE @MaTiecCuoi varchar(4), @TongTienMonAn money, @SLBan smallint
			SELECT @MaTiecCuoi = sMaTiecCuoi FROM INSERTED
			SELECT @SLBan = iSLBan FROM TIEC_CUOI WHERE (@MaTiecCuoi = sMaTiecCuoi)
			SELECT @TongTienMonAn = sum(mDonGia) FROM DAT_MON WHERE (@MaTiecCuoi = sMaTiecCuoi)
			IF TRIGGER_NESTLEVEL() > 1
				RETURN
			UPDATE HOA_DON
			SET mTongTienBan = @TongTienMonAn*@SLBan, mDonGiaBan = @TongTienMonAn
			WHERE (@MaTiecCuoi = sMaTiecCuoi)
		END
-- Tính Tổng Tiền Dịch Vụ, Tổng Tiền Thanh Toán Và Cập Nhật Ngày Thanh Toán 	
GO
	CREATE TRIGGER TONGTIENDICHVU ON HOA_DON
	FOR INSERT, UPDATE
	AS
		BEGIN
			DECLARE @TONG money, @MaTiecCuoi varchar(4), @NgayDatTiec smalldatetime
			SELECT @MaTiecCuoi = sMaTiecCuoi FROM INSERTED
			SELECT @NgayDatTiec = dNgayDatTiec FROM TIEC_CUOI WHERE (@MaTiecCuoi = sMaTiecCuoi)
			SELECT @TONG = sum(mThanhTien) FROM DAT_DICH_VU WHERE (@MaTiecCuoi = sMaTiecCuoi)
			IF TRIGGER_NESTLEVEL() > 1
				RETURN
			UPDATE HOA_DON
			SET mTTDichVu = @TONG, mTTHoaDon = @TONG + mTongTienBan, dNgaylap = @NgayDatTiec
			WHERE (@MaTiecCuoi = sMaTiecCuoi)
		END	
-- Tính Tổng Doanh Thu Trong Báo Cáo Tháng
GO
	CREATE TRIGGER TONGDOANHTHU_BAOCAO ON BAO_CAO_DS
	FOR INSERT
	AS
		BEGIN
			DECLARE @Thang smallint, @Nam smallint, @TONG money, @MaBaoCao varchar(4)
			SELECT @Thang = iThang, @Nam = iNam, @MaBaoCao = sMaBaoCao FROM INSERTED
			SELECT @TONG = sum(mTTHoaDon) FROM HOA_DON WHERE (@Thang = month(dNgayThanhToan) and @Nam = year(dNgayThanhToan) and TinhTrang=0)
			UPDATE BAO_CAO_DS
			SET mTongDoanhThu = @TONG
			WHERE (@MaBaoCao = sMaBaoCao)
		END
		
-- Tính Doanh Thu, Tỉ Lệ Và SLTiecCuoi Theo Ngày Trong Báo Cáo DS
GO
	CREATE TRIGGER DOANHTHU_TILE_BAOCAO ON DOANH_THU_NGAY
	FOR INSERT
	AS
		BEGIN
			DECLARE @MaBaoCao varchar(4), @TONG money, @Ngay smalldatetime, @TiLe smallint, @SLTiecCuoi smallint
			SELECT @MaBaoCao = sMaBaoCao, @Ngay = dNgay FROM INSERTED
			SELECT @TONG = sum(mTTHoaDon) FROM HOA_DON WHERE (@Ngay = dNgayThanhToan)
			SELECT @SLTiecCuoi = count(sMaTiecCuoi) FROM HOA_DON WHERE (@Ngay = dNgayThanhToan)
			SELECT @TiLe = (@TONG/mTongDoanhThu)*100 FROM BAO_CAO_DS WHERE (@MaBaoCao = sMaBaoCao) -- Tỉ Lệ Có Đơn Vị là %
			UPDATE DOANH_THU_NGAY
			SET mDoanhThu = @TONG, iTiLe = @TiLe, iSLTiecCuoi = @SLTiecCuoi
			WHERE ((@MaBaoCao = sMaBaoCao) and (dNgay = @Ngay))
		END
		
GO
	INSERT INTO DANH_SACH_SANH VALUES ('1','Sanh 1','1','30','')
	INSERT INTO TIEC_CUOI VALUES ('1','24/06/2018','A','B','123456789','25/06/2018','1','1','10000000','15','1')
	INSERT INTO TIEC_CUOI VALUES ('2','22/03/2018','C','D','123456789','25/06/2018','1','1','10000000','15','1')
	INSERT INTO MON_AN VALUES ('1','4 Mon Khai Vi','100000','')
	INSERT INTO MON_AN VALUES ('2','Ga Bo Xoi','200000','')
	INSERT INTO MON_AN VALUES ('3','Bo Xao Bong Thien Ly','300000','')
	INSERT INTO MON_AN VALUES ('5','Lau Thai','250000','')
	INSERT INTO MON_AN VALUES ('6','Nho My','100000','')
	INSERT INTO DICH_VU VALUES ('1','Maid-Meowww','250000')
	INSERT INTO DICH_VU VALUES ('2','Tiep Tan','200000')
	INSERT INTO DAT_MON VALUES ('1','1','100000')
	INSERT INTO DAT_MON VALUES ('1','2','200000')
	INSERT INTO DAT_MON VALUES ('1','6','100000')
	INSERT INTO DAT_MON VALUES ('2','6','100000')
	INSERT INTO DAT_DICH_VU VALUES ('1','1','25000','5','')
	INSERT INTO DAT_DICH_VU VALUES ('1','2','20000','3','')
	INSERT INTO DAT_DICH_VU VALUES ('2','2','20000','3','')
	
	INSERT INTO HOA_DON(sMaTiecCuoi,dNguoiLap,dNgayThanhToan,TinhTrang) VALUES ('1',N'PuPuChaCha','6/7/2019','0')
	INSERT INTO BAO_CAO_DS(sMaBaoCao,iThang,iNam) VALUES ('1','7','2019')
	INSERT INTO BAO_CAO_DS(sMaBaoCao,iThang,iNam) VALUES ('2','9','2019')
	INSERT INTO DOANH_THU_NGAY(sMaBaoCao,dNgay) VALUES ('1','6/7/2019')
	INSERT INTO DOANH_THU_NGAY(sMaBaoCao,dNgay) VALUES ('1','7/9/2019')