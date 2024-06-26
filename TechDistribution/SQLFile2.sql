USE [master]
GO
/****** Object:  Database [TechDistribution]    Script Date: 2024-03-26 11:30:07 AM ******/
CREATE DATABASE [TechDistribution]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'TechDistribution', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TechDistribution.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'TechDistribution_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.SQLEXPRESS\MSSQL\DATA\TechDistribution_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [TechDistribution] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [TechDistribution].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [TechDistribution] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [TechDistribution] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [TechDistribution] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [TechDistribution] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [TechDistribution] SET ARITHABORT OFF 
GO
ALTER DATABASE [TechDistribution] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [TechDistribution] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [TechDistribution] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [TechDistribution] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [TechDistribution] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [TechDistribution] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [TechDistribution] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [TechDistribution] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [TechDistribution] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [TechDistribution] SET  DISABLE_BROKER 
GO
ALTER DATABASE [TechDistribution] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [TechDistribution] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [TechDistribution] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [TechDistribution] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [TechDistribution] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [TechDistribution] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [TechDistribution] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [TechDistribution] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [TechDistribution] SET  MULTI_USER 
GO
ALTER DATABASE [TechDistribution] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [TechDistribution] SET DB_CHAINING OFF 
GO
ALTER DATABASE [TechDistribution] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [TechDistribution] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [TechDistribution] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [TechDistribution] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
ALTER DATABASE [TechDistribution] SET QUERY_STORE = OFF
GO
USE [TechDistribution]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookAuthors]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookAuthors](
	[BookISBN] [nvarchar](20) NOT NULL,
	[AuthorID] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[BookISBN] ASC,
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Books]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books](
	[ISBN] [nvarchar](20) NOT NULL,
	[Title] [nvarchar](255) NULL,
	[UnitPrice] [decimal](18, 2) NULL,
	[YearPublished] [int] NULL,
	[QOH] [int] NULL,
	[CategoryID] [int] NULL,
	[PublisherID] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Categories]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerId] [int] IDENTITY(1,1) NOT NULL,
	[CustomerName] [nvarchar](50) NOT NULL,
	[Street] [nvarchar](50) NOT NULL,
	[City] [nvarchar](50) NOT NULL,
	[PostalCode] [nvarchar](20) NOT NULL,
	[PhoneNumber] [nvarchar](20) NOT NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[CreditLimit] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Customers2] PRIMARY KEY CLUSTERED 
(
	[CustomerId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Employees](
	[EmployeeId] [int] IDENTITY(10000,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](50) NULL,
	[PhoneNumber] [nvarchar](50) NULL,
	[StatusId] [int] NOT NULL,
	[JobId] [int] NOT NULL,
 CONSTRAINT [PK__Employee__7AD04F11C46537C8] PRIMARY KEY CLUSTERED 
(
	[EmployeeId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Jobs]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Jobs](
	[JobId] [int] NOT NULL,
	[JobTitle] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[JobId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[OrderItems]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[OrderItems](
	[OrderID] [int] NOT NULL,
	[ISBN] [nvarchar](20) NOT NULL,
	[Quantity] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC,
	[ISBN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Orders]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Orders](
	[OrderID] [int] NOT NULL,
	[CustomerID] [int] NULL,
	[OrderDate] [datetime] NULL,
	[OrderType] [nvarchar](20) NULL,
	[PaymentMethod] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[OrderID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publishers]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherID] [int] NOT NULL,
	[PublisherName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[StatusId] [int] NOT NULL,
	[StatusDesc] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[StatusId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Suppliers]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Suppliers](
	[SupplierID] [int] NOT NULL,
	[SupplierName] [nvarchar](100) NULL,
PRIMARY KEY CLUSTERED 
(
	[SupplierID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[UserAccounts]    Script Date: 2024-03-26 11:30:08 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccounts](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[DateCreated] [datetime] NOT NULL,
	[DateModified] [datetime] NULL,
	[EmployeeId] [int] NOT NULL,
 CONSTRAINT [PK_UserAccount] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Customers] ON 

INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (1, N'AnaLarios', N'Rue Gertrude', N'Montreal', N'234RGT56', N'(437)773-9900', N'22456980', CAST(20000 AS Decimal(18, 0)))
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (4, N'Anthony B', N'Wellingthon', N'Verdun', N'2334TH56', N'(456)789-1010', N'', CAST(45000 AS Decimal(18, 0)))
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (5, N'MariaDB', N'Monk', N'Quebec', N'234HTY7', N'(555)005-7980', N'', CAST(150000 AS Decimal(18, 0)))
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (6, N'Angelica Gomez', N'La Salle', N'Montreal', N'2345DE45', N'(777)777-7777', N'34567888', CAST(78000 AS Decimal(18, 0)))
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (8, N'DayannaFlores', N'Camelias', N'Soledad', N'33333RH56', N'(555)555-6788', N'', CAST(18000 AS Decimal(18, 0)))
INSERT [dbo].[Customers] ([CustomerId], [CustomerName], [Street], [City], [PostalCode], [PhoneNumber], [FaxNumber], [CreditLimit]) VALUES (9, N'damien', N'39', N'verdun', N'h4g1r5', N'(514)894-7403', N'', CAST(100 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[Customers] OFF
GO
SET IDENTITY_INSERT [dbo].[Employees] ON 

INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Email], [PhoneNumber], [StatusId], [JobId]) VALUES (10000, N'Anthony', N'Lijarza', N'anthonylf797@gmail.com', N'(514)573-4186', 3, 1)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Email], [PhoneNumber], [StatusId], [JobId]) VALUES (10001, N'Ana', N'Larios', N'ana.larios19@gmail.com', N'(777)777-7777', 3, 1)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Email], [PhoneNumber], [StatusId], [JobId]) VALUES (10003, N'Francisco', N'Caicedo', N'francisco.caicedo@gmail.com', N'(514)777-7777', 4, 2)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Email], [PhoneNumber], [StatusId], [JobId]) VALUES (10004, N'Sergio', N'Quiroz', N'sergio.aqs17@gmail.com', N'(514)123-1234', 4, 4)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Email], [PhoneNumber], [StatusId], [JobId]) VALUES (10005, N'Sheyla', N'Lijarza', N'sheylad23@gmail.com', N'(555)555-5555', 4, 1)
INSERT [dbo].[Employees] ([EmployeeId], [FirstName], [LastName], [Email], [PhoneNumber], [StatusId], [JobId]) VALUES (10010, N'Misa', N'Amane', N'misa.amane19@gmail.com', N'(123)456-7890', 5, 3)
SET IDENTITY_INSERT [dbo].[Employees] OFF
GO
INSERT [dbo].[Jobs] ([JobId], [JobTitle]) VALUES (1, N'MIS Manager')
INSERT [dbo].[Jobs] ([JobId], [JobTitle]) VALUES (2, N'Sales Manager')
INSERT [dbo].[Jobs] ([JobId], [JobTitle]) VALUES (3, N'Inventory Controller')
INSERT [dbo].[Jobs] ([JobId], [JobTitle]) VALUES (4, N'Order Clerk')
GO
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (1, N'ACTIVE')
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (2, N'INACTIVE')
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (3, N'FULL-TIME')
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (4, N'PART-TIME')
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (5, N'CONTRACTED')
GO
SET IDENTITY_INSERT [dbo].[UserAccounts] ON 

INSERT [dbo].[UserAccounts] ([UserId], [Password], [DateCreated], [DateModified], [EmployeeId]) VALUES (19, N'2222222', CAST(N'2024-03-20T22:36:04.313' AS DateTime), NULL, 10000)
INSERT [dbo].[UserAccounts] ([UserId], [Password], [DateCreated], [DateModified], [EmployeeId]) VALUES (20, N'ana4444', CAST(N'2024-03-20T22:36:28.550' AS DateTime), CAST(N'2024-03-20T23:00:24.670' AS DateTime), 10001)
INSERT [dbo].[UserAccounts] ([UserId], [Password], [DateCreated], [DateModified], [EmployeeId]) VALUES (21, N'abdefff', CAST(N'2024-03-20T22:37:18.903' AS DateTime), NULL, 10003)
SET IDENTITY_INSERT [dbo].[UserAccounts] OFF
GO
ALTER TABLE [dbo].[UserAccounts] ADD  CONSTRAINT [DF_DateCreated]  DEFAULT (getdate()) FOR [DateCreated]
GO
ALTER TABLE [dbo].[BookAuthors]  WITH CHECK ADD FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[BookAuthors]  WITH CHECK ADD FOREIGN KEY([BookISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publishers] ([PublisherID])
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK__Employees__Statu__3F466844] FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK__Employees__Statu__3F466844]
GO
ALTER TABLE [dbo].[Employees]  WITH CHECK ADD  CONSTRAINT [FK_Employees_Jobs] FOREIGN KEY([JobId])
REFERENCES [dbo].[Jobs] ([JobId])
GO
ALTER TABLE [dbo].[Employees] CHECK CONSTRAINT [FK_Employees_Jobs]
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD FOREIGN KEY([OrderID])
REFERENCES [dbo].[Orders] ([OrderID])
GO
ALTER TABLE [dbo].[OrderItems]  WITH CHECK ADD FOREIGN KEY([ISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[UserAccounts]  WITH CHECK ADD  CONSTRAINT [FK_UserAccounts_Employees] FOREIGN KEY([EmployeeId])
REFERENCES [dbo].[Employees] ([EmployeeId])
GO
ALTER TABLE [dbo].[UserAccounts] CHECK CONSTRAINT [FK_UserAccounts_Employees]
GO
USE [master]
GO
ALTER DATABASE [TechDistribution] SET  READ_WRITE 
GO
