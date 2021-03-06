CREATE DATABASE QuanLyNhaTro
GO
USE QuanLyNhaTro;

/*tạo bảng khách hàng*/
CREATE TABLE khachhang(
	makh nvarchar(5) primary key,
	ho nvarchar (30),
	ten nvarchar (30) not null,
	gioitinh nvarchar(5) not null,
	ngaysinh smalldatetime,
	sdt nvarchar(15),
	cmnd nvarchar(15) not null,
	maphong nvarchar(5),
	email nvarchar(30),
	diachi nvarchar(50),
	quoctich nvarchar(15),
	ngayden smalldatetime
)
GO
INSERT INTO khachhang VALUES(N'P127',N'Ngô Anh',N'Duy',N'Nam','1995-07-12',N'0972985672',N'019283948',N'P11',N'anhduy@gmail.com',N'Thốt Nốt, An Giang',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P121',N'Mai Văn',N'Hiển',N'Nam','1995-07-12',N'0972985672',N'019283948',N'P11',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P122',N'Trần Hữu',N'Văn',N'Nam','1994-07-12',N'0972985672',N'019283948',N'P11',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P123',N'Hoàng',N'Dương',N'Nam','1994-07-12',N'0972985672',N'019283948',N'P12',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P124',N'Lê Thanh',N'Duy',N'Nam','1994-07-12',N'0972985672',N'019283948',N'P12',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P125',N'Đại',N'Lâm',N'Nữ','1994-07-12',N'0972985672',N'019283948',N'P22',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P126',N'Lê Thanh',N'Phát',N'Nam','1994-07-12',N'0972985672',N'019283948',N'P23',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P128',N'Thành',N'Duy',N'Nữ','1994-07-12',N'0972985672',N'019283948',N'P21',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P129',N'Lê Thanh',N'Duy',N'Nam','1994-07-12',N'0972985672',N'019283948',N'P15',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P110',N'Bảo',N'Duy',N'Nữ','1994-07-12',N'0972985672',N'019283948',N'P16',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P122',N'Lý Văn',N'Tú',N'Nam','1994-07-12',N'0972985672',N'019283948',N'P14',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');
INSERT INTO khachhang VALUES(N'P552',N'Nguyễn',N'Duy',N'Nam','1994-07-12',N'0972985672',N'019283948',N'P15',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05');

/*tạo bảng đăng nhập*/
CREATE TABLE dangnhap(
	tendangnhap nvarchar(50) primary key,
	matkhau1 nvarchar(50) not null,
	matkhau2 nvarchar(50),
)
 GO
 INSERT INTO dangnhap VALUES(N'admin',N'admin',N'admin');
 INSERT INTO dangnhap VALUES(N'anhduy',N'anhduy',N'123456');
 INSERT INTO dangnhap VALUES(N'123456',N'123456',N'123');
 
/*tạo bảng lịch sử khách hàng*/
CREATE TABLE lichsukhachhang(
	makh nvarchar(5) primary key,
	ho nvarchar (30),
	ten nvarchar (30) not null,
	gioitinh nvarchar(5) not null,
	ngaysinh smalldatetime,
	sdt nvarchar(15),
	cmnd nvarchar(15) not null,
	maphong nvarchar(5),
	email nvarchar(30),
	diachi nvarchar(50),
	quoctich nvarchar(15),
	ngayden smalldatetime,
	ngaydi smalldatetime,
)
GO
INSERT INTO lichsukhachhang VALUES(N'P127',N'Ngô Anh',N'Khải',N'Nam','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2017-01-05','2017-03-05');
INSERT INTO lichsukhachhang VALUES(N'P121',N'Ngô Anh',N'Lâm',N'Nam','1996-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2015-01-05','2016-01-05');
INSERT INTO lichsukhachhang VALUES(N'P122',N'Văn',N'Lâm',N'Nam','1997-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2014-01-05','2016-01-05');
INSERT INTO lichsukhachhang VALUES(N'P123',N'Ngô Anh',N'Tùng',N'Nam','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2013-01-05','2017-01-05');
INSERT INTO lichsukhachhang VALUES(N'P124',N'Trần Anh',N'Lâm',N'Nam','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2016-01-05','2017-01-05');
INSERT INTO lichsukhachhang VALUES(N'P125',N'Trương',N'Lâm',N'Nữ','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2015-01-05','2018-01-05');
INSERT INTO lichsukhachhang VALUES(N'P126',N'Nguyễn Anh',N'Duy',N'Nữ','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05','2017-01-05');
INSERT INTO lichsukhachhang VALUES(N'P128',N'Thanh',N'Lâm',N'Nam','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05','2017-01-05');
INSERT INTO lichsukhachhang VALUES(N'P129',N'Ngô Anh',N'Tiến',N'Nam','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2016-01-05','2016-01-05');
INSERT INTO lichsukhachhang VALUES(N'P130',N'Ngô Anh',N'Duy',N'Nam','1996-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2017-01-05','2017-02-05');
INSERT INTO lichsukhachhang VALUES(N'P119',N'Ngô Anh',N'Trà',N'Nữ','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2016-01-05','2016-03-05');
INSERT INTO lichsukhachhang VALUES(N'P118',N'Lý',N'Hân',N'Nam','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2016-01-05','2016-01-05');
INSERT INTO lichsukhachhang VALUES(N'P117',N'Lê ',N'Phước',N'Nam','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2016-01-05','2016-01-05');
INSERT INTO lichsukhachhang VALUES(N'P116',N'Nguyễn Văn',N'Lâm',N'Nữ','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2016-01-05','2016-01-05');
INSERT INTO lichsukhachhang VALUES(N'P115',N'Lý Mặc',N'Sầu',N'Nam','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Long Xuyên, An Giang',N'Việt Nam','2016-01-05','2016-01-05');
INSERT INTO lichsukhachhang VALUES(N'P114',N'Việt',N'Lâm',N'Nam','1995-07-12',N'0972985672',N'019283948',N'VIP',N'anhduy@gmail.com',N'Thốt Nốt, Cần Thơ',N'Việt Nam','2016-01-05','2016-01-05');
/*tạo bảng thanh toán*/
CREATE TABLE thanhtoan(
	maphong nvarchar(5) primary key,
	giaphong nvarchar(50),
	tendichvu1 nvarchar(50),
	tendichvu2 nvarchar(50),
	giadichvu1 nvarchar(50),
	giadichvu2 nvarchar(50),
	ngayden smalldatetime,
	ngaydi smalldatetime,
	songaythanhtoan nvarchar(50),
	tongtien nvarchar(50),
)
GO
INSERT INTO thanhtoan VALUES(N'P01',N'250000',N'Nước lọc',N'Nước lọc',N'15000',N'15000',N'2016-07-07',N'2016-07-07',N'1',N'500000');
INSERT INTO thanhtoan VALUES(N'P02',N'250000',N'Nước lọc',N'Không sử dụng',N'15000',N'0',N'2016-07-07',N'2016-07-07',N'1',N'500000');
INSERT INTO thanhtoan VALUES(N'P03',N'250000',N'Quét dọn',N'Nước lọc',N'15000',N'15000',N'2016-07-07',N'2016-07-07',N'1',N'500000');
INSERT INTO thanhtoan VALUES(N'P04',N'250000',N'Internet',N'Nước lọc',N'15000',N'15000',N'2016-07-07',N'2016-07-07',N'1',N'500000');
INSERT INTO thanhtoan VALUES(N'P05',N'250000',N'Truyền hình cáp',N'Không Sử dụng',N'15000',N'0',N'2016-07-07',N'2016-07-07',N'1',N'500000');


/*tạo bảng thông tin phòng*/
CREATE TABLE thongtinphong(
	maphong nvarchar(5) primary key,
	tenphong nvarchar(20),
	giaphong nvarchar(20),
	tinhtrang nvarchar(50),	
)
GO
INSERT INTO thongtinphong VALUES(N'P01',N'Phòng 1',N'250000',N'Có Khách');
INSERT INTO thongtinphong VALUES(N'P02',N'Phòng 2',N'250000',N'Có Khách');
INSERT INTO thongtinphong VALUES(N'P03',N'Phòng 3',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P04',N'Phòng 4',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P05',N'Phòng 5',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P06',N'Phòng 6',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P07',N'Phòng 7',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P08',N'Phòng 8',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P09',N'Phòng 9',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P10',N'Phòng 10',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P11',N'Phòng 11',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P12',N'Phòng 12',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P13',N'Phòng 13',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P14',N'Phòng 14',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P15',N'Phòng 15',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P16',N'Phòng 16',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P17',N'Phòng 17',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P18',N'Phòng 18',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P19',N'Phòng 19',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P20',N'Phòng 20',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P21',N'Phòng 21',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P22',N'Phòng 22',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P23',N'Phòng 23',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P24',N'Phòng 24',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P25',N'Phòng 25',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P26',N'Phòng 26',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P27',N'Phòng 27',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P28',N'Phòng 28',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P29',N'Phòng 29',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P30',N'Phòng 30',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P31',N'Phòng 31',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P32',N'Phòng 32',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P33',N'Phòng 33',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P34',N'Phòng 34',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P35',N'Phòng 35',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P36',N'Phòng 36',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P37',N'Phòng 37',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P38',N'Phòng 38',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P39',N'Phòng 39',N'250000',N'Trống');
INSERT INTO thongtinphong VALUES(N'P40',N'Phòng 40',N'250000',N'Trống');

/*tạo bảng dịch vụ*/
CREATE TABLE dichvu(
	madichvu nvarchar(5) primary key,
	tendichvu nvarchar(50),
	giadichvu float,

)
GO
INSERT INTO dichvu VALUES(N'DV01',N'Nước lọc',N'15000');
INSERT INTO dichvu VALUES(N'DV02',N'Quét dọn',N'100000');
INSERT INTO dichvu VALUES(N'DV03',N'Internet',N'70000');
INSERT INTO dichvu VALUES(N'DV04',N'Truyền hình cáp',N'70000');
INSERT INTO dichvu VALUES(N'DV00',N'Không sử dụng',N'0');

/*tạo bảng phòng sử dụng dịch vụ*/
CREATE TABLE phongsudungdichvu(
	stt int primary key,
	madichvu nvarchar(5),
	tendichvu nvarchar(50),
	maphong nvarchar(5),
	ngaysudung smalldatetime,
)
GO
INSERT INTO phongsudungdichvu VALUES(N'1',N'DV01',N'Nước lọc',N'P01',N'12/12/2015');
INSERT INTO phongsudungdichvu VALUES(N'2',N'DV02',N'Quét dọn',N'P02',N'12/12/2015');
INSERT INTO phongsudungdichvu VALUES(N'3',N'DV03',N'Internet',N'P03',N'12/12/2015');
INSERT INTO phongsudungdichvu VALUES(N'4',N'DV04',N'Truyền hình cáp',N'P04',N'12/12/2015');



select * from thongtinphong;