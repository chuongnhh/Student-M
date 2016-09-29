USE [master]
GO
/****** Object:  Database [DB_MITContest_Final]    Script Date: 4/24/2016 10:27:04 AM ******/
CREATE DATABASE [DB_MITContest_Final]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'DB_MITContest_Final', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.CHUONGNHDEV\MSSQL\DATA\DB_MITContest_Final.mdf' , SIZE = 3264KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'DB_MITContest_Final_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.CHUONGNHDEV\MSSQL\DATA\DB_MITContest_Final_log.ldf' , SIZE = 832KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [DB_MITContest_Final] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [DB_MITContest_Final].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [DB_MITContest_Final] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET ARITHABORT OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [DB_MITContest_Final] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [DB_MITContest_Final] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [DB_MITContest_Final] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET  ENABLE_BROKER 
GO
ALTER DATABASE [DB_MITContest_Final] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [DB_MITContest_Final] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [DB_MITContest_Final] SET  MULTI_USER 
GO
ALTER DATABASE [DB_MITContest_Final] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [DB_MITContest_Final] SET DB_CHAINING OFF 
GO
ALTER DATABASE [DB_MITContest_Final] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [DB_MITContest_Final] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [DB_MITContest_Final] SET DELAYED_DURABILITY = DISABLED 
GO
USE [DB_MITContest_Final]
GO
/****** Object:  Table [dbo].[CauHoi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CauHoi](
	[maCauHoi] [int] IDENTITY(1,1) NOT NULL,
	[tenCauHoi] [nvarchar](100) NULL,
	[noiDung] [nvarchar](max) NULL,
	[luaChonA] [nvarchar](max) NULL,
	[luaChonB] [nvarchar](max) NULL,
	[luaChonC] [nvarchar](max) NULL,
	[luaChonD] [nvarchar](max) NULL,
	[dapAnDung] [nvarchar](max) NULL,
	[maTroChoi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maCauHoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DiemSo]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DiemSo](
	[maDoiThi] [int] NOT NULL,
	[maTroChoi] [int] NOT NULL,
	[maHeThi] [int] NOT NULL,
	[diemSo] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maDoiThi] ASC,
	[maTroChoi] ASC,
	[maHeThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DoiThi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DoiThi](
	[maDoiThi] [int] IDENTITY(1,1) NOT NULL,
	[maHeThi] [int] NOT NULL,
	[tenDoiThi] [nvarchar](100) NULL,
	[thanhVien1] [nvarchar](100) NULL,
	[thanhVien2] [nvarchar](100) NULL,
	[thanhVien3] [nvarchar](100) NULL,
	[thanhVien4] [nvarchar](100) NULL,
	[thanhVien5] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[maDoiThi] ASC,
	[maHeThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HeThi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HeThi](
	[maHeThi] [int] IDENTITY(1,1) NOT NULL,
	[tenHeThi] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[maHeThi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[TroChoi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TroChoi](
	[maTroChoi] [int] IDENTITY(1,1) NOT NULL,
	[tenTroChoi] [nvarchar](100) NULL,
	[thoiGian] [int] NULL,
	[maHeThi] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[maTroChoi] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[CauHoi] ON 

INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (1, N'Câu 1', N'Số nào sau đây là biểu diễn thập phân tương ứng với số nhị phân 10.0101?', N'2.125', N'2.3125', N'2. 5675', N'2.75', N'A', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (2, N'Câu 2', N'Tung 1 đồng xu 4 lần, tính xác suất để được đúng 2 lần đồng xu ngửa?', N'6.25%', N'25%', N'37.5%', N'50%', N'C', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (3, N'Câu 3', N'Trong linux, lệnh nào dùng để thay đổi quyền sở hữu của một tập tin?', N'changeown', N'chown', N'changemode', N'chmod', N'B', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (4, N'Câu 4', N'Giao thức TCP hoạt động ở tầng nào trong mô hình OSI?', N'Tầng Network', N'Tầng Data-Link', N'Tầng Transport', N'Tầng Session', N'C', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (5, N'Câu 5', N'Ngôn ngữ nào sau đây không cho phép khai báo đa thừa kế tường minh từ nhiều lớp (class) khác nhau?', N'Java', N'C++', N'Python', N'Perl', N'A', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (6, N'Câu 6', N'Hãy cho biết dãy SỐ NGUYÊN DƯƠNG sau đây có bao nhiêu phần tử?
1024, 512, 256, 128, ...', N'', N'', N'', N'', N'11
Vì 2^10, 2^9, 2^8, ..., 2^0 >>> có tất cả 11 số
', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (7, N'Câu 7', N'Lệnh nào liệt kê tất cả các kết nối TCP hiện hành trong Windows?', N'', N'', N'', N'', N'NETSTAT', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (8, N'Câu 8', N'Chữ P trong tên gọi của công nghệ lập trình web động JSP được viết tắt từ chữ tiếng Anh nào?', N'', N'', N'', N'', N'Pages
(Java Server Pages)', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (9, N'Câu 9', N'Trong ngôn ngữ mô hình hóa UML, ký tự nào được sử dụng để biểu diễn phạm vi (visibility) dùng chung (public) của 1 thuộc tính hay phương thức?', N'', N'', N'', N'', N'+', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (10, N'Câu 10', N'Ngôn ngữ lập trình nào được thiết kế dành riêng cho tính toán thống kê và phân tích dữ liệu?', N'', N'', N'', N'', N'Ngôn ngữ R', 1)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (15, N'Vòng Lập Trình Tiếp Sức', N'Cho A là một mảng các số thực có n (n<100) phần tử.
Yêu cầu: Hãy tìm đoạn [a, b] (a, b là các số nguyên) sao cho đoạn này chứa tất cả các giá trị trong mảng.

Dữ liệu vào có cấu trúc như sau:
-Dòng đầu tiên là một số nguyên dương duy nhất n biểu diễn số phần tử của mảng A.
-Dòng tiếp theo là n số thực lớn hơn -100 và nhỏ hơn 100 (mỗi số cách nhau ít nhất một khoảng trắng) lần lượt là n phần tử của mảng A.
Dữ liệu ra: Lần lượt là hai số nguyên a, b cần tìm, mỗi số cách nhau ít nhất một khoảng trắng.

Ví dụ:   Dữ liệu vào                    Dữ liệu vào
             4                                       3
             5     9     8     3                 3.4     5.8     2.5
             Dữ liệu ra                       Dữ liệu ra
             3     9                                2         6
Giải thích: 	
              Đoạn [3,9] trên trục số chứa tất cả giá trị 3, 5, 8, 9.
              Các số 2.5, 3.4, 5.8 thuộc đoạn [2,6] trên trục số', N'', N'', N'', N'', N'', 3)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (16, N'Vòng Trò Chơi Vận Động - Lắp Ghép Chương Trình', N'Nội dung: Đây là HÀM tính tổng các số nguyên tố có trong mảng các số nguyên a gồm n phần tử.

1	}
2	Else
3	if (a[i] % j == 0) nt = 0;
4	int tongnt(inta[], intn) {						
5	for (int i = 0; i <n; i++){ 
6	if (nt) tong += a[i];
7	}
8	int tong = 0;
9	return tong;
10	if (a[i] < 2) nt = 0;
11	for (int j = 2; j <a[i]; j++)
12	int nt = 1;', N'', N'', N'', N'', N'', 4)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (18, N'Câu 1', N'Có bao nhiêu số nguyên dương nhỏ hơn 1000 và chia hết cho 3?', N'', N'', N'', N'', N'333', 5)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (19, N'Câu 2', N'Hãy cho biết dãy số nguyên dương sau gồm bao nhiêu phần tử?
144, 121, 100, 81, ...', N'', N'', N'', N'', N'12

Dãy gồm: 12^2, 11^2, 10^2, ... , 1^2', 5)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (20, N'Câu 3', N'Trò chơi Thời đại các đế chế (Age of Empires) là sản phẩm giải trí của hãng nào?', N'', N'', N'', N'', N'Microsoft', 5)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (21, N'Câu 4', N'Số nhị phân bao gồm 11 chữ số 1 tương ứng với giá trị bao nhiêu trong hệ thập lục phân?', N'', N'', N'', N'', N'7FF', 5)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (22, N'Câu 5', N'Hãy cho biết tên hệ quản trị cơ sở dữ liệu được xếp vào loại mạnh nhất hiện nay, có tên xuất phát từ thần thoại Hy Lạp!', N'', N'', N'', N'', N'Oracle', 5)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (23, N'Câu 6', N'Biểu tượng sau đây là của phần mềm nào?', N'', N'', N'', N'', N'UBUNTU', 5)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (24, N'Luật Thi Vòng Truyền Tin', N'Mỗi đội cử 5 thành viên tham gia, chia làm 2 nhóm (cách chia tuỳ ý) đứng cách xa nhau. Vị trí của nhóm truyền tin là ở trên sân khấu, và vị trí của nhóm nhận tin là ở phía khán giả. (Vị trí các đội trong trận đấu do BTC quy định.).

Nhóm truyền tin nhận được bản tin đã mã hoá, sử dụng 2 bảng 0 và 1 (được BTC cung cấp) để truyền bản tin cho nhóm nhận tin. 
Nhóm nhận tin nhận được khoá K, và cũng sử dụng 2 bảng 0 và 1 để liên lạc với nhóm truyền tin. Nhóm nhận tin nhận bản tin từ nhóm truyền tin, giải mã để có được thông điệp ban đầu. 

Sau khi hoàn tất, các đội sẽ ghi kết quả ra giấy ghi kết quả, và nộp lại BGK. Trong quá trình truyền và nhận tin, 2 nhóm không được trao đổi với nhau hoặc dùng các ký hiệu khác ngoài việc sử dụng các đạo cụ được cung cấp.

Thời gian thi đấu từ 4 đến 6 phút (tuỳ theo độ dài của thông điệp được truyền).

Đội nào xong trước có quyền bấm chuông nộp kết quả trước. Các đội sẽ được cung cấp: bản tin đã được mã hoá, giấy trắng, 2 bảng 0 và 1 để truyền tin (bên truyền); khoá K, giấy ghi kết quả, giấy trắng, 2 bảng 0 và 1 (bên nhận). Các đội thi đấu không được đem cái gì khác ngoài viết. Các đội chỉ được sử dụng viết khi phần thi được bắt đầu tính thời gian.', N'', N'', N'', N'', N'', 2)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (25, N'Câu 1', N'Ai là người phát minh ra chuột máy tính?', N'Steve Jobs', N'Douglas Engelbart', N'Ada Levelace', N'Leonard Kleinrock', N'B', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (26, N'Câu 2', N'KitKat là tên mã của hệ điều hành Android phiên bản nào?', N'4.1', N'4.4', N'5.0', N'6.0', N'B', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (27, N'Câu 3', N'Ký tự nào sau đây không gõ được trực tiếp từ bàn phím?', N'$', N'&', N'≥', N'%', N'C', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (28, N'Câu 4', N'Hãy kể tên 3 cấu trúc cơ bản của thuật toán trong tin học!', N'Tuần tự, lặp và nhảy', N'Tuần tự, rẽ nhánh và lặp', N'Rẽ nhánh, lặp và nhảy', N'Rẽ nhánh, tuần tự và nhảy', N'B', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (29, N'Câu 5', N'Trong hệ đếm nhị phân, phép cộng:
11 + 11
có kết quả là bao nhiêu?', N'111', N'110', N'100', N'1111', N'B', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (30, N'Câu 5', N'AutoCAD là một sản phẩm của hãng nào?', N'', N'', N'', N'', N'AutoDESK', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (31, N'Câu 7', N'Trên bàn phím máy tính để bàn, có bao nhiêu phím có gờ nổi?', N'', N'', N'', N'', N'3
(Đó là các phím F, J và 5-phần phím số)
', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (32, N'Câu 8', N'Bội số chung nhỏ nhất của 4, 6 và 15 là bao nhiêu?', N'', N'', N'', N'', N'60
Giải thích thêm:
4 = 22
6 = 2.3
15 = 3.5
Nên bội số chung nhỏ nhất là 22.3.5=60
', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (33, N'Câu 9', N'“Yugi!Oh” – loạt game bài ma thuật nổi tiếng dựa trên truyện tranh cùng tên – do hãng nào sản xuất?', N'', N'', N'', N'', N'Konami', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (34, N'Câu 9', N'Trò chơi “Liên minh Huyền thoại – League of Legends (LoL) được phát hành lần đầu tiên vào năm nào?', N'', N'', N'', N'', N'2009

(ngày 27 tháng 10 năm 2009)', 6)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (35, N'Luật Thi Vòng Trò Chơi Vận Động - Ngọn Tháp Trí Tuệ', N'Mỗi đội cử 4 thành viên tham gia.

Mỗi đội sẽ tập trung ở điểm tập kết của mình phía dưới sân khấu. Phía trên sân khấu trước mặt mỗi đội chơi có 1 bộ gồm 4-7 chiếc đĩa có kích thước khác nhau được sắp xếp chồng lên nhau theo thứ tự lớn dưới, nhỏ trên ở vị trí A, các vị trí B và C trống.

Trong vòng 05 phút, lần lượt từng thành viên của mỗi đội sẽ chạy lên sân khấu và dời 01 đĩa bất kỳ từ vị trí bất kỳ đến vị trí khác theo nguyên tắc đĩa lớn không được phép chồng lên trên đĩa nhỏ. Mục đích cuối cùng là di chuyển toàn bộ các đĩa từ vị trí ban đầu A sang vị trí C.

Khi thành viên trước về đến vị trí tập kết thì thành viên tiếp theo mới được phép xuất phát.

Đội nào hoàn thành phần di chuyển trước thời gian quy định cần ra hiệu để Ban Giám khảo ghi nhận thứ tự hoàn thành của đội đó.', N'', N'', N'', N'', N'', 7)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (36, N'Luật Thi Vòng Tốc Độ', N'Mỗi đội sẽ sử dụng phần mềm Microsoft Word 2007 hoặc 2010 cài trên 3 máy khác nhau để đánh máy lại một bài viết tiếng Anh bao gồm nhiều đoạn có định dạng khác nhau (có quy định cụ thể trong đề). Được phép sử dụng tất cả các chức năng hỗ trợ của phần mềm.

Tuỳ theo yêu cầu của đề bài: 
•Thành viên trong đội sẽ lần lượt lên để đánh máy. Thời gian từ 1 – 1,5 phút. 
•Tổng cộng mỗi đội sẽ có 5 phút đến 7.5 phút.
•Các đội sẽ có 30 giây để chuẩn bị sau khi phát đề.

Các thành viên sẽ luân phiên nhau đáng văn bản và định dạng. Thành viên tiếp theo chỉ được phép bắt đầu sau thời gian thi đấu qui định của thành viên trước đó. Các thành viên khác khi đánh văn bản sẽ đứng cách xa một khoảng cách do BTC quy định.', N'', N'', N'', N'', N'', 8)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (37, N'Câu 1', N'Số chính phương nhỏ nhất có 3 chữ số là số bao nhiêu?', N'', N'', N'', N'', N'100 (10 bình phương)', 9)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (38, N'Câu 2', N'Tổng 10 số tự nhiên đầu tiên (không kể số 0) bằng bao nhiêu?', N'', N'', N'', N'', N'55

(cách tính nhanh: 10*11/2)', 9)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (39, N'Câu 3', N'Khi đăng ký một tài khoản Microsoft, bạn sẽ được cấp một hộp thư điện tử. Địa chỉ email này có phần mở rộng (sau dấu @) là gì?', N'', N'', N'', N'', N'live.com', 9)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (40, N'Câu 4', N'Trường ta bắt đầu đào tạo khóa Cao đẳng Tin học đầu tiên vào năm nào?', N'', N'', N'', N'', N'1994', 9)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (41, N'Câu 5', N'Hệ điều hành di động Android được phát triển dựa trên phần lõi của hệ điều hành nào?', N'', N'', N'', N'', N'Linux', 9)
INSERT [dbo].[CauHoi] ([maCauHoi], [tenCauHoi], [noiDung], [luaChonA], [luaChonB], [luaChonC], [luaChonD], [dapAnDung], [maTroChoi]) VALUES (42, N'Câu 6', N'Người dùng Windows cần nhấn tổ hợp phím nào để chọn nhanh một chương trình đang mở.', N'', N'', N'', N'', N'Alt-Tab', 9)
SET IDENTITY_INSERT [dbo].[CauHoi] OFF
SET IDENTITY_INSERT [dbo].[HeThi] ON 

INSERT [dbo].[HeThi] ([maHeThi], [tenHeThi]) VALUES (1, N'Khối Chuyên')
INSERT [dbo].[HeThi] ([maHeThi], [tenHeThi]) VALUES (2, N'Khối Không Chuyên')
SET IDENTITY_INSERT [dbo].[HeThi] OFF
SET IDENTITY_INSERT [dbo].[TroChoi] ON 

INSERT [dbo].[TroChoi] ([maTroChoi], [tenTroChoi], [thoiGian], [maHeThi]) VALUES (1, N'Khởi Động', 1, 1)
INSERT [dbo].[TroChoi] ([maTroChoi], [tenTroChoi], [thoiGian], [maHeThi]) VALUES (2, N'Truyền Tin', 15, 1)
INSERT [dbo].[TroChoi] ([maTroChoi], [tenTroChoi], [thoiGian], [maHeThi]) VALUES (3, N'Lập Trình Tiếp Sức', 15, 1)
INSERT [dbo].[TroChoi] ([maTroChoi], [tenTroChoi], [thoiGian], [maHeThi]) VALUES (4, N'Trò Chơi Vận Động - Lắp Ghép Chương Trình', 15, 1)
INSERT [dbo].[TroChoi] ([maTroChoi], [tenTroChoi], [thoiGian], [maHeThi]) VALUES (5, N'Đá Luân Lưu', 1, 1)
INSERT [dbo].[TroChoi] ([maTroChoi], [tenTroChoi], [thoiGian], [maHeThi]) VALUES (6, N'Khởi Động', 1, 2)
INSERT [dbo].[TroChoi] ([maTroChoi], [tenTroChoi], [thoiGian], [maHeThi]) VALUES (7, N'Trò Chơi Vận Động - Ngọn Tháp Trí Tuệ', 15, 2)
INSERT [dbo].[TroChoi] ([maTroChoi], [tenTroChoi], [thoiGian], [maHeThi]) VALUES (8, N'Tốc Độ', 15, 2)
INSERT [dbo].[TroChoi] ([maTroChoi], [tenTroChoi], [thoiGian], [maHeThi]) VALUES (9, N'Đá Lưu Luân', 1, 2)
SET IDENTITY_INSERT [dbo].[TroChoi] OFF
ALTER TABLE [dbo].[CauHoi]  WITH CHECK ADD FOREIGN KEY([maTroChoi])
REFERENCES [dbo].[TroChoi] ([maTroChoi])
GO
ALTER TABLE [dbo].[DiemSo]  WITH CHECK ADD FOREIGN KEY([maDoiThi], [maHeThi])
REFERENCES [dbo].[DoiThi] ([maDoiThi], [maHeThi])
GO
ALTER TABLE [dbo].[DiemSo]  WITH CHECK ADD FOREIGN KEY([maTroChoi])
REFERENCES [dbo].[TroChoi] ([maTroChoi])
GO
ALTER TABLE [dbo].[DoiThi]  WITH CHECK ADD FOREIGN KEY([maHeThi])
REFERENCES [dbo].[HeThi] ([maHeThi])
GO
ALTER TABLE [dbo].[TroChoi]  WITH CHECK ADD FOREIGN KEY([maHeThi])
REFERENCES [dbo].[HeThi] ([maHeThi])
GO
/****** Object:  StoredProcedure [dbo].[spDeleteCauHoi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteCauHoi]
	@maCauHoi int
AS
BEGIN
	delete from CauHoi where maCauHoi=@maCauHoi
END

GO
/****** Object:  StoredProcedure [dbo].[spDeleteDiemSo]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteDiemSo]
	@maDoiThi int,
	@maTroChoi int,
	@maHeThi int
AS
BEGIN
	delete DiemSo where maDoiThi=@maDoiThi and maTroChoi=@maTroChoi and maHeThi=@maHeThi
END

GO
/****** Object:  StoredProcedure [dbo].[spDeleteDoiThi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteDoiThi]
	@maDoiThi int,
	@maHeThi int
AS
BEGIN
	delete from DoiThi where maDoiThi=@maDoiThi and maHeThi=@maHeThi
END

GO
/****** Object:  StoredProcedure [dbo].[spDeleteHeThi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteHeThi]
	@maHeThi int
AS
BEGIN
	delete from HeThi where maHeThi=@maHeThi
END

GO
/****** Object:  StoredProcedure [dbo].[spDeleteTroChoi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spDeleteTroChoi]
	@maTroChoi int
AS
BEGIN
	delete from TroChoi where maTroChoi=@maTroChoi
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertCauHoi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--=======================================================================================================================================
-- CÂU HỎI
-- =============================================
CREATE PROCEDURE [dbo].[spInsertCauHoi]
	@tenCauHoi nvarchar(100),
	@noiDung nvarchar(MAX),
	@luaChonA nvarchar(MAX),
	@luaChonB nvarchar(MAX),
	@luaChonC nvarchar(MAX),
	@luaChonD nvarchar(MAX),
	@dapAnDUng nvarchar(100),
	@maTroChoi int
AS
BEGIN
	insert into CauHoi values(@tenCauHoi,@noiDung,@luaChonA,@luaChonB,@luaChonC,@luaChonD,@dapAnDUng,@maTroChoi)
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertDiemSo]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ĐIỂM SÔ
-- =============================================
CREATE PROCEDURE [dbo].[spInsertDiemSo]
	@maDoiThi int,
	@maTroChoi int,
	@maHeThi int,
	@diemSo float
AS
BEGIN
	insert into DiemSo values(@maDoiThi,@maTroChoi,@maHeThi,@diemSo)
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertDoiThi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- ĐỘI THI
-- =============================================
CREATE PROCEDURE [dbo].[spInsertDoiThi]
	@maHeThi int,
	@tenDoiThi nvarchar(100),
	@thanhVien1 nvarchar(100),
	@thanhVien2 nvarchar(100),
	@thanhVien3 nvarchar(100),
	@thanhVien4 nvarchar(100),
	@thanhVien5 nvarchar(100)
AS
BEGIN
	insert into DoiThi values(@maHeThi,@tenDoiThi,@thanhVien1,@thanhVien2,@thanhVien3,@thanhVien4,@thanhVien5)
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertHeThi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- HỆ THI
-- =============================================
CREATE PROCEDURE [dbo].[spInsertHeThi]
	@tenHeThi nvarchar(100)
AS
BEGIN
	insert into HeThi values(@tenHeThi)
END

GO
/****** Object:  StoredProcedure [dbo].[spInsertTroChoi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- HỆ THI
-- =============================================
CREATE PROCEDURE [dbo].[spInsertTroChoi]
	@tenTroChoi nvarchar(100),
	@thoiGian int,
	@maHeThi int
AS
BEGIN
	insert into TroChoi values(@tenTroChoi,@thoiGian,@maHeThi)
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateCauHoi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateCauHoi]
	@maCauHoi int,
	@tenCauHoi nvarchar(100),
	@noiDung nvarchar(MAX),
	@luaChonA nvarchar(MAX),
	@luaChonB nvarchar(MAX),
	@luaChonC nvarchar(MAX),
	@luaChonD nvarchar(MAX),
	@dapAnDUng nvarchar(10),
	@maTroChoi int
AS
BEGIN
	update CauHoi set tenCauHoi= @tenCauHoi,noiDung= @noiDung,
	luaChonA= @luaChonA, luaChonB= @luaChonB,luaChonC=@luaChonC,luaChonD=@luaChonD,
	dapAnDung=@dapAnDUng,maTroChoi= @maTroChoi where maCauHoi=@maCauHoi
END

GO
/****** Object:  StoredProcedure [dbo].[spUpDateDiemSo]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpDateDiemSo]
	@maDoiThi int,
	@maTroChoi int,
	@maHeThi int,
	@diemSo float
AS
BEGIN
	update DiemSo set diemSo=@diemSo where maDoiThi=@maDoiThi and maTroChoi=@maTroChoi and maHeThi=@maHeThi
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateDoiThi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateDoiThi]
	@maDoiThi int,
	@maHeThi int,
	@tenDoiThi nvarchar(100),
	@thanhVien1 nvarchar(100),
	@thanhVien2 nvarchar(100),
	@thanhVien3 nvarchar(100),
	@thanhVien4 nvarchar(100),
	@thanhVien5 nvarchar(100)
AS
BEGIN
	update DoiThi set tenDoiThi=@tenDoiThi,
	thanhVien1=@thanhVien1,thanhVien2=@thanhVien2,thanhVien3=@thanhVien3,thanhVien4=@thanhVien4,thanhVien5=@thanhVien5
	where maDoiThi=@maDoiThi and maHeThi=@maHeThi
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateHeThi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateHeThi]
	@maHeThi int,
	@tenHeThi nvarchar(100)
AS
BEGIN
	update HeThi set tenHeThi=@tenHeThi  where maHeThi=@maHeThi
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateTroChoi]    Script Date: 4/24/2016 10:27:04 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateTroChoi]
	@maTroChoi int,
	@tenTroChoi nvarchar(100),
	@thoiGian int,
	@maHeThi int
AS
BEGIN
	update TroChoi set tenTroChoi= @tenTroChoi, thoiGian=@thoiGian where maTroChoi = @maTroChoi
END

GO
USE [master]
GO
ALTER DATABASE [DB_MITContest_Final] SET  READ_WRITE 
GO
