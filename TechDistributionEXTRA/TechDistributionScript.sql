USE [master]
GO
/****** Object:  Database [TechDistribution]    Script Date: 4/18/2024 11:33:26 PM ******/
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
/****** Object:  Table [dbo].[Authors]    Script Date: 4/18/2024 11:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](50) NULL,
	[LastName] [nvarchar](50) NULL,
	[Email] [nvarchar](100) NULL,
 CONSTRAINT [PK__Authors__70DAFC142A7E304E] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookAuthors]    Script Date: 4/18/2024 11:33:26 PM ******/
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
/****** Object:  Table [dbo].[Books]    Script Date: 4/18/2024 11:33:26 PM ******/
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
/****** Object:  Table [dbo].[Categories]    Script Date: 4/18/2024 11:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Categories](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nvarchar](50) NULL,
 CONSTRAINT [PK__Categori__19093A2B2F82C49C] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Customers]    Script Date: 4/18/2024 11:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customers](
	[CustomerID] [int] NOT NULL,
	[CustomerName] [nvarchar](100) NULL,
	[Street] [nvarchar](255) NULL,
	[City] [nvarchar](50) NULL,
	[PostalCode] [nvarchar](15) NULL,
	[PhoneNumber] [nvarchar](20) NULL,
	[FaxNumber] [nvarchar](20) NULL,
	[CreditLimit] [decimal](18, 2) NULL,
PRIMARY KEY CLUSTERED 
(
	[CustomerID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Employees]    Script Date: 4/18/2024 11:33:26 PM ******/
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
/****** Object:  Table [dbo].[Jobs]    Script Date: 4/18/2024 11:33:26 PM ******/
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
/****** Object:  Table [dbo].[OrderItems]    Script Date: 4/18/2024 11:33:26 PM ******/
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
/****** Object:  Table [dbo].[Orders]    Script Date: 4/18/2024 11:33:26 PM ******/
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
/****** Object:  Table [dbo].[Publishers]    Script Date: 4/18/2024 11:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publishers](
	[PublisherID] [int] IDENTITY(1,1) NOT NULL,
	[PublisherName] [nvarchar](100) NULL,
 CONSTRAINT [PK__Publishe__4C657E4BC5916F72] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 4/18/2024 11:33:26 PM ******/
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
/****** Object:  Table [dbo].[Suppliers]    Script Date: 4/18/2024 11:33:26 PM ******/
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
/****** Object:  Table [dbo].[UserAccounts]    Script Date: 4/18/2024 11:33:26 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserAccounts](
	[UserId] [int] NOT NULL,
	[Password] [nvarchar](50) NULL,
	[DateCreated] [datetime] NULL,
	[DateModified] [datetime] NULL,
	[StatusId] [int] NULL,
	[EmployeeId] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Authors] ON 

INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (1, N'Sergio', N'Quiroz', N'cpp@gmail.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (2, N'JK', N'Rowling', N'sergioaqs17@gmail.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (3, N'J.K.', N'Rowling', N'jkrowling@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (4, N'Harper', N'Lee', N'harperlee@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (5, N'Suzanne', N'Collins', N'suzannecollins@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (6, N'Veronica', N'Roth', N'veronicaroth@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (7, N'John', N'Green', N'johngreen@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (8, N'Stephen', N'King', N'stephenking@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (9, N'Agatha', N'Christie', N'agathachristie@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (10, N'George', N'Orwell', N'georgeorwell@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (11, N'J.R.R.', N'Tolkien', N'jrrtolkien@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (12, N'Margaret', N'Atwood', N'margaretatwood@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (13, N'Neil', N'Gaiman', N'neilgaiman@example.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (14, N'asdasd', N'asdasd', N'asdasd@gmail.com')
INSERT [dbo].[Authors] ([AuthorID], [FirstName], [LastName], [Email]) VALUES (15, N'Julio', N'asdasd', N'asdasd@gmail.com')
SET IDENTITY_INSERT [dbo].[Authors] OFF
GO
INSERT [dbo].[BookAuthors] ([BookISBN], [AuthorID]) VALUES (N'1234dfsd23', 2)
GO
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [QOH], [CategoryID], [PublisherID]) VALUES (N'1234dfsd23', NULL, NULL, NULL, NULL, NULL, NULL)
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [QOH], [CategoryID], [PublisherID]) VALUES (N'978-0-306-40615-7', N'To Kill a Mockingbird', CAST(1960.00 AS Decimal(18, 2)), 1960, 100, 10, 4)
INSERT [dbo].[Books] ([ISBN], [Title], [UnitPrice], [YearPublished], [QOH], [CategoryID], [PublisherID]) VALUES (N'978-0-545-01022-3', N'Harry Potter and the Sorcerer''s Stone', CAST(1997.00 AS Decimal(18, 2)), 1997, 150, 5, 12)
GO
SET IDENTITY_INSERT [dbo].[Categories] ON 

INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (1, N'Fiction')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (2, N'Non-Fiction')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (3, N'Mystery')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (4, N'Science Fiction')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (5, N'Fantasy')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (6, N'Romance')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (7, N'Thriller/Suspense')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (8, N'Horror')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (9, N'Biography/Autobiography')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (10, N'Poetry')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (11, N'Self-Help')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (12, N'History')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (13, N'Travel')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (14, N'Science/Nature')
INSERT [dbo].[Categories] ([CategoryID], [CategoryName]) VALUES (15, N'Business/Economics')
SET IDENTITY_INSERT [dbo].[Categories] OFF
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
SET IDENTITY_INSERT [dbo].[Publishers] ON 

INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (1, N'Penguin Random House')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (2, N'HarperCollins Publishers')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (3, N'Simon & Schuster')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (4, N'Hachette Livre')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (5, N'Macmillan Publishers')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (6, N'Scholastic Corporation')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (7, N'Pearson PLC')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (8, N'Wiley')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (9, N'Elsevier')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (10, N'Springer Nature')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (11, N'Oxford University Press')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (12, N'Cambridge University Press')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (13, N'Bloomsbury Publishing')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (14, N'John Wiley & Sons')
INSERT [dbo].[Publishers] ([PublisherID], [PublisherName]) VALUES (15, N'Taylor & Francis')
SET IDENTITY_INSERT [dbo].[Publishers] OFF
GO
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (1, N'ACTIVE')
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (2, N'INACTIVE')
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (3, N'FULL-TIME')
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (4, N'PART-TIME')
INSERT [dbo].[Status] ([StatusId], [StatusDesc]) VALUES (5, N'CONTRACTED')
GO
ALTER TABLE [dbo].[BookAuthors]  WITH CHECK ADD  CONSTRAINT [FK__BookAutho__Autho__3B75D760] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Authors] ([AuthorID])
GO
ALTER TABLE [dbo].[BookAuthors] CHECK CONSTRAINT [FK__BookAutho__Autho__3B75D760]
GO
ALTER TABLE [dbo].[BookAuthors]  WITH CHECK ADD FOREIGN KEY([BookISBN])
REFERENCES [dbo].[Books] ([ISBN])
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK__Books__CategoryI__3D5E1FD2] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Categories] ([CategoryID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK__Books__CategoryI__3D5E1FD2]
GO
ALTER TABLE [dbo].[Books]  WITH CHECK ADD  CONSTRAINT [FK__Books__Publisher__3E52440B] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publishers] ([PublisherID])
GO
ALTER TABLE [dbo].[Books] CHECK CONSTRAINT [FK__Books__Publisher__3E52440B]
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
ALTER TABLE [dbo].[Orders]  WITH CHECK ADD FOREIGN KEY([CustomerID])
REFERENCES [dbo].[Customers] ([CustomerID])
GO
ALTER TABLE [dbo].[UserAccounts]  WITH CHECK ADD FOREIGN KEY([StatusId])
REFERENCES [dbo].[Status] ([StatusId])
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
