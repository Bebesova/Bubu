USE [master]
GO
/****** Object:  Database [BebeReviews]    Script Date: 17.04.2024 20:22:05 ******/
CREATE DATABASE [BebeReviews]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'BebeReviews', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BebeReviews.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'BebeReviews_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\BebeReviews_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [BebeReviews] SET COMPATIBILITY_LEVEL = 100
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [BebeReviews].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [BebeReviews] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [BebeReviews] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [BebeReviews] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [BebeReviews] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [BebeReviews] SET ARITHABORT OFF 
GO
ALTER DATABASE [BebeReviews] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [BebeReviews] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [BebeReviews] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [BebeReviews] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [BebeReviews] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [BebeReviews] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [BebeReviews] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [BebeReviews] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [BebeReviews] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [BebeReviews] SET  DISABLE_BROKER 
GO
ALTER DATABASE [BebeReviews] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [BebeReviews] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [BebeReviews] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [BebeReviews] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [BebeReviews] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [BebeReviews] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [BebeReviews] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [BebeReviews] SET RECOVERY FULL 
GO
ALTER DATABASE [BebeReviews] SET  MULTI_USER 
GO
ALTER DATABASE [BebeReviews] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [BebeReviews] SET DB_CHAINING OFF 
GO
ALTER DATABASE [BebeReviews] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [BebeReviews] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [BebeReviews] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'BebeReviews', N'ON'
GO
ALTER DATABASE [BebeReviews] SET QUERY_STORE = OFF
GO
USE [BebeReviews]
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [BebeReviews]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 17.04.2024 20:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[id_category] [int] NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[id_category] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Title]    Script Date: 17.04.2024 20:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Title](
	[id_title] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](255) NOT NULL,
	[year] [int] NOT NULL,
	[id_category] [int] NOT NULL,
 CONSTRAINT [PK_title] PRIMARY KEY CLUSTERED 
(
	[id_title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Author_of_Title]    Script Date: 17.04.2024 20:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author_of_Title](
	[ID_Author_Title] [int] IDENTITY(1,1) NOT NULL,
	[id_author] [int] NOT NULL,
	[id_title] [int] NOT NULL,
 CONSTRAINT [PK_Author_of_Title] PRIMARY KEY CLUSTERED 
(
	[ID_Author_Title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 17.04.2024 20:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[ID_Author] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[ID_Author] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre]    Script Date: 17.04.2024 20:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre](
	[id_genre] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](100) NOT NULL,
 CONSTRAINT [PK_genre] PRIMARY KEY CLUSTERED 
(
	[id_genre] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Genre_title]    Script Date: 17.04.2024 20:22:06 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Genre_title](
	[id_gener_title] [int] IDENTITY(1,1) NOT NULL,
	[id_title] [int] NOT NULL,
	[id_genre] [int] NOT NULL,
 CONSTRAINT [PK_genre_title] PRIMARY KEY CLUSTERED 
(
	[id_gener_title] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewTitle]    Script Date: 17.04.2024 20:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewTitle]
AS
SELECT        dbo.Title.id_title AS id, dbo.Category.name AS Категория, dbo.Title.name AS Произведение, dbo.Author.Name AS Автор, dbo.Title.year AS Год, dbo.Genre.name AS Жанр
FROM            dbo.Author INNER JOIN
                         dbo.Author_of_Title ON dbo.Author.ID_Author = dbo.Author_of_Title.id_author INNER JOIN
                         dbo.Title ON dbo.Author_of_Title.id_title = dbo.Title.id_title INNER JOIN
                         dbo.Genre_title ON dbo.Title.id_title = dbo.Genre_title.id_title INNER JOIN
                         dbo.Genre ON dbo.Genre_title.id_genre = dbo.Genre.id_genre INNER JOIN
                         dbo.Category ON dbo.Title.id_category = dbo.Category.id_category
GO
/****** Object:  View [dbo].[works]    Script Date: 17.04.2024 20:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[works]
AS

SELECT distinct       st.id_title AS id, dbo.Category.name AS Категория, st.name AS Произведение, (select aa.[Name] +', '
 from [dbo].[Author_of_Title] aft 
 join [dbo].[Author] aa on aa.[ID_Author] =aft.[id_author] 
 join [dbo].[Title] tt on tt.[id_title] = aft.[id_title]
  where st.id_title = tt.id_title 
  for xml path('')) as Автор,
   st.year AS Год,
 (select gg.[name] +', '
from  [dbo].[Genre_title] gf 
join [dbo].[Genre] gg on gg.[id_genre] = gf.[id_genre]
join [dbo].[Title] tt on tt.[id_title] = gf.[id_title] 
where tt.[id_title] = st.[id_title]
for xml path('') ) as Жанр
FROM            dbo.Author INNER JOIN
dbo.Author_of_Title ON dbo.Author.ID_Author = dbo.Author_of_Title.id_author INNER JOIN
dbo.Title st ON dbo.Author_of_Title.id_title = st.id_title INNER JOIN
 dbo.Genre_title ON st.id_title = dbo.Genre_title.id_title INNER JOIN
dbo.Genre ON dbo.Genre_title.id_genre = dbo.Genre.id_genre INNER JOIN
dbo.Category ON st.id_category = dbo.Category.id_category


GO
/****** Object:  Table [dbo].[Users]    Script Date: 17.04.2024 20:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Users](
	[id_user] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Surname] [nvarchar](50) NULL,
	[Nickname] [nvarchar](50) NOT NULL,
	[email] [nvarchar](100) NOT NULL,
	[role] [int] NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_users] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Review]    Script Date: 17.04.2024 20:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Review](
	[id_review] [int] IDENTITY(1,1) NOT NULL,
	[id_title] [int] NOT NULL,
	[text] [nvarchar](max) NOT NULL,
	[id_user] [int] NOT NULL,
	[rating] [float] NOT NULL,
	[Date_pub] [datetime] NOT NULL,
 CONSTRAINT [PK_review] PRIMARY KEY CLUSTERED 
(
	[id_review] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[ViewReview]    Script Date: 17.04.2024 20:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[ViewReview]
AS
SELECT        dbo.Review.id_review, dbo.Review.Date_pub AS [Дата публикации], dbo.Users.Nickname AS Пользователь, dbo.Title.name AS Произведение, dbo.Review.text AS Отзыв, dbo.Review.rating AS Оценка
FROM            dbo.Users INNER JOIN
                         dbo.Review ON dbo.Users.id_user = dbo.Review.id_user INNER JOIN
                         dbo.Title ON dbo.Review.id_title = dbo.Title.id_title
GO
/****** Object:  Table [dbo].[Comments]    Script Date: 17.04.2024 20:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Comments](
	[id_comments] [int] NOT NULL,
	[id_review] [int] NOT NULL,
	[text] [nvarchar](4000) NOT NULL,
	[id_user] [int] NOT NULL,
	[Date_pub] [datetime] NOT NULL,
 CONSTRAINT [PK_comments] PRIMARY KEY CLUSTERED 
(
	[id_comments] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 17.04.2024 20:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id_role] [int] IDENTITY(1,1) NOT NULL,
	[name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_role] PRIMARY KEY CLUSTERED 
(
	[id_role] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([ID_Author], [Name]) VALUES (1, N'Фрэнк Дарабонт')
INSERT [dbo].[Author] ([ID_Author], [Name]) VALUES (2, N'Фрэнсис Форд Коппола')
INSERT [dbo].[Author] ([ID_Author], [Name]) VALUES (3, N'Марио Пьюзо')
INSERT [dbo].[Author] ([ID_Author], [Name]) VALUES (4, N'Сидни Люмет')
INSERT [dbo].[Author] ([ID_Author], [Name]) VALUES (5, N'Стивен Спилберг ')
INSERT [dbo].[Author] ([ID_Author], [Name]) VALUES (6, N'Квентин Тарантино')
SET IDENTITY_INSERT [dbo].[Author] OFF
SET IDENTITY_INSERT [dbo].[Author_of_Title] ON 

INSERT [dbo].[Author_of_Title] ([ID_Author_Title], [id_author], [id_title]) VALUES (1, 1, 1)
INSERT [dbo].[Author_of_Title] ([ID_Author_Title], [id_author], [id_title]) VALUES (2, 2, 2)
INSERT [dbo].[Author_of_Title] ([ID_Author_Title], [id_author], [id_title]) VALUES (3, 3, 2)
INSERT [dbo].[Author_of_Title] ([ID_Author_Title], [id_author], [id_title]) VALUES (4, 4, 3)
INSERT [dbo].[Author_of_Title] ([ID_Author_Title], [id_author], [id_title]) VALUES (5, 5, 4)
INSERT [dbo].[Author_of_Title] ([ID_Author_Title], [id_author], [id_title]) VALUES (11, 6, 5)
SET IDENTITY_INSERT [dbo].[Author_of_Title] OFF
INSERT [dbo].[Category] ([id_category], [name]) VALUES (1, N'Фильм')
INSERT [dbo].[Category] ([id_category], [name]) VALUES (2, N'Книга')
INSERT [dbo].[Category] ([id_category], [name]) VALUES (3, N'Музыка')
SET IDENTITY_INSERT [dbo].[Genre] ON 

INSERT [dbo].[Genre] ([id_genre], [name]) VALUES (1, N'драма')
INSERT [dbo].[Genre] ([id_genre], [name]) VALUES (2, N'криминал')
INSERT [dbo].[Genre] ([id_genre], [name]) VALUES (3, N'биография')
INSERT [dbo].[Genre] ([id_genre], [name]) VALUES (4, N'история')
INSERT [dbo].[Genre] ([id_genre], [name]) VALUES (5, N'военный')
INSERT [dbo].[Genre] ([id_genre], [name]) VALUES (6, N'детектив')
SET IDENTITY_INSERT [dbo].[Genre] OFF
SET IDENTITY_INSERT [dbo].[Genre_title] ON 

INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (1, 5, 1)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (2, 5, 2)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (3, 4, 1)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (4, 4, 3)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (5, 4, 4)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (6, 4, 5)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (7, 3, 1)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (8, 3, 6)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (9, 3, 2)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (10, 2, 1)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (11, 2, 2)
INSERT [dbo].[Genre_title] ([id_gener_title], [id_title], [id_genre]) VALUES (12, 1, 1)
SET IDENTITY_INSERT [dbo].[Genre_title] OFF
SET IDENTITY_INSERT [dbo].[Review] ON 

INSERT [dbo].[Review] ([id_review], [id_title], [text], [id_user], [rating], [Date_pub]) VALUES (1, 1, N'Самый лучший фильм на свете', 100, 10, CAST(N'2024-04-17T00:00:00.000' AS DateTime))
SET IDENTITY_INSERT [dbo].[Review] OFF
SET IDENTITY_INSERT [dbo].[Role] ON 

INSERT [dbo].[Role] ([id_role], [name]) VALUES (1, N'admin')
INSERT [dbo].[Role] ([id_role], [name]) VALUES (2, N'moderator')
INSERT [dbo].[Role] ([id_role], [name]) VALUES (3, N'user')
SET IDENTITY_INSERT [dbo].[Role] OFF
SET IDENTITY_INSERT [dbo].[Title] ON 

INSERT [dbo].[Title] ([id_title], [name], [year], [id_category]) VALUES (1, N'Побег из Шоушенка', 1994, 1)
INSERT [dbo].[Title] ([id_title], [name], [year], [id_category]) VALUES (2, N'Крестный отец', 1972, 1)
INSERT [dbo].[Title] ([id_title], [name], [year], [id_category]) VALUES (3, N'12 разгневанных мужчин', 1957, 1)
INSERT [dbo].[Title] ([id_title], [name], [year], [id_category]) VALUES (4, N'Список Шиндлера', 1993, 1)
INSERT [dbo].[Title] ([id_title], [name], [year], [id_category]) VALUES (5, N'Криминальное чтиво', 1994, 1)
SET IDENTITY_INSERT [dbo].[Title] OFF
INSERT [dbo].[Users] ([id_user], [Name], [Surname], [Nickname], [email], [role], [Password]) VALUES (100, NULL, NULL, N'bingobongo', N'Qwerty', 3, N'qwerty')
INSERT [dbo].[Users] ([id_user], [Name], [Surname], [Nickname], [email], [role], [Password]) VALUES (101, NULL, NULL, N'capt_obvious', N'capt_obvious@yamdb.fake', 1, N'qwerty')
INSERT [dbo].[Users] ([id_user], [Name], [Surname], [Nickname], [email], [role], [Password]) VALUES (102, NULL, NULL, N'faust', N'faust@yamdb.fake', 3, N'qwerty')
INSERT [dbo].[Users] ([id_user], [Name], [Surname], [Nickname], [email], [role], [Password]) VALUES (103, NULL, NULL, N'reviewer', N'reviewer@yamdb.fake', 3, N'qwerty')
INSERT [dbo].[Users] ([id_user], [Name], [Surname], [Nickname], [email], [role], [Password]) VALUES (104, NULL, NULL, N'angry', N'angry@yamdb.fake', 2, N'qwerty')
ALTER TABLE [dbo].[Author_of_Title]  WITH CHECK ADD  CONSTRAINT [FK_Author_of_Title_Author] FOREIGN KEY([id_author])
REFERENCES [dbo].[Author] ([ID_Author])
GO
ALTER TABLE [dbo].[Author_of_Title] CHECK CONSTRAINT [FK_Author_of_Title_Author]
GO
ALTER TABLE [dbo].[Author_of_Title]  WITH CHECK ADD  CONSTRAINT [FK_Author_of_Title_title] FOREIGN KEY([id_title])
REFERENCES [dbo].[Title] ([id_title])
GO
ALTER TABLE [dbo].[Author_of_Title] CHECK CONSTRAINT [FK_Author_of_Title_title]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_comments_review] FOREIGN KEY([id_review])
REFERENCES [dbo].[Review] ([id_review])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_comments_review]
GO
ALTER TABLE [dbo].[Comments]  WITH CHECK ADD  CONSTRAINT [FK_comments_users] FOREIGN KEY([id_user])
REFERENCES [dbo].[Users] ([id_user])
GO
ALTER TABLE [dbo].[Comments] CHECK CONSTRAINT [FK_comments_users]
GO
ALTER TABLE [dbo].[Genre_title]  WITH CHECK ADD  CONSTRAINT [FK_genre_title_genre] FOREIGN KEY([id_genre])
REFERENCES [dbo].[Genre] ([id_genre])
GO
ALTER TABLE [dbo].[Genre_title] CHECK CONSTRAINT [FK_genre_title_genre]
GO
ALTER TABLE [dbo].[Genre_title]  WITH CHECK ADD  CONSTRAINT [FK_genre_title_title] FOREIGN KEY([id_title])
REFERENCES [dbo].[Title] ([id_title])
GO
ALTER TABLE [dbo].[Genre_title] CHECK CONSTRAINT [FK_genre_title_title]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_review_title] FOREIGN KEY([id_title])
REFERENCES [dbo].[Title] ([id_title])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_review_title]
GO
ALTER TABLE [dbo].[Review]  WITH CHECK ADD  CONSTRAINT [FK_review_users] FOREIGN KEY([id_user])
REFERENCES [dbo].[Users] ([id_user])
GO
ALTER TABLE [dbo].[Review] CHECK CONSTRAINT [FK_review_users]
GO
ALTER TABLE [dbo].[Title]  WITH CHECK ADD  CONSTRAINT [FK_title_category] FOREIGN KEY([id_category])
REFERENCES [dbo].[Category] ([id_category])
GO
ALTER TABLE [dbo].[Title] CHECK CONSTRAINT [FK_title_category]
GO
ALTER TABLE [dbo].[Users]  WITH CHECK ADD  CONSTRAINT [FK_users_role] FOREIGN KEY([role])
REFERENCES [dbo].[Role] ([id_role])
GO
ALTER TABLE [dbo].[Users] CHECK CONSTRAINT [FK_users_role]
GO
/****** Object:  StoredProcedure [dbo].[auth]    Script Date: 17.04.2024 20:22:07 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[auth]
@Login nvarchar(50),
@Password nvarchar(50) 
AS
BEGIN
select* from [dbo].[Users] where [email] = @Login and [Password] =@Password
END
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Users"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 136
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 2
         End
         Begin Table = "Title"
            Begin Extent = 
               Top = 6
               Left = 250
               Bottom = 136
               Right = 424
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Review"
            Begin Extent = 
               Top = 6
               Left = 462
               Bottom = 136
               Right = 636
            End
            DisplayFlags = 280
            TopColumn = 2
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewReview'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewReview'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
         Begin Table = "Author"
            Begin Extent = 
               Top = 6
               Left = 38
               Bottom = 102
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Author_of_Title"
            Begin Extent = 
               Top = 9
               Left = 369
               Bottom = 122
               Right = 543
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Title"
            Begin Extent = 
               Top = 102
               Left = 38
               Bottom = 232
               Right = 212
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Genre_title"
            Begin Extent = 
               Top = 142
               Left = 414
               Bottom = 255
               Right = 588
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Genre"
            Begin Extent = 
               Top = 6
               Left = 581
               Bottom = 102
               Right = 755
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "Category"
            Begin Extent = 
               Top = 242
               Left = 248
               Bottom = 338
               Right = 422
            End
            DisplayFlags = 280
            TopColumn = 0
         End
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
        ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N' Alias = 900
         Table = 1170
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1350
         SortOrder = 1410
         GroupBy = 1350
         Filter = 1350
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewTitle'
GO
EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'ViewTitle'
GO
USE [master]
GO
ALTER DATABASE [BebeReviews] SET  READ_WRITE 
GO
