USE [master]
GO
/****** Object:  Database [GrowXDB]    Script Date: 23/08/2019 18:22:16 ******/
CREATE DATABASE [GrowXDB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'GrowXDB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\GrowXDB.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'GrowXDB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL14.SQLEXPRESS01\MSSQL\DATA\GrowXDB_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [GrowXDB] SET COMPATIBILITY_LEVEL = 140
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [GrowXDB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [GrowXDB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [GrowXDB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [GrowXDB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [GrowXDB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [GrowXDB] SET ARITHABORT OFF 
GO
ALTER DATABASE [GrowXDB] SET AUTO_CLOSE ON 
GO
ALTER DATABASE [GrowXDB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [GrowXDB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [GrowXDB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [GrowXDB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [GrowXDB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [GrowXDB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [GrowXDB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [GrowXDB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [GrowXDB] SET  ENABLE_BROKER 
GO
ALTER DATABASE [GrowXDB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [GrowXDB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [GrowXDB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [GrowXDB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [GrowXDB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [GrowXDB] SET READ_COMMITTED_SNAPSHOT ON 
GO
ALTER DATABASE [GrowXDB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [GrowXDB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [GrowXDB] SET  MULTI_USER 
GO
ALTER DATABASE [GrowXDB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [GrowXDB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [GrowXDB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [GrowXDB] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [GrowXDB] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [GrowXDB] SET QUERY_STORE = OFF
GO
USE [GrowXDB]
GO
/****** Object:  Table [dbo].[__EFMigrationsHistory]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[__EFMigrationsHistory](
	[MigrationId] [nvarchar](150) NOT NULL,
	[ProductVersion] [nvarchar](32) NOT NULL,
 CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY CLUSTERED 
(
	[MigrationId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoleClaims]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoleClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetRoles]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetRoles](
	[Id] [nvarchar](450) NOT NULL,
	[Name] [nvarchar](256) NULL,
	[NormalizedName] [nvarchar](256) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetRoles] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserClaims]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserClaims](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [nvarchar](450) NOT NULL,
	[ClaimType] [nvarchar](max) NULL,
	[ClaimValue] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserLogins]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserLogins](
	[LoginProvider] [nvarchar](128) NOT NULL,
	[ProviderKey] [nvarchar](128) NOT NULL,
	[ProviderDisplayName] [nvarchar](max) NULL,
	[UserId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY CLUSTERED 
(
	[LoginProvider] ASC,
	[ProviderKey] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserRoles]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserRoles](
	[UserId] [nvarchar](450) NOT NULL,
	[RoleId] [nvarchar](450) NOT NULL,
 CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUsers]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUsers](
	[Id] [nvarchar](450) NOT NULL,
	[UserName] [nvarchar](256) NULL,
	[NormalizedUserName] [nvarchar](256) NULL,
	[Email] [nvarchar](256) NULL,
	[NormalizedEmail] [nvarchar](256) NULL,
	[EmailConfirmed] [bit] NOT NULL,
	[PasswordHash] [nvarchar](max) NULL,
	[SecurityStamp] [nvarchar](max) NULL,
	[ConcurrencyStamp] [nvarchar](max) NULL,
	[PhoneNumber] [nvarchar](max) NULL,
	[PhoneNumberConfirmed] [bit] NOT NULL,
	[TwoFactorEnabled] [bit] NOT NULL,
	[LockoutEnd] [datetimeoffset](7) NULL,
	[LockoutEnabled] [bit] NOT NULL,
	[AccessFailedCount] [int] NOT NULL,
 CONSTRAINT [PK_AspNetUsers] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AspNetUserTokens]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AspNetUserTokens](
	[UserId] [nvarchar](450) NOT NULL,
	[LoginProvider] [nvarchar](128) NOT NULL,
	[Name] [nvarchar](128) NOT NULL,
	[Value] [nvarchar](max) NULL,
 CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[LoginProvider] ASC,
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Client]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Client](
	[idC] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[domain] [varchar](50) NULL,
	[phoneNumber] [int] NULL,
	[mail] [varchar](50) NULL,
	[imagePath] [varchar](50) NULL,
	[locationAddress] [varchar](50) NULL,
	[idCompany] [int] NULL,
	[category] [varchar](50) NULL,
	[details] [varchar](max) NULL,
 CONSTRAINT [PK_Client] PRIMARY KEY CLUSTERED 
(
	[idC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Company]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Company](
	[idCmp] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[location] [varchar](50) NULL,
	[mail] [varchar](50) NULL,
	[phone] [varchar](50) NULL,
 CONSTRAINT [PK_Company] PRIMARY KEY CLUSTERED 
(
	[idCmp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Events]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Events](
	[idE] [int] IDENTITY(1,1) NOT NULL,
	[title] [varchar](50) NULL,
	[organizer] [varchar](50) NULL,
	[description] [varchar](max) NULL,
	[location] [varchar](50) NULL,
	[dateEvent] [date] NULL,
	[imageEvent] [varchar](50) NULL,
	[idCompany] [int] NULL,
	[idEventType] [int] NULL,
	[datePub] [date] NULL,
 CONSTRAINT [PK_Events] PRIMARY KEY CLUSTERED 
(
	[idE] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[EventType]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[EventType](
	[idTypeEvent] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
 CONSTRAINT [PK_EventType] PRIMARY KEY CLUSTERED 
(
	[idTypeEvent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Objectives]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Objectives](
	[idObj] [int] IDENTITY(1,1) NOT NULL,
	[objectiveName] [varchar](50) NULL,
	[description] [varchar](max) NULL,
	[colbComment] [varchar](max) NULL,
	[mngrComment] [varchar](max) NULL,
	[validation] [bit] NULL,
	[rating] [int] NULL,
	[timeEstimation] [int] NULL,
	[progression] [int] NULL,
	[type] [varchar](50) NULL,
	[idMng] [nvarchar](450) NULL,
	[idColb] [nvarchar](450) NULL,
 CONSTRAINT [PK_Objectives] PRIMARY KEY CLUSTERED 
(
	[idObj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Project]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[idP] [int] IDENTITY(1,1) NOT NULL,
	[name] [varchar](50) NULL,
	[details] [varchar](max) NULL,
	[imagePath] [varchar](max) NULL,
	[dateBegin] [date] NULL,
	[dateFinish] [date] NULL,
	[timeSpent] [int] NULL,
	[timeEstimated] [int] NULL,
	[progressPercent] [int] NULL,
	[state] [varchar](50) NULL,
	[idCompany] [int] NULL,
	[idClient] [int] NULL,
 CONSTRAINT [PK_Project_1] PRIMARY KEY CLUSTERED 
(
	[idP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 23/08/2019 18:22:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[idUser] [nvarchar](450) NOT NULL,
	[id_Company] [int] NULL,
	[imagePath] [varchar](50) NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[idUser] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'841258bc-3c6e-42da-acae-4b0c33992512', N'User', N'USER', N'f2977b78-0967-4fc4-9c15-13e89469f9bf')
INSERT [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'997cd743-f937-4318-936e-2892f37f2d19', N'Admin', N'ADMIN', N'54e88abe-4a2b-4f09-8ad5-1a1cc9804ddb')
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] ON 

INSERT [dbo].[AspNetUserClaims] ([Id], [UserId], [ClaimType], [ClaimValue]) VALUES (2, N'eaa28278-e322-4bff-9b92-833de556d538', N'http://schemas.microsoft.com/ws/2008/06/identity/claims/role', N'Admin')
SET IDENTITY_INSERT [dbo].[AspNetUserClaims] OFF
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'acd0830b-3635-4664-ad75-6723b45fff01', N'841258bc-3c6e-42da-acae-4b0c33992512')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'c24f0e4c-a9a3-4f96-8a99-521faff8165a', N'841258bc-3c6e-42da-acae-4b0c33992512')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e0a3eb51-1e9b-4448-a031-c47913945134', N'841258bc-3c6e-42da-acae-4b0c33992512')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'2e34d3ed-33ef-4188-bbf3-d92c2ed1b0c7', N'997cd743-f937-4318-936e-2892f37f2d19')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'e38ac2bd-78a4-445f-9459-51ebce4b914d', N'997cd743-f937-4318-936e-2892f37f2d19')
INSERT [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'eaa28278-e322-4bff-9b92-833de556d538', N'997cd743-f937-4318-936e-2892f37f2d19')
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'2e34d3ed-33ef-4188-bbf3-d92c2ed1b0c7', N'Aymen', N'AYMEN', N'aymen.benghorbel@esprit.tn', N'AYMEN.BENGHORBEL@ESPRIT.TN', 0, N'AQAAAAEAACcQAAAAEFq7cNU0NWVPRg9RWnoo7qNyp4mkXrxmxV5NJAQMFtLBQ+PW5vR2LsIDLcbsuIP74Q==', N'6F5I4CP2MBQKTB25F3EVBPFGZISGMSFY', N'ef15065b-c094-4199-bd55-4b2e9d128eb2', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'acd0830b-3635-4664-ad75-6723b45fff01', N'Nizar', N'NIZAR', N'Nizar.benMaalem@Quantylix.com', N'NIZAR.BENMAALEM@QUANTYLIX.COM', 0, N'AQAAAAEAACcQAAAAEMcIwJSH8DwYe8hKslcUFwpXc7yCFu4XV3/6qA1eNPLZ/DhVrl/i0wM26t+ko3+zFA==', N'PGL255Z7OX6AHSCYDEO7MEV2INYO55LO', N'aed78f57-b3c8-4b09-9a9c-afa58bd1caad', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'c24f0e4c-a9a3-4f96-8a99-521faff8165a', N'User@Quantilyx.com', N'USER@QUANTILYX.COM', N'User@Quantilyx.com', N'USER@QUANTILYX.COM', 0, N'AQAAAAEAACcQAAAAEIOTGBpj4h7hvbx5Oy7pnHom7JVshQe067DmaUAMKOPCuqUQojP8zWdIzZYU1sZbCQ==', N'ESMGUCB4FEHHUXQAFZSGOBGRKBZHW3KH', N'0f849014-1245-4c9c-923c-1e32da8ffa8a', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e0a3eb51-1e9b-4448-a031-c47913945134', N'Userr', N'USERR', N'User@user.com', N'USER@USER.COM', 0, N'AQAAAAEAACcQAAAAEFpObukKQZItnuI99842eyWxvgvA6lI/9Ej+ohfnC1Gv2xFqrkvtEMd+NLsE57fP+w==', N'NZS75KDNMSNAKEXGVEDCSRMLIQ74MJEO', N'1ca503fc-e646-4b1e-af81-32fcdc541925', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e38ac2bd-78a4-445f-9459-51ebce4b914d', N'aaa', N'AAA', N'aaa@aaa.com', N'AAA@AAA.COM', 0, N'AQAAAAEAACcQAAAAEIFhqOfP2LlflBjs7qlOH+6coMDO5soEO0nlQD+UfDGKlEIq0c5cg+se57fG383xTQ==', N'AEX65D3UFQKQQLDXHAB3D6473N2NHRU5', N'459e7ab8-6d60-43b7-a427-a95c39e05052', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'e470d2cd-3108-41df-843c-f779f8afeb50', N'Nadhmi', N'NADHMI', N'nadhmi@quantylix.com', N'NADHMI@QUANTYLIX.COM', 0, N'AQAAAAEAACcQAAAAEJqdKdqcZUe7C2sB/ZDiJlY+kjczPN4zG8kmzy2FU2UYEQxzj0XFXqhYsBhhZViprA==', N'D5C4QC6Y46FAFOD7BZOCTQBY3SHKF36J', N'd26fa2a6-d8e5-4be4-a1b6-f06d088dffb4', NULL, 0, 0, NULL, 1, 0)
INSERT [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'eaa28278-e322-4bff-9b92-833de556d538', N'Admin', N'ADMIN', N'Admin@Quantylix.com', N'ADMIN@QUANTYLIX.COM', 0, N'AQAAAAEAACcQAAAAEEyT8DC0XsX+EgwgwzYV6Z9IXcX2mlvW6e0x58DEqUt6S7c60md24w3891diO6zW1Q==', N'JVLSQWCHQINDRDOAQKRVDSH6SPAMN364', N'ce623641-76aa-4975-b0ae-e4aad9be409c', NULL, 0, 0, NULL, 1, 0)
SET IDENTITY_INSERT [dbo].[Client] ON 

INSERT [dbo].[Client] ([idC], [name], [domain], [phoneNumber], [mail], [imagePath], [locationAddress], [idCompany], [category], [details]) VALUES (9, N'Esprit', N'Information Technology', 71250000, N'EspritGhazela@esprit.com', N'/images/img9_57031998.png', N'Ariana, Ghazela.', NULL, N'Prospect', N'Avec plus de 5000 étudiants et 240 enseignants permanents, Esprit est le plus grand établissement privé d’enseignement supérieur en Tunisie.
Fondé en 2003 il s’est rapidement forgé une réputation d’excellence, grâce à sa proximité avec l’univers entrepreneurial, ses partenariats avec les universités étrangères, et sa méthode d’apprentissage par problèmes et projets.
ESPRIT forme des ingénieurs opérationnels dans 4 spécialités : la télécommunication, la technologie de l''information et de la communication, le génie civil, l’électromécanique.
En septembre 2017, l''ensemble des formations d''Esprit ont obtenu l’accréditation d''EUR-ACE fournie par l''organisation française CTI (Comité des titres d’ingénieurs) :
- Renouvellement de 6 ans pour les filières Informatique et Télécommunications
- 3 ans pour les filières Génie Civil et Électromécanique, une première pour ces deux formations.
L’école est également membre du consortium de CDIO (Conceive, Design, Implement, Operate) fondé par Massachusetts Institute of Technology. Pour finir Esprit est membre de la conférence des Grandes Ecoles (CGE) qui labellise les écoles d’ingénieur et de commerce les plus prestigieuses du monde.
Les plus d’Esprit :
- Une exigence de qualité jamais démentie (cours en petits groupes, suivi personnalisé, nombreux stages, équipements performants ….) ;
- Une ouverture à l’international : double diplômes, stages ou semestres d’étude à l’étranger ;
- La recherche et développement, plus de 20 équipes travaillent au plus près des besoins des entreprises.
Depuis sa création en 2003, Esprit a évolué et plusieurs entités ont vu le jour : Esprit Entreprise (formation en direction des entreprises), Esprit Éducation (un groupe scolaire), ESB (formation en management) et Top Skills (cabinet de formation continue)
ESPRIT (Ecole Supérieure Privée d''Ingénierie et de Technologies)')
INSERT [dbo].[Client] ([idC], [name], [domain], [phoneNumber], [mail], [imagePath], [locationAddress], [idCompany], [category], [details]) VALUES (10, N'Enactus', N'Entrepreneuriat sociale', 33332222, N'enactusICT@enactus.com', N'/images/img0_55546612.jpg', N'Ariana,Tunis.', NULL, N'Prospect', N'Projets innovants dans l''entrepreneuriat sociale faites par des étudiants')
INSERT [dbo].[Client] ([idC], [name], [domain], [phoneNumber], [mail], [imagePath], [locationAddress], [idCompany], [category], [details]) VALUES (11, N'Robophiles', N'Robotique', 78945612, N'robophiles@mail.com', N'/images/img0_3508748.jpg', N'Bardo , Tunis.', NULL, N'Client', N'Réalisation de tout les types de robots et les implémenter dans n''importe quel domaine souhaité')
INSERT [dbo].[Client] ([idC], [name], [domain], [phoneNumber], [mail], [imagePath], [locationAddress], [idCompany], [category], [details]) VALUES (12, N'dfg', N'Biomedicale', 63659888, N'istmtBio@istmt.com', N'/images/img12_41575424.png', N'Beb Saadoun, Tunis.', NULL, N'Client', N'fff')
INSERT [dbo].[Client] ([idC], [name], [domain], [phoneNumber], [mail], [imagePath], [locationAddress], [idCompany], [category], [details]) VALUES (13, N'aeae', N'Information Technology', 33332222, N'enactusICT@enactus.com', N'/images/img0_18372080.jpg', N'Beb Saadoun, Tunis.', 1, N'Prospect', N'ea')
INSERT [dbo].[Client] ([idC], [name], [domain], [phoneNumber], [mail], [imagePath], [locationAddress], [idCompany], [category], [details]) VALUES (14, N'azdz', N'Infordaadamation Technology', 523895623, N'dzijz@mm.com', N'/images/img0_1271576.jpg', N'eaeaea', 1, N'Client', N'dada')
SET IDENTITY_INSERT [dbo].[Client] OFF
SET IDENTITY_INSERT [dbo].[Company] ON 

INSERT [dbo].[Company] ([idCmp], [name], [location], [mail], [phone]) VALUES (1, N'Quantylix', N'La Goulette', N'contact@quantylix.com', N'0021671738039')
SET IDENTITY_INSERT [dbo].[Company] OFF
SET IDENTITY_INSERT [dbo].[Events] ON 

INSERT [dbo].[Events] ([idE], [title], [organizer], [description], [location], [dateEvent], [imageEvent], [idCompany], [idEventType], [datePub]) VALUES (11, N'teeeeeeeeeeeeeeeeeeeeeeeeeee', N'eeeeeeeeeeeeeeeeeeeee', N'<p>e</p>
', N'eeeeeeee', CAST(N'2019-09-21' AS Date), N'/images/img0_46915358.jpg', NULL, 1, CAST(N'2019-08-23' AS Date))
INSERT [dbo].[Events] ([idE], [title], [organizer], [description], [location], [dateEvent], [imageEvent], [idCompany], [idEventType], [datePub]) VALUES (12, N'ttttttttttttttttttteeeeeeeee', N'test2', N'<p>eeeeeee</p>
', N'Djerba , Tunisie.', CAST(N'2019-09-21' AS Date), N'/images/img0_29994181.jpg', NULL, 2, CAST(N'2019-08-23' AS Date))
INSERT [dbo].[Events] ([idE], [title], [organizer], [description], [location], [dateEvent], [imageEvent], [idCompany], [idEventType], [datePub]) VALUES (13, N'aaaaaaaaaaaaaa', N'aak', N'<p>aaaaaaaaaaaaaaaaaa</p>
', N'Bardo , Tunis.', CAST(N'2019-11-02' AS Date), N'/images/img0_79654752.jpg', NULL, 3, CAST(N'2019-08-23' AS Date))
SET IDENTITY_INSERT [dbo].[Events] OFF
SET IDENTITY_INSERT [dbo].[EventType] ON 

INSERT [dbo].[EventType] ([idTypeEvent], [name]) VALUES (1, N'New Client')
INSERT [dbo].[EventType] ([idTypeEvent], [name]) VALUES (2, N'Project Success')
INSERT [dbo].[EventType] ([idTypeEvent], [name]) VALUES (3, N'Birthday')
SET IDENTITY_INSERT [dbo].[EventType] OFF
SET IDENTITY_INSERT [dbo].[Project] ON 

INSERT [dbo].[Project] ([idP], [name], [details], [imagePath], [dateBegin], [dateFinish], [timeSpent], [timeEstimated], [progressPercent], [state], [idCompany], [idClient]) VALUES (22, N'Aymeen Testing ', N'<p>hjhklm</p>
', N'/images/img22_72929638.jpg', CAST(N'2019-08-22' AS Date), CAST(N'2019-08-30' AS Date), 14, 49, 50, N'Nouveau', 1, 10)
INSERT [dbo].[Project] ([idP], [name], [details], [imagePath], [dateBegin], [dateFinish], [timeSpent], [timeEstimated], [progressPercent], [state], [idCompany], [idClient]) VALUES (23, N'Testing Modification', N'azertuiophgfdsq', N'/images/img23_88287783.jpg', CAST(N'2019-08-07' AS Date), CAST(N'2019-08-24' AS Date), 8, 15, 20, N'En Cours', 1, 10)
INSERT [dbo].[Project] ([idP], [name], [details], [imagePath], [dateBegin], [dateFinish], [timeSpent], [timeEstimated], [progressPercent], [state], [idCompany], [idClient]) VALUES (24, N'Test test', N'tessst', N'/images/img24_75882816.jpg', CAST(N'2015-08-08' AS Date), CAST(N'2019-07-07' AS Date), 4, 9, 20, N'En Cours', 1, 10)
INSERT [dbo].[Project] ([idP], [name], [details], [imagePath], [dateBegin], [dateFinish], [timeSpent], [timeEstimated], [progressPercent], [state], [idCompany], [idClient]) VALUES (25, N'Aymen ckeditor', N'<p><strong>HOLAAAAAAAAAAAAAA</strong></p>

<hr />
<ul>
	<li>Testting this and that</li>
	<li>And abbout idk&nbsp;
	<ul>
		<li>finally&nbsp;</li>
		<li>
		<h2 style="font-style:italic;">iayrhoa</h2>
		</li>
	</ul>
	</li>
</ul>
', N'/images/img0_94248039.jpg', CAST(N'2019-08-09' AS Date), CAST(N'2019-08-20' AS Date), 5, 20, 50, N'Nouveau', 1, 10)
INSERT [dbo].[Project] ([idP], [name], [details], [imagePath], [dateBegin], [dateFinish], [timeSpent], [timeEstimated], [progressPercent], [state], [idCompany], [idClient]) VALUES (26, N'Test new Design', N'<p>aeae</p>
', N'/images/img26_203472.jpg', CAST(N'2019-08-02' AS Date), CAST(N'2019-07-31' AS Date), 0, 78, 50, N'Nouveau', 1, 9)
INSERT [dbo].[Project] ([idP], [name], [details], [imagePath], [dateBegin], [dateFinish], [timeSpent], [timeEstimated], [progressPercent], [state], [idCompany], [idClient]) VALUES (27, N'Testttt', N'<p><strong>Titre</strong></p>

<hr />
<ol>
	<li>aaaa</li>
	<li>aaa</li>
	<li>aa</li>
</ol>
', N'/images/img0_17877888.jpg', CAST(N'2019-08-02' AS Date), CAST(N'2019-08-31' AS Date), 9, 28, 45, N'Nouveau', 1, 10)
INSERT [dbo].[Project] ([idP], [name], [details], [imagePath], [dateBegin], [dateFinish], [timeSpent], [timeEstimated], [progressPercent], [state], [idCompany], [idClient]) VALUES (28, N'Projet Khaled', N'<ul>
	<li>Lorem ipsum dolor sit amet, consectetur adipiscing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat.</li>
	<li>Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.</li>
</ul>
', N'/images/img0_32363378.jpg', CAST(N'2019-08-25' AS Date), CAST(N'2019-08-25' AS Date), 0, 28, 0, N'Nouveau', 1, 9)
SET IDENTITY_INSERT [dbo].[Project] OFF
INSERT [dbo].[User] ([idUser], [id_Company], [imagePath]) VALUES (N'2e34d3ed-33ef-4188-bbf3-d92c2ed1b0c7', NULL, N'/images/img/photo1')
INSERT [dbo].[User] ([idUser], [id_Company], [imagePath]) VALUES (N'acd0830b-3635-4664-ad75-6723b45fff01', NULL, N'/images/img/photo1')
INSERT [dbo].[User] ([idUser], [id_Company], [imagePath]) VALUES (N'e0a3eb51-1e9b-4448-a031-c47913945134', NULL, N'/images/img/photo1')
INSERT [dbo].[User] ([idUser], [id_Company], [imagePath]) VALUES (N'e38ac2bd-78a4-445f-9459-51ebce4b914d', NULL, N'/images/img/photo1')
INSERT [dbo].[User] ([idUser], [id_Company], [imagePath]) VALUES (N'eaa28278-e322-4bff-9b92-833de556d538', NULL, N'/images/img/photo1')
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetRoleClaims_RoleId]    Script Date: 23/08/2019 18:22:17 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetRoleClaims_RoleId] ON [dbo].[AspNetRoleClaims]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [RoleNameIndex]    Script Date: 23/08/2019 18:22:17 ******/
CREATE UNIQUE NONCLUSTERED INDEX [RoleNameIndex] ON [dbo].[AspNetRoles]
(
	[NormalizedName] ASC
)
WHERE ([NormalizedName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserClaims_UserId]    Script Date: 23/08/2019 18:22:17 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserClaims_UserId] ON [dbo].[AspNetUserClaims]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserLogins_UserId]    Script Date: 23/08/2019 18:22:17 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserLogins_UserId] ON [dbo].[AspNetUserLogins]
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [IX_AspNetUserRoles_RoleId]    Script Date: 23/08/2019 18:22:17 ******/
CREATE NONCLUSTERED INDEX [IX_AspNetUserRoles_RoleId] ON [dbo].[AspNetUserRoles]
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [EmailIndex]    Script Date: 23/08/2019 18:22:17 ******/
CREATE NONCLUSTERED INDEX [EmailIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedEmail] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON
GO
/****** Object:  Index [UserNameIndex]    Script Date: 23/08/2019 18:22:17 ******/
CREATE UNIQUE NONCLUSTERED INDEX [UserNameIndex] ON [dbo].[AspNetUsers]
(
	[NormalizedUserName] ASC
)
WHERE ([NormalizedUserName] IS NOT NULL)
WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, DROP_EXISTING = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[AspNetRoleClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetRoleClaims] CHECK CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserClaims]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserClaims] CHECK CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserLogins]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserLogins] CHECK CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[AspNetRoles] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId]
GO
ALTER TABLE [dbo].[AspNetUserRoles]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserRoles] CHECK CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[AspNetUserTokens]  WITH CHECK ADD  CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[AspNetUsers] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[AspNetUserTokens] CHECK CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId]
GO
ALTER TABLE [dbo].[Client]  WITH CHECK ADD  CONSTRAINT [FK_Client_Company] FOREIGN KEY([idCompany])
REFERENCES [dbo].[Company] ([idCmp])
GO
ALTER TABLE [dbo].[Client] CHECK CONSTRAINT [FK_Client_Company]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_Company] FOREIGN KEY([idCompany])
REFERENCES [dbo].[Company] ([idCmp])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_Company]
GO
ALTER TABLE [dbo].[Events]  WITH CHECK ADD  CONSTRAINT [FK_Events_EventType] FOREIGN KEY([idEventType])
REFERENCES [dbo].[EventType] ([idTypeEvent])
GO
ALTER TABLE [dbo].[Events] CHECK CONSTRAINT [FK_Events_EventType]
GO
ALTER TABLE [dbo].[Objectives]  WITH CHECK ADD  CONSTRAINT [FK_Objectives_User] FOREIGN KEY([idMng])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[Objectives] CHECK CONSTRAINT [FK_Objectives_User]
GO
ALTER TABLE [dbo].[Objectives]  WITH CHECK ADD  CONSTRAINT [FK_Objectives_User1] FOREIGN KEY([idColb])
REFERENCES [dbo].[User] ([idUser])
GO
ALTER TABLE [dbo].[Objectives] CHECK CONSTRAINT [FK_Objectives_User1]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Client] FOREIGN KEY([idClient])
REFERENCES [dbo].[Client] ([idC])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Client]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_Company] FOREIGN KEY([idCompany])
REFERENCES [dbo].[Company] ([idCmp])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Company]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_AspNetUsers] FOREIGN KEY([idUser])
REFERENCES [dbo].[AspNetUsers] ([Id])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_AspNetUsers]
GO
ALTER TABLE [dbo].[User]  WITH CHECK ADD  CONSTRAINT [FK_User_Company] FOREIGN KEY([id_Company])
REFERENCES [dbo].[Company] ([idCmp])
GO
ALTER TABLE [dbo].[User] CHECK CONSTRAINT [FK_User_Company]
GO
USE [master]
GO
ALTER DATABASE [GrowXDB] SET  READ_WRITE 
GO
