USE [master]
GO
/****** Object:  Database [scmv_hrm]    Script Date: 12/28/2016 9:18:59 AM ******/
CREATE DATABASE [scmv_hrm]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'scmv_hrm', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\scmv_hrm.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'scmv_hrm_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.MSSQLSERVER\MSSQL\DATA\scmv_hrm_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [scmv_hrm] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [scmv_hrm].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [scmv_hrm] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [scmv_hrm] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [scmv_hrm] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [scmv_hrm] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [scmv_hrm] SET ARITHABORT OFF 
GO
ALTER DATABASE [scmv_hrm] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [scmv_hrm] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [scmv_hrm] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [scmv_hrm] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [scmv_hrm] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [scmv_hrm] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [scmv_hrm] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [scmv_hrm] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [scmv_hrm] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [scmv_hrm] SET  DISABLE_BROKER 
GO
ALTER DATABASE [scmv_hrm] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [scmv_hrm] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [scmv_hrm] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [scmv_hrm] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [scmv_hrm] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [scmv_hrm] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [scmv_hrm] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [scmv_hrm] SET RECOVERY FULL 
GO
ALTER DATABASE [scmv_hrm] SET  MULTI_USER 
GO
ALTER DATABASE [scmv_hrm] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [scmv_hrm] SET DB_CHAINING OFF 
GO
ALTER DATABASE [scmv_hrm] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [scmv_hrm] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [scmv_hrm] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'scmv_hrm', N'ON'
GO
ALTER DATABASE [scmv_hrm] SET QUERY_STORE = OFF
GO
USE [scmv_hrm]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [scmv_hrm]
GO
/****** Object:  Schema [Ref]    Script Date: 12/28/2016 9:18:59 AM ******/
CREATE SCHEMA [Ref]
GO
/****** Object:  Schema [Security]    Script Date: 12/28/2016 9:18:59 AM ******/
CREATE SCHEMA [Security]
GO
/****** Object:  UserDefinedFunction [dbo].[FnGetFullName]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE FUNCTION [dbo].[FnGetFullName] (
	@Id INT
	,@Option INT
	-- 1 : Region
	-- 2 : Business Unit
	-- 3 : Country
	-- 4 : Project
	)
RETURNS NVARCHAR(500)
AS
BEGIN
	DECLARE @FullName NVARCHAR(500)

	IF @Option = 1
	BEGIN
		SELECT @FullName =  '<b>'+r.RegionName + '</b>'
		FROM dbo.Region r
		WHERE RegionId = @Id
	END

	IF @Option = 2
	BEGIN
		SELECT @FullName = r.RegionName + ' > <b> ' + bu.BusinessUnitName + '</b>'
		FROM dbo.BusinessUnit bu
		JOIN dbo.Region r ON bu.RegionId = r.RegionId
		WHERE bu.BusinessUnitId = @Id
	END

	IF @Option = 3
	BEGIN
		SELECT @FullName = r.RegionName + ' > ' + bu.BusinessUnitName + ' > <b>' + c.CountryName + '</b>'
		FROM dbo.Country c
		JOIN dbo.BusinessUnit bu ON c.BusinessUnitId = bu.BusinessUnitId
		JOIN dbo.Region r ON bu.RegionId = r.RegionId
		WHERE c.CountryId = @Id
	END

	IF @Option = 4
	BEGIN
		SELECT @FullName = r.RegionName + ' > ' + bu.BusinessUnitName + ' > ' + c.CountryName + ' > <b>' + p.ShortName + '</b>'
		FROM project p
		JOIN dbo.Country c ON p.CountryId = c.CountryId
		JOIN dbo.BusinessUnit bu ON c.BusinessUnitId = bu.BusinessUnitId
		JOIN dbo.Region r ON bu.RegionId = r.RegionId
		WHERE p.Id = @Id
	END

	RETURN @FullName
END




GO
/****** Object:  UserDefinedFunction [dbo].[FnSplit]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[FnSplit]
(
@List nvarchar(2000),
@SplitOn nvarchar(5)
)  
RETURNS @RtnValue table 
(
Id int identity(1,1),
Value nvarchar(2000)
) 
AS  
BEGIN

While (Charindex(@SplitOn,@List)>0)
Begin 
Insert Into @RtnValue (value)
Select
Value = ltrim(rtrim(Substring(@List,1,Charindex(@SplitOn,@List)-1))) 
Set @List = Substring(@List,Charindex(@SplitOn,@List)+len(@SplitOn),len(@List))
End 

Insert Into @RtnValue (Value)
Select Value = ltrim(rtrim(@List))
Return
END



GO
/****** Object:  UserDefinedFunction [dbo].[fnSplitString]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[fnSplitString] 
( 
    @string NVARCHAR(MAX), 
    @delimiter CHAR(1) 
) 
RETURNS @output TABLE(splitdata NVARCHAR(MAX) 
) 
BEGIN 
	DECLARE @temp TABLE(splitdata NVARCHAR(MAX))
    DECLARE @start INT, @end INT 
    SELECT @start = 1, @end = CHARINDEX(@delimiter, @string) 
    WHILE @start < LEN(@string) + 1 BEGIN 
        IF @end = 0  
            SET @end = LEN(@string) + 1
       
        INSERT INTO @temp (splitdata)  
        VALUES(SUBSTRING(@string, @start, @end - @start)) 
        SET @start = @end + 1 
        SET @end = CHARINDEX(@delimiter, @string, @start)
    END 
	INSERT INTO @output SELECT DISTINCT splitdata FROM @temp;
    RETURN 
END


GO
/****** Object:  UserDefinedFunction [dbo].[getIpAddress]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[getIpAddress] ()
RETURNS VARCHAR(48)
AS
BEGIN
	RETURN (
			SELECT client_net_address
			FROM sys.dm_exec_connections
			WHERE Session_id = @@SPID
			);
END



GO
/****** Object:  UserDefinedFunction [dbo].[GetLocationByLevel]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[GetLocationByLevel](
	@LocationId Int,
	@Level tinyint,
	@GetId tinyint = 0
)
RETURNS nvarchar(400)
AS
BEGIN

DECLARE @RESULT_STRING NVARCHAR(max);

DECLARE @Location TABLE
(
	Id INT,
	Name NVARCHAR(400),
	Level TINYINT,
	Description NVARCHAR(2000),
	Code NCHAR(80)
)

;WITH CteLocation AS
		(
			SELECT
				 loc.Id,
				 loc.LocationParent
			FROM dbo.Location loc WITH (NOLOCK)
			WHERE
				loc.Id = @LocationId
			UNION ALL
			SELECT
				 lc2.Id,
				 lc2.LocationParent
			FROM dbo.Location lc2 WITH (NOLOCK)
			INNER JOIN [CteLocation] loc ON loc.LocationParent = lc2.Id
		),
	CteLocationHierarchy AS
		(
			SELECT DISTINCT	
				loc.Id,
				loc.Name,
				loc.Level,
				loc.Description,
				Code				
			FROM dbo.Location loc WITH (NOLOCK)			
			INNER JOIN [CteLocation] lc3 ON loc.Id = lc3.Id			
		)
	INSERT INTO @Location
	SELECT 
		id,
		Name,
		Level,
		Description,
		Code
	FROM CteLocationHierarchy

	SELECT
		@RESULT_STRING= Name		
	FROM
		@Location
	WHERE [Level] = @Level

	IF(@GetId = 1)
	BEGIN
		SELECT
			@RESULT_STRING= Id		
		FROM
			@Location
		WHERE [Level] = @Level
	END

	IF(@GetId = 2)
	BEGIN
		SELECT
			@RESULT_STRING= Code		
		FROM
			@Location
		WHERE [Level] = @Level
	END

	RETURN @RESULT_STRING;
END




GO
/****** Object:  UserDefinedFunction [dbo].[SplitAndRemoveDuplicates]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[SplitAndRemoveDuplicates] (@sep VARCHAR(32), @s VARCHAR(MAX))

RETURNS VARCHAR(MAX)  
AS
BEGIN

   DECLARE @t TABLE (val VARCHAR(MAX)) 

   DECLARE @xml XML
   SET @xml = N'<root><r>' + REPLACE(@s, @sep, '</r><r>') + '</r></root>'

   INSERT INTO @t(val) SELECT r.value('.','VARCHAR(MAX)') as Item FROM @xml.nodes('//root/r') AS RECORDS(r)

   ;WITH cte
    AS (SELECT ROW_NUMBER() OVER (PARTITION BY val ORDER BY val desc) RN
    FROM  @t)
    DELETE FROM cte
    WHERE  RN > 1

    RETURN (SELECT val + ',' from @t WHERE val <> '' FOR XML PATH ('') )
END



GO
/****** Object:  Table [dbo].[Function]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Function](
	[FunctionId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_Function] PRIMARY KEY CLUSTERED 
(
	[FunctionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permissions]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permissions](
	[PermissionId] [int] IDENTITY(1,1) NOT NULL,
	[ProjectRoleId] [int] NULL,
	[FunctionId] [int] NULL,
 CONSTRAINT [PK_Permissions] PRIMARY KEY CLUSTERED 
(
	[PermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserProfile]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserProfile](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[UserName] [nvarchar](100) NOT NULL,
	[IsGroupAdmin] [bit] NULL,
	[LastLogIn] [datetime] NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectUser]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[ProjectId] [int] NOT NULL,
	[UserId] [int] NOT NULL,
 CONSTRAINT [PK_ProjectUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ProjectPermissions]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectPermissions](
	[ProjectPermissionId] [int] IDENTITY(1,1) NOT NULL,
	[PermissionId] [int] NULL,
	[ProjectUserId] [int] NULL,
 CONSTRAINT [PK_ProjectPermissions] PRIMARY KEY CLUSTERED 
(
	[ProjectPermissionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vwSecutiryMatrix]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO





CREATE VIEW [dbo].[vwSecutiryMatrix]
AS
SELECT f.NAME AS FunctionName
	,f.FunctionId
	,UserName
	,pu.ProjectId
FROM dbo.[Function] f
JOIN dbo.Permissions ON f.FunctionId = dbo.Permissions.FunctionId
JOIN dbo.ProjectPermissions pp ON dbo.Permissions.PermissionId = pp.PermissionId
JOIN dbo.ProjectUser pu ON pu.Id = pp.ProjectUserId
JOIN dbo.UserProfile up ON pu.UserId = up.UserId
GROUP BY f.NAME
	,UserName
	,ProjectId
	,f.FunctionId






GO
/****** Object:  Table [dbo].[ProjectRole]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ProjectRole](
	[ProjectRoleId] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
 CONSTRAINT [PK_ProjectRole] PRIMARY KEY CLUSTERED 
(
	[ProjectRoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vwProjectUserRoles]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE VIEW [dbo].[vwProjectUserRoles]
AS
SELECT DISTINCT CAST(row_number() OVER (
		ORDER BY ProjectId DESC
		) AS INT ) AS viewId
	,u.UserId
	,u.UserName
	,pu.ProjectId
	,STUFF((
			SELECT ', ' + t.NAME
			FROM (
				SELECT DISTINCT prl.NAME
				FROM ProjectRole prl
				JOIN Permissions pm ON pm.ProjectRoleId = prl.ProjectRoleId
				JOIN ProjectPermissions pp ON pp.PermissionId = pm.PermissionId
				WHERE pp.ProjectUserId = pu.Id
				) AS t
			FOR XML PATH('')
				,TYPE
			).value('(./text())[1]', 'VARCHAR(MAX)'), 1, 2, '') AS ProjectRoles
FROM UserProfile u
JOIN dbo.ProjectUser pu ON u.UserId = pu.UserId





GO
/****** Object:  Table [dbo].[Project]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Project](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](100) NULL,
	[ShortName] [nvarchar](50) NULL,
	[FullCode] [nvarchar](20) NULL,
	[CountryId] [int] NOT NULL,
	[TimeZone] [int] NULL,
 CONSTRAINT [PK_Project] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[GroupGeneralUser]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[GroupGeneralUser](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[RegionId] [int] NULL,
	[BusinessUnitId] [int] NULL,
	[CountryId] [int] NULL,
	[ProjectId] [int] NULL,
	[GroupTree] [nvarchar](500) NULL,
	[UserProfileId] [int] NOT NULL,
 CONSTRAINT [PK_GroupGeneralUser] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  View [dbo].[vwGroupUserRoles]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE VIEW [dbo].[vwGroupUserRoles]
AS
WITH CteGroupRole
AS (
	SELECT UserId
		,UserName
		,CASE IsGroupAdmin
			WHEN 1
				THEN 'Group Admin ( <b> Cape Group </b> )'
			END AS ProjectRole
	FROM dbo.UserProfile
	WHERE IsGroupAdmin = 1
	
	UNION ALL
	
	SELECT UserId
		,UserName
		,'Group General User (' + CASE 
			WHEN gg.ProjectId IS NOT NULL
				THEN dbo.FnGetFullName(gg.ProjectId, 4)
			WHEN (gg.CountryId IS NOT NULL)
				AND (gg.ProjectId IS NULL)
				THEN dbo.FnGetFullName(gg.CountryId, 3)
			WHEN (gg.BusinessUnitId IS NOT NULL)
				AND (gg.CountryId IS NULL)
				THEN dbo.FnGetFullName(gg.BusinessUnitId, 2)
			WHEN (gg.RegionId IS NOT NULL)
				AND (gg.BusinessUnitId IS NULL)
				THEN dbo.FnGetFullName(gg.RegionId, 1)
			ELSE '<b>Cape Group</b>'
			END + ')' AS ProjectRole
	FROM dbo.UserProfile up
	INNER JOIN dbo.GroupGeneralUser gg ON up.UserId = gg.UserProfileId
	
	UNION ALL
	
	SELECT DISTINCT pu.UserId
		,UserName
		,pr.NAME + ' ( ' + dbo.FnGetFullName(ProjectId, 4) + ' )' AS ProjectRole
	FROM dbo.UserProfile up
	JOIN dbo.ProjectUser pu ON up.UserId = pu.UserId
	JOIN dbo.Project p ON pu.ProjectId = p.Id
	JOIN dbo.ProjectPermissions pp ON pu.Id = pp.ProjectUserId
	JOIN dbo.Permissions pe ON pp.PermissionId = pe.PermissionId
	JOIN dbo.ProjectRole pr ON pe.ProjectRoleId = pr.ProjectRoleId
	WHERE pe.ProjectRoleId IN (1)
	)
SELECT DISTINCT UserId
	,Username
	,STUFF((
			SELECT '</br> ' + t.ProjectRole
			FROM (
				SELECT c1.ProjectRole
				FROM CteGroupRole c1
				WHERE c1.UserId = gr1.UserId
				) AS t
			FOR XML PATH('')
				,TYPE
			).value('(./text())[1]', 'VARCHAR(MAX)'), 1, 5, '') AS ProjectRoles
FROM CteGroupRole gr1





GO
/****** Object:  Table [dbo].[BusinessUnit]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BusinessUnit](
	[BusinessUnitId] [int] IDENTITY(1,1) NOT NULL,
	[BusinessUnitName] [nvarchar](100) NOT NULL,
	[RegionId] [int] NOT NULL,
	[SortOrder] [int] NULL,
 CONSTRAINT [PK_BusinessUnit] PRIMARY KEY CLUSTERED 
(
	[BusinessUnitId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Country]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Country](
	[CountryId] [int] IDENTITY(1,1) NOT NULL,
	[CountryName] [nvarchar](100) NOT NULL,
	[BusinessUnitId] [int] NOT NULL,
	[SortOrder] [int] NULL,
 CONSTRAINT [PK_Country] PRIMARY KEY CLUSTERED 
(
	[CountryId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_access_auth_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_access_auth_b](
	[access_auth_cd] [uniqueidentifier] NOT NULL,
	[access_auth_name] [nvarchar](128) NULL,
	[notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_access_auth_b] PRIMARY KEY CLUSTERED 
(
	[access_auth_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_access_auth_department]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_access_auth_department](
	[access_auth_cd] [uniqueidentifier] NOT NULL,
	[company_cd] [uniqueidentifier] NULL,
	[department_cd] [uniqueidentifier] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_access_auth_department] PRIMARY KEY CLUSTERED 
(
	[access_auth_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_access_auth_detail]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_access_auth_detail](
	[access_auth_cd] [uniqueidentifier] NOT NULL,
	[feature_cd] [uniqueidentifier] NULL,
	[access_scope_div] [nvarchar](20) NOT NULL,
	[auth_class_div] [nvarchar](20) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_access_auth_detail] PRIMARY KEY CLUSTERED 
(
	[access_auth_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_access_auth_post]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_access_auth_post](
	[access_auth_cd] [uniqueidentifier] NOT NULL,
	[company_cd] [uniqueidentifier] NULL,
	[post_cd] [uniqueidentifier] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_access_auth_post] PRIMARY KEY CLUSTERED 
(
	[access_auth_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_access_auth_role]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_access_auth_role](
	[access_auth_cd] [uniqueidentifier] NOT NULL,
	[role_id] [uniqueidentifier] NOT NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_access_auth_role] PRIMARY KEY CLUSTERED 
(
	[access_auth_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_appointment]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_appointment](
	[appointment_cd] [uniqueidentifier] NOT NULL,
	[appointment_name] [nvarchar](128) NULL,
	[query_cd] [uniqueidentifier] NULL,
	[format_file_logical_name] [nvarchar](128) NULL,
	[format_file_physical_name] [nvarchar](128) NULL,
	[format_file_sheet_name] [nvarchar](128) NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_appointment] PRIMARY KEY CLUSTERED 
(
	[appointment_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_appointment_condition]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_appointment_condition](
	[appointment_cd] [uniqueidentifier] NOT NULL,
	[appointment_condition_seq] [nvarchar](20) NOT NULL,
	[column_id] [uniqueidentifier] NULL,
	[field_name] [nvarchar](128) NULL,
	[field_class_div] [nvarchar](20) NULL,
	[condition_class_div] [nvarchar](20) NULL,
	[condition_data_type_div] [nvarchar](20) NULL,
	[indispensable_input_flg] [bit] NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_appointment_condition] PRIMARY KEY CLUSTERED 
(
	[appointment_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_appointment_detail]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_appointment_detail](
	[appointment_cd] [uniqueidentifier] NOT NULL,
	[appointment_seq] [nvarchar](20) NOT NULL,
	[field_name] [nvarchar](128) NULL,
	[output_class_div] [nvarchar](20) NULL,
	[output_value] [nvarchar](50) NULL,
	[indicate_flg] [bit] NULL,
	[indicate_data_type_div] [nvarchar](20) NULL,
	[output_flg] [bit] NULL,
	[cell_position] [nvarchar](10) NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_appointment_detail] PRIMARY KEY CLUSTERED 
(
	[appointment_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_appointment_detail_param]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_appointment_detail_param](
	[appointment_cd] [uniqueidentifier] NOT NULL,
	[appointment_seq] [nvarchar](20) NOT NULL,
	[param_detail_no] [numeric](6, 0) NOT NULL,
	[param_class_div] [nvarchar](20) NULL,
	[param_value] [nvarchar](50) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_appointment_detail_param] PRIMARY KEY CLUSTERED 
(
	[appointment_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_auth]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_auth](
	[feature_cd] [uniqueidentifier] NOT NULL,
	[access_scope_div] [nvarchar](20) NOT NULL,
	[auth_class_div] [nvarchar](20) NOT NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_auth] PRIMARY KEY CLUSTERED 
(
	[feature_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_bank]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_bank](
	[bank_cd] [uniqueidentifier] NOT NULL,
	[bank_name] [nvarchar](128) NULL,
	[bank_name_kana] [nvarchar](128) NULL,
	[branch_office_name] [nvarchar](128) NULL,
	[branch_office_name_kana] [nvarchar](128) NULL,
	[delete_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_bank] PRIMARY KEY CLUSTERED 
(
	[bank_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_cd]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_cd](
	[cd_group_cd] [uniqueidentifier] NOT NULL,
	[cd] [nvarchar](20) NOT NULL,
	[cd_name] [nvarchar](128) NULL,
	[edit_possible_div] [nvarchar](20) NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[delete_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_cd] PRIMARY KEY CLUSTERED 
(
	[cd_group_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_cd_group]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_cd_group](
	[cd_group_cd] [uniqueidentifier] NOT NULL,
	[cd_group_name] [nvarchar](128) NULL,
	[edit_possible_div] [nvarchar](20) NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[delete_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_cd_group] PRIMARY KEY CLUSTERED 
(
	[cd_group_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_company_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_company_b](
	[company_cd] [uniqueidentifier] NOT NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_company_b] PRIMARY KEY CLUSTERED 
(
	[company_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_company_each_cd_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_company_each_cd_b](
	[cd_group_cd] [uniqueidentifier] NOT NULL,
	[company_cd] [uniqueidentifier] NOT NULL,
	[cd] [uniqueidentifier] NOT NULL,
	[edit_possible_div] [nvarchar](20) NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[delete_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_company_each_cd_b] PRIMARY KEY CLUSTERED 
(
	[cd_group_cd] ASC,
	[company_cd] ASC,
	[cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_company_each_cd_group]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_company_each_cd_group](
	[cd_group_cd] [uniqueidentifier] NOT NULL,
	[cd_group_name] [nvarchar](128) NULL,
	[edit_possible_div] [nvarchar](20) NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[delete_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_company_each_cd_group] PRIMARY KEY CLUSTERED 
(
	[cd_group_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_company_each_cd_t]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_company_each_cd_t](
	[cd_group_cd] [uniqueidentifier] NOT NULL,
	[company_cd] [uniqueidentifier] NOT NULL,
	[cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[cd_name] [nvarchar](128) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_company_each_cd_t] PRIMARY KEY CLUSTERED 
(
	[cd_group_cd] ASC,
	[company_cd] ASC,
	[cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_company_post_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_company_post_b](
	[company_cd] [uniqueidentifier] NOT NULL,
	[post_cd] [uniqueidentifier] NOT NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_company_post_b] PRIMARY KEY CLUSTERED 
(
	[company_cd] ASC,
	[post_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_company_post_t]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_company_post_t](
	[company_cd] [uniqueidentifier] NOT NULL,
	[post_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NOT NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[post_name] [nvarchar](128) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_company_post_t] PRIMARY KEY CLUSTERED 
(
	[company_cd] ASC,
	[post_cd] ASC,
	[term_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_company_version_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_company_version_b](
	[company_cd] [uniqueidentifier] NOT NULL,
	[version_cd] [uniqueidentifier] NOT NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_company_version_b] PRIMARY KEY CLUSTERED 
(
	[company_cd] ASC,
	[version_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_country]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_country](
	[country_cd] [uniqueidentifier] NOT NULL,
	[country_name] [nvarchar](64) NULL,
	[sort_key] [bigint] NULL,
	[delete_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_country] PRIMARY KEY CLUSTERED 
(
	[country_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_department_attach_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_department_attach_b](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[company_cd] [uniqueidentifier] NOT NULL,
	[department_cd] [uniqueidentifier] NOT NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_department_attach_b] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC,
	[company_cd] ASC,
	[department_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_department_attach_t]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_department_attach_t](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[company_cd] [uniqueidentifier] NOT NULL,
	[department_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NOT NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[post_cd] [uniqueidentifier] NULL,
	[post_executive_flg] [bit] NULL,
	[main_attach_flg] [bit] NULL,
	[attach_change_flg] [bit] NULL,
	[post_change_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_department_attach_t] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC,
	[company_cd] ASC,
	[department_cd] ASC,
	[term_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_department_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_department_b](
	[company_cd] [uniqueidentifier] NOT NULL,
	[department_cd] [uniqueidentifier] NOT NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_department_b] PRIMARY KEY CLUSTERED 
(
	[company_cd] ASC,
	[department_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_department_inclusion_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_department_inclusion_b](
	[company_cd] [uniqueidentifier] NOT NULL,
	[version_cd] [uniqueidentifier] NOT NULL,
	[parent_department_cd] [uniqueidentifier] NOT NULL,
	[department_cd] [uniqueidentifier] NOT NULL,
	[depth] [numeric](15, 0) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_department_inclusion_b] PRIMARY KEY CLUSTERED 
(
	[company_cd] ASC,
	[version_cd] ASC,
	[parent_department_cd] ASC,
	[department_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_department_t]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_department_t](
	[company_cd] [uniqueidentifier] NULL,
	[department_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[department_name] [nvarchar](128) NULL,
	[department_name_kana] [nvarchar](128) NULL,
	[department_name_eng] [nvarchar](128) NULL,
	[tel_no] [nvarchar](64) NULL,
	[fax_no] [nvarchar](64) NULL,
	[extension_tel_no] [nvarchar](64) NULL,
	[extension_fax_no] [nvarchar](64) NULL,
	[address_country_cd1] [nvarchar](20) NULL,
	[address_postcode1] [nvarchar](20) NULL,
	[address_prefecture_name1] [nvarchar](64) NULL,
	[address_city_name1] [nvarchar](64) NULL,
	[address_town_name1] [nvarchar](255) NULL,
	[address_block_no_name1] [nvarchar](64) NULL,
	[address_prefecture_name_kana1] [nvarchar](64) NULL,
	[address_city_name_kana1] [nvarchar](64) NULL,
	[address_town_name_kana1] [nvarchar](255) NULL,
	[address_block_no_name_kana1] [nvarchar](64) NULL,
	[address_country_cd2] [nvarchar](20) NULL,
	[address_postcode2] [nvarchar](20) NULL,
	[address_prefecture_name2] [nvarchar](64) NULL,
	[address_city_name2] [nvarchar](64) NULL,
	[address_town_name2] [nvarchar](255) NULL,
	[address_block_no_name2] [nvarchar](64) NULL,
	[address_prefecture_name_kana2] [nvarchar](64) NULL,
	[address_city_name_kana2] [nvarchar](64) NULL,
	[address_town_name_kana2] [nvarchar](255) NULL,
	[address_block_no_name_kana2] [nvarchar](64) NULL,
	[mail_address1] [nvarchar](128) NULL,
	[mail_address2] [nvarchar](128) NULL,
	[url1] [nvarchar](128) NULL,
	[url2] [nvarchar](128) NULL,
	[social_insurance_office_no] [nvarchar](20) NULL,
	[labor_insurance_office_no] [nvarchar](20) NULL,
	[charge_sales_department_name] [nvarchar](128) NULL,
	[charge_sales_user_name] [nvarchar](128) NULL,
	[charge_sales_tel_no] [nvarchar](64) NULL,
	[charge_sales_fax_no] [nvarchar](64) NULL,
	[charge_sales_mail_address] [nvarchar](128) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_department_t] PRIMARY KEY CLUSTERED 
(
	[department_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_employee_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_employee_b](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_employee_b] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_employee_t]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_employee_t](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[employee_name] [nvarchar](128) NULL,
	[employee_name_kana] [nvarchar](128) NULL,
	[employee_name_eng] [nvarchar](128) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_employee_t] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_id_management]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_id_management](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[id_class_div] [uniqueidentifier] NOT NULL,
	[id] [uniqueidentifier] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_id_management] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_list]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_list](
	[list_cd] [uniqueidentifier] NOT NULL,
	[list_name] [nvarchar](128) NULL,
	[query_cd] [uniqueidentifier] NULL,
	[format_file_logical_name] [nvarchar](128) NULL,
	[format_file_physical_name] [nvarchar](128) NULL,
	[format_file_sheet_name] [nvarchar](128) NULL,
	[data_alignment_start_row] [numeric](2, 0) NULL,
	[data_alignment_end_row] [numeric](2, 0) NULL,
	[data_alignment_row_count] [numeric](12, 0) NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_list] PRIMARY KEY CLUSTERED 
(
	[list_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_list_condition]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_list_condition](
	[list_cd] [uniqueidentifier] NOT NULL,
	[list_condition_seq] [nvarchar](20) NOT NULL,
	[column_id] [uniqueidentifier] NULL,
	[field_name] [nvarchar](128) NULL,
	[field_class_div] [nvarchar](20) NULL,
	[condition_class_div] [nvarchar](20) NULL,
	[condition_data_type_div] [nvarchar](20) NULL,
	[indispensable_input_flg] [bit] NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_list_condition] PRIMARY KEY CLUSTERED 
(
	[list_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_list_detail]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_list_detail](
	[list_cd] [uniqueidentifier] NOT NULL,
	[list_detail_no] [numeric](6, 0) NOT NULL,
	[output_class_div] [nvarchar](20) NULL,
	[output_value] [nvarchar](50) NULL,
	[indicate_data_type_div] [nvarchar](20) NULL,
	[cell_position] [nvarchar](10) NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_list_detail] PRIMARY KEY CLUSTERED 
(
	[list_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_list_detail_param]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_list_detail_param](
	[list_cd] [uniqueidentifier] NOT NULL,
	[list_detail_no] [numeric](6, 0) NOT NULL,
	[param_detail_no] [numeric](6, 0) NOT NULL,
	[param_class_div] [nvarchar](20) NULL,
	[param_value] [nvarchar](50) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_list_detail_param] PRIMARY KEY CLUSTERED 
(
	[list_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_list_header]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_list_header](
	[list_cd] [uniqueidentifier] NOT NULL,
	[list_header_detail_no] [numeric](6, 0) NOT NULL,
	[header_output_class_div] [nvarchar](20) NULL,
	[output_value] [nvarchar](50) NULL,
	[indicate_data_type_div] [nvarchar](20) NULL,
	[cell_position] [nvarchar](10) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_list_header] PRIMARY KEY CLUSTERED 
(
	[list_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_postcode]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_postcode](
	[country_cd] [uniqueidentifier] NOT NULL,
	[postcode_seq] [nvarchar](20) NOT NULL,
	[postcode] [uniqueidentifier] NOT NULL,
	[prefecture_name] [nvarchar](64) NULL,
	[city_name] [nvarchar](64) NULL,
	[town_name] [nvarchar](255) NULL,
	[prefecture_name_kana] [nvarchar](64) NULL,
	[city_name_kana] [nvarchar](64) NULL,
	[town_name_kana] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_postcode] PRIMARY KEY CLUSTERED 
(
	[postcode] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_qualf]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_qualf](
	[qualf_group_cd] [uniqueidentifier] NOT NULL,
	[qualf_cd] [uniqueidentifier] NOT NULL,
	[qualf_name] [nvarchar](128) NULL,
	[delete_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_qualf] PRIMARY KEY CLUSTERED 
(
	[qualf_group_cd] ASC,
	[qualf_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_qualf_group]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_qualf_group](
	[qualf_group_cd] [uniqueidentifier] NOT NULL,
	[qualf_group_name] [nvarchar](128) NULL,
	[delete_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_qualf_group] PRIMARY KEY CLUSTERED 
(
	[qualf_group_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_query]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_query](
	[query_cd] [uniqueidentifier] NOT NULL,
	[query_name] [nvarchar](128) NULL,
	[sql_statement] [nvarchar](4000) NULL,
	[notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_query] PRIMARY KEY CLUSTERED 
(
	[query_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_query_column]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_query_column](
	[query_cd] [uniqueidentifier] NOT NULL,
	[query_column_detail_no] [numeric](6, 0) NOT NULL,
	[column_id] [uniqueidentifier] NULL,
	[column_name] [nvarchar](128) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_query_column] PRIMARY KEY CLUSTERED 
(
	[query_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_query_condition]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_query_condition](
	[query_cd] [uniqueidentifier] NOT NULL,
	[query_condition_detail_no] [numeric](6, 0) NOT NULL,
	[field_name] [nvarchar](128) NULL,
	[field_class_div] [nvarchar](20) NULL,
	[condition_data_type_div] [nvarchar](20) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_query_condition] PRIMARY KEY CLUSTERED 
(
	[query_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_role_b]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_role_b](
	[role_id] [uniqueidentifier] NOT NULL,
	[role_name] [nvarchar](128) NULL,
	[notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_role_b] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_role_employee]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_role_employee](
	[role_id] [uniqueidentifier] NOT NULL,
	[employee_cd] [uniqueidentifier] NOT NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_role_employee] PRIMARY KEY CLUSTERED 
(
	[role_id] ASC,
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_sys_parameter]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_sys_parameter](
	[sys_parameter_cd] [uniqueidentifier] NOT NULL,
	[sys_parameter_name] [nvarchar](128) NULL,
	[sys_parameter_value] [nvarchar](255) NULL,
	[notes] [nvarchar](255) NULL,
	[sort_key] [bigint] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_sys_parameter] PRIMARY KEY CLUSTERED 
(
	[sys_parameter_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_m_sys_params]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_m_sys_params](
	[sys_parameter_cd] [uniqueidentifier] NOT NULL,
	[sys_parameter_nm] [nvarchar](255) NULL,
	[sys_parameter_value] [nvarchar](255) NULL,
	[sys_parameter_comment] [nvarchar](255) NULL,
	[sort_no] [decimal](4, 0) NULL,
	[last_update_user_cd] [uniqueidentifier] NULL,
	[last_update_ymdhms] [datetime] NULL,
 CONSTRAINT [PK_hrm_m_sys_params] PRIMARY KEY CLUSTERED 
(
	[sys_parameter_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_admin_leave]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_admin_leave](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NOT NULL,
	[admin_leave_start_date] [datetime] NULL,
	[admin_leave_end_date] [datetime] NULL,
	[service_years_deduction_flg] [bit] NULL,
	[admin_leave_reason_notes] [nvarchar](255) NULL,
	[admin_leave_special_affair] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_admin_leave] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC,
	[term_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_award_punition]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_award_punition](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[award_punition_seq] [nvarchar](20) NOT NULL,
	[award_punition_class_div] [nvarchar](20) NULL,
	[award_punition_name] [nvarchar](128) NULL,
	[award_punition_start_date] [datetime] NULL,
	[award_punition_end_date] [datetime] NULL,
	[award_punition_reason_notes] [nvarchar](255) NULL,
	[award_punition_detail_notes] [nvarchar](255) NULL,
	[award_punition_special_affair] [nvarchar](255) NULL,
	[notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_award_punition] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_branch_relocation]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_branch_relocation](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NOT NULL,
	[branch_start_date] [datetime] NULL,
	[branch_end_date] [datetime] NULL,
	[company_cd] [uniqueidentifier] NULL,
	[branch_cd] [uniqueidentifier] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_branch_relocation] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC,
	[term_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_commute]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_commute](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NOT NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[payment_class_div] [nvarchar](20) NULL,
	[payment_measure_div] [nvarchar](20) NULL,
	[payment_date] [datetime] NULL,
	[tax_free_sum_amnt] [numeric](12, 0) NULL,
	[tax_sum_amnt] [numeric](12, 0) NULL,
	[refundable_sum_amnt] [numeric](12, 0) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_commute] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC,
	[term_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_commute_detail]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_commute_detail](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NOT NULL,
	[pathway_order] [numeric](2, 0) NOT NULL,
	[commute_mean_div] [nvarchar](20) NULL,
	[route_name] [nvarchar](128) NULL,
	[departure_area_name] [nvarchar](128) NULL,
	[destination_area_name] [nvarchar](128) NULL,
	[distance_count] [numeric](12, 0) NULL,
	[time_minute_count] [numeric](12, 0) NULL,
	[through_name] [nvarchar](128) NULL,
	[fare_term_div] [nvarchar](20) NULL,
	[fare_amnt] [numeric](12, 0) NULL,
	[tax_free_amnt] [numeric](12, 0) NULL,
	[tax_amnt] [numeric](12, 0) NULL,
	[refundable_reason_cause] [nvarchar](128) NULL,
	[refundable_amnt] [numeric](12, 0) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_commute_detail] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC,
	[term_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_contact_address]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_contact_address](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[contact_address_name1] [nvarchar](128) NULL,
	[relationship_surety_div1] [nvarchar](20) NULL,
	[tel_no1] [nvarchar](64) NULL,
	[fax_no1] [nvarchar](64) NULL,
	[country_cd1] [nvarchar](20) NULL,
	[postcode1] [nvarchar](20) NULL,
	[prefecture_name1] [nvarchar](64) NULL,
	[city_name1] [nvarchar](64) NULL,
	[town_name1] [nvarchar](255) NULL,
	[block_no_name1] [nvarchar](64) NULL,
	[prefecture_name_kana1] [nvarchar](64) NULL,
	[city_name_kana1] [nvarchar](64) NULL,
	[town_name_kana1] [nvarchar](255) NULL,
	[block_no_name_kana1] [nvarchar](64) NULL,
	[contact_address_name2] [nvarchar](128) NULL,
	[relationship_surety_div2] [nvarchar](20) NULL,
	[tel_no2] [nvarchar](64) NULL,
	[fax_no2] [nvarchar](64) NULL,
	[country_cd2] [nvarchar](20) NULL,
	[postcode2] [nvarchar](20) NULL,
	[prefecture_name2] [nvarchar](64) NULL,
	[city_name2] [nvarchar](64) NULL,
	[town_name2] [nvarchar](255) NULL,
	[block_no_name2] [nvarchar](64) NULL,
	[prefecture_name_kana2] [nvarchar](64) NULL,
	[city_name_kana2] [nvarchar](64) NULL,
	[town_name_kana2] [nvarchar](255) NULL,
	[block_no_name_kana2] [nvarchar](64) NULL,
	[contact_address_name3] [nvarchar](128) NULL,
	[relationship_surety_div3] [nvarchar](20) NULL,
	[tel_no3] [nvarchar](64) NULL,
	[fax_no3] [nvarchar](64) NULL,
	[country_cd3] [nvarchar](20) NULL,
	[postcode3] [nvarchar](20) NULL,
	[prefecture_name3] [nvarchar](64) NULL,
	[city_name3] [nvarchar](64) NULL,
	[town_name3] [nvarchar](255) NULL,
	[block_no_name3] [nvarchar](64) NULL,
	[prefecture_name_kana3] [nvarchar](64) NULL,
	[city_name_kana3] [nvarchar](64) NULL,
	[town_name_kana3] [nvarchar](255) NULL,
	[block_no_name_kana3] [nvarchar](64) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_contact_address] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_dependent]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_dependent](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[self_general_dp_flg] [bit] NULL,
	[self_special_dp_flg] [bit] NULL,
	[partner_general_dp_flg] [bit] NULL,
	[partner_special_dp_flg] [bit] NULL,
	[partner_lt_special_dp_flg] [bit] NULL,
	[dependent_general_dp_count] [numeric](12, 0) NULL,
	[dependent_special_dp_count] [numeric](12, 0) NULL,
	[dependent_lt_special_dp_count] [numeric](12, 0) NULL,
	[widow_flg] [bit] NULL,
	[special_widow_flg] [bit] NULL,
	[widower_flg] [bit] NULL,
	[working_student_flg] [bit] NULL,
	[dp_content_notes] [nvarchar](255) NULL,
	[relocation_date] [datetime] NULL,
	[relocation_cause] [nvarchar](128) NULL,
	[inhabitant_tax_payment_name] [nvarchar](128) NULL,
	[tax_table_div] [nvarchar](20) NULL,
	[self_annual_income_amnt] [numeric](12, 0) NULL,
	[partner_special_deduction_amnt] [numeric](12, 0) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_dependent] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_dependent_detail]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_dependent_detail](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[dependent_seq] [nvarchar](20) NOT NULL,
	[dependent_name] [nvarchar](128) NULL,
	[dependent_name_kana] [nvarchar](128) NULL,
	[relationship_relative_div] [nvarchar](20) NULL,
	[job_name] [nvarchar](128) NULL,
	[birth_date] [datetime] NULL,
	[death_date] [datetime] NULL,
	[lt_aged_parent_flg] [bit] NULL,
	[housing_country_cd] [uniqueidentifier] NULL,
	[housing_postcode] [nvarchar](20) NULL,
	[housing_prefecture_name] [nvarchar](64) NULL,
	[housing_city_name] [nvarchar](64) NULL,
	[housing_town_name] [nvarchar](255) NULL,
	[housing_block_no_name] [nvarchar](64) NULL,
	[annual_income_amnt] [numeric](12, 0) NULL,
	[relocation_date] [datetime] NULL,
	[relocation_cause] [nvarchar](128) NULL,
	[deduction_target_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_dependent_detail] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_disabled]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_disabled](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[disabled_status_flg] [bit] NULL,
	[dp_grade_div] [nvarchar](20) NULL,
	[dp_notebook_no] [nvarchar](20) NULL,
	[dp_notebook_issue_date] [datetime] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_disabled] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_disaster]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_disaster](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[disaster_seq] [nvarchar](20) NOT NULL,
	[disaster_accrual_date] [datetime] NULL,
	[disaster_class_div] [nvarchar](20) NULL,
	[workmans_comp_aplct_status_flg] [bit] NULL,
	[special_affair] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_disaster] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_duties_relocation]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_duties_relocation](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[duties_start_date] [datetime] NULL,
	[duties_end_date] [datetime] NULL,
	[company_cd] [uniqueidentifier] NULL,
	[duties_cd] [uniqueidentifier] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_duties_relocation] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_employee_base]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_employee_base](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[sex_div] [nvarchar](20) NULL,
	[blood_type_div] [nvarchar](20) NULL,
	[hometown_name] [nvarchar](128) NULL,
	[birth_date] [datetime] NULL,
	[maiden_name] [nvarchar](128) NULL,
	[maiden_name_kana] [nvarchar](128) NULL,
	[maiden_name_eng] [nvarchar](128) NULL,
	[marriage_date] [datetime] NULL,
	[householder_flg] [bit] NULL,
	[domi_country_cd] [uniqueidentifier] NULL,
	[domi_postcode] [nvarchar](20) NULL,
	[domi_prefecture_name] [nvarchar](64) NULL,
	[domi_city_name] [nvarchar](64) NULL,
	[domi_town_name] [nvarchar](255) NULL,
	[domi_block_no_name] [nvarchar](64) NULL,
	[relationship_history_div] [nvarchar](20) NULL,
	[single_status_flg] [bit] NULL,
	[image_file_logical_name] [nvarchar](128) NULL,
	[image_file_physical_name] [nvarchar](128) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
	[home_phone] [nvarchar](20) NULL,
	[cell_phone] [nvarchar](20) NULL,
	[email] [nvarchar](128) NULL,
	[address] [nvarchar](512) NULL,
	[idcard_number] [nvarchar](20) NULL,
	[idcard_date] [datetime] NULL,
	[idcard_place] [nvarchar](128) NULL,
	[license_num] [nvarchar](128) NULL,
	[license_type] [nvarchar](64) NULL,
	[arg1] [nvarchar](255) NULL,
	[arg2] [nvarchar](255) NULL,
	[arg3] [nvarchar](255) NULL,
	[arg4] [nvarchar](255) NULL,
	[arg5] [nvarchar](255) NULL,
	[arg6] [nvarchar](255) NULL,
	[arg7] [nvarchar](255) NULL,
	[arg8] [nvarchar](255) NULL,
	[arg9] [nvarchar](255) NULL,
	[arg10] [nvarchar](255) NULL,
	[employee_id] [int] IDENTITY(1,1) NOT NULL,
	[employee_code] [varchar](10) NOT NULL,
 CONSTRAINT [PK_hrm_t_employee_base] PRIMARY KEY CLUSTERED 
(
	[employee_id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_employee_other]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_employee_other](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[passport_no] [nvarchar](20) NULL,
	[passport_time_limit_date] [datetime] NULL,
	[country_cd] [uniqueidentifier] NULL,
	[extension_tel_no] [nvarchar](64) NULL,
	[extension_fax_no] [nvarchar](64) NULL,
	[mobile_tel_no1] [nvarchar](64) NULL,
	[mobile_tel_no2] [nvarchar](64) NULL,
	[mobile_mail_address1] [nvarchar](128) NULL,
	[mobile_mail_address2] [nvarchar](128) NULL,
	[mail_address1] [nvarchar](128) NULL,
	[mail_address2] [nvarchar](128) NULL,
	[url] [nvarchar](128) NULL,
	[hobby1] [nvarchar](64) NULL,
	[hobby2] [nvarchar](64) NULL,
	[special_skill1] [nvarchar](64) NULL,
	[special_skill2] [nvarchar](64) NULL,
	[language_study_name] [nvarchar](128) NULL,
	[holdings_company_stock] [nvarchar](20) NULL,
	[personal_stock] [nvarchar](20) NULL,
	[special_affair1] [nvarchar](255) NULL,
	[special_affair2] [nvarchar](255) NULL,
	[special_affair3] [nvarchar](255) NULL,
	[special_affair4] [nvarchar](255) NULL,
	[joining_company_rated_age] [numeric](2, 0) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_employee_other] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_former_job]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_former_job](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[former_job_seq] [nvarchar](20) NOT NULL,
	[company_name] [nvarchar](128) NULL,
	[joining_company_date] [datetime] NULL,
	[retire_date] [datetime] NULL,
	[industry_name] [nvarchar](128) NULL,
	[post_name] [nvarchar](128) NULL,
	[branch_name] [nvarchar](128) NULL,
	[notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_former_job] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_health_checkup]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_health_checkup](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[health_checkup_seq] [nvarchar](20) NOT NULL,
	[health_checkup_date] [datetime] NULL,
	[health_checkup_place_name] [nvarchar](128) NULL,
	[body_height_hc] [nvarchar](10) NULL,
	[body_weight_hc] [nvarchar](10) NULL,
	[vision_left_hc] [nvarchar](10) NULL,
	[vision_right_hc] [nvarchar](10) NULL,
	[correction_vision_left_hc] [nvarchar](10) NULL,
	[correction_vision_right_hc] [nvarchar](10) NULL,
	[color_blind_hc] [nvarchar](10) NULL,
	[hearing_left_hc] [nvarchar](10) NULL,
	[hearing_right_hc] [nvarchar](10) NULL,
	[blood_pressure_up_hc] [nvarchar](10) NULL,
	[blood_pressure_down_hc] [nvarchar](10) NULL,
	[chest_radiography_hc] [nvarchar](10) NULL,
	[electrocardiogram_hc] [nvarchar](10) NULL,
	[urine_check_sugar_hc] [nvarchar](10) NULL,
	[urine_check_protein_hc] [nvarchar](10) NULL,
	[urine_hidden_blood_hc] [nvarchar](10) NULL,
	[blood_check_blood_pigment_hc] [nvarchar](10) NULL,
	[blood_check_blood_rbc_amnt_hc] [nvarchar](10) NULL,
	[blood_check_got_hc] [nvarchar](10) NULL,
	[blood_check_gpt_hc] [nvarchar](10) NULL,
	[blood_check_gtp_hc] [nvarchar](10) NULL,
	[blood_check_cholesterol_hc] [nvarchar](10) NULL,
	[blood_check_neutral_fat_hc] [nvarchar](10) NULL,
	[health_interview_notes] [nvarchar](255) NULL,
	[notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_health_checkup] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_joining_company]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_joining_company](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[joining_company_date] [datetime] NULL,
	[recruitment_class_div] [nvarchar](20) NULL,
	[recruitment_area_name] [nvarchar](128) NULL,
	[introduction_user_name] [nvarchar](128) NULL,
	[relationship_introduction_div] [nvarchar](20) NULL,
	[contract_start_date] [datetime] NULL,
	[contract_end_date] [datetime] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_joining_company] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_joining_contract]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_joining_contract](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[contract_cd] [uniqueidentifier] NOT NULL,
	[contract_start_date] [datetime] NULL,
	[contract_end_date] [datetime] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_joining_contract] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC,
	[contract_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_oa_grade_relocation]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_oa_grade_relocation](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[oa_grade_start_date] [datetime] NULL,
	[oa_grade_end_date] [datetime] NULL,
	[company_cd] [uniqueidentifier] NULL,
	[oa_grade_cd] [uniqueidentifier] NULL,
	[oa_grade_raise_div] [nvarchar](20) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
	[seniority_cd] [int] NULL,
 CONSTRAINT [PK_hrm_t_oa_grade_relocation] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_oa_qualf_relocation]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_oa_qualf_relocation](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[oa_qualf_start_date] [datetime] NULL,
	[oa_qualf_end_date] [datetime] NULL,
	[company_cd] [uniqueidentifier] NULL,
	[oa_qualf_cd] [uniqueidentifier] NULL,
	[oa_qualf_raise_div] [nvarchar](20) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_oa_qualf_relocation] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_old_school]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_old_school](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[old_school_seq] [nvarchar](20) NOT NULL,
	[school_name] [nvarchar](128) NULL,
	[faculty_name] [nvarchar](128) NULL,
	[subject_name] [nvarchar](128) NULL,
	[laboratory_name] [nvarchar](128) NULL,
	[school_class_div] [nvarchar](20) NULL,
	[entrance_date] [datetime] NULL,
	[graduation_date] [datetime] NULL,
	[graduation_status_div] [nvarchar](20) NULL,
	[course_class_div] [nvarchar](20) NULL,
	[day_evening_class_div] [nvarchar](20) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_old_school] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_payment]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_payment](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[payment_recipient_div1] [nvarchar](20) NULL,
	[bank_cd1] [nvarchar](20) NULL,
	[deposit_item_div1] [nvarchar](20) NULL,
	[account_no1] [nvarchar](20) NULL,
	[bank_account_name1] [nvarchar](128) NULL,
	[po_name1] [nvarchar](128) NULL,
	[deposit_sign1] [nvarchar](20) NULL,
	[deposit_no1] [nvarchar](20) NULL,
	[po_account_name1] [nvarchar](128) NULL,
	[salary_transfer_fixed_amnt1] [numeric](12, 0) NULL,
	[bonus_transfer_fixed_amnt1] [numeric](12, 0) NULL,
	[payment_recipient_div2] [nvarchar](20) NULL,
	[bank_cd2] [nvarchar](20) NULL,
	[deposit_item_div2] [nvarchar](20) NULL,
	[account_no2] [nvarchar](20) NULL,
	[bank_account_name2] [nvarchar](128) NULL,
	[po_name2] [nvarchar](128) NULL,
	[deposit_sign2] [nvarchar](20) NULL,
	[deposit_no2] [nvarchar](20) NULL,
	[po_account_name2] [nvarchar](128) NULL,
	[salary_transfer_fixed_amnt2] [numeric](12, 0) NULL,
	[bonus_transfer_fixed_amnt2] [numeric](12, 0) NULL,
	[payment_recipient_div3] [nvarchar](20) NULL,
	[bank_cd3] [nvarchar](20) NULL,
	[deposit_item_div3] [nvarchar](20) NULL,
	[account_no3] [nvarchar](20) NULL,
	[bank_account_name3] [nvarchar](128) NULL,
	[po_name3] [nvarchar](128) NULL,
	[deposit_sign3] [nvarchar](20) NULL,
	[deposit_no3] [nvarchar](20) NULL,
	[po_account_name3] [nvarchar](128) NULL,
	[payment_recipient_target_div4] [nvarchar](20) NULL,
	[payment_recipient_div4] [nvarchar](20) NULL,
	[bank_cd4] [nvarchar](20) NULL,
	[deposit_item_div4] [nvarchar](20) NULL,
	[account_no4] [nvarchar](20) NULL,
	[bank_account_name4] [nvarchar](128) NULL,
	[po_name4] [nvarchar](128) NULL,
	[deposit_sign4] [nvarchar](20) NULL,
	[deposit_no4] [nvarchar](20) NULL,
	[po_account_name4] [nvarchar](128) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_payment] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_present_address]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_present_address](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[start_date] [datetime] NULL,
	[end_date] [datetime] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_present_address] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_present_address_detail]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_present_address_detail](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[housing_class_div] [nvarchar](20) NULL,
	[housing_status_div] [nvarchar](20) NULL,
	[country_cd] [uniqueidentifier] NULL,
	[postcode] [nvarchar](20) NULL,
	[prefecture_name] [nvarchar](64) NULL,
	[city_name] [nvarchar](64) NULL,
	[town_name] [nvarchar](255) NULL,
	[block_no_name] [nvarchar](64) NULL,
	[prefecture_name_kana] [nvarchar](64) NULL,
	[city_name_kana] [nvarchar](64) NULL,
	[town_name_kana] [nvarchar](255) NULL,
	[block_no_name_kana] [nvarchar](64) NULL,
	[tel_no] [nvarchar](64) NULL,
	[fax_no] [nvarchar](64) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_present_address_detail] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_previous_illness]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_previous_illness](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[previous_illness_seq] [nvarchar](20) NOT NULL,
	[previous_illness_name] [nvarchar](128) NULL,
	[previous_illness_attack_date] [datetime] NULL,
	[previous_illness_cure_date] [datetime] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_previous_illness] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_qualf]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_qualf](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[qualf_seq] [nvarchar](20) NOT NULL,
	[qualf_group_cd] [uniqueidentifier] NULL,
	[qualf_cd] [uniqueidentifier] NULL,
	[qualf_take_date] [datetime] NULL,
	[qualf_update_date] [datetime] NULL,
	[qualf_valid_time_limit_date] [datetime] NULL,
	[qualf_certification_no_name] [nvarchar](128) NULL,
	[qualf_allowance_flg] [bit] NULL,
	[special_affair] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_qualf] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_retire]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_retire](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[retire_date] [datetime] NULL,
	[retire_cause] [nvarchar](128) NULL,
	[sevp_amnt] [numeric](12, 0) NULL,
	[retire_point_count] [numeric](12, 0) NULL,
	[ob_society_join_status_flg] [bit] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_retire] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_social_labor_insurance]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_social_labor_insurance](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[ntnl_pnsn_base_no] [nvarchar](20) NULL,
	[ntnl_pnsn_base_take_date] [datetime] NULL,
	[ntnl_pnsn_base_loss_date] [datetime] NULL,
	[hi_card_no] [nvarchar](20) NULL,
	[erenow_hi_standard_rmnrt_amnt] [numeric](12, 0) NULL,
	[hi_take_date] [datetime] NULL,
	[hi_loss_date] [datetime] NULL,
	[empm_insurance_join_status_div] [nvarchar](20) NULL,
	[empm_insurance_card_no] [nvarchar](20) NULL,
	[short_time_insured_person_flg] [bit] NULL,
	[empm_insurance_take_date] [datetime] NULL,
	[empm_insurance_loss_date] [datetime] NULL,
	[workmans_comp_join_user_flg] [bit] NULL,
	[basic_pension_sign] [nvarchar](20) NULL,
	[basic_pension_notebook_no] [nvarchar](20) NULL,
	[basic_pension_serial_no] [nvarchar](20) NULL,
	[erenow_standard_rmnrt_amnt] [numeric](12, 0) NULL,
	[basic_pension_join_user_flg] [bit] NULL,
	[basic_pension_take_date] [datetime] NULL,
	[basic_pension_loss_date] [datetime] NULL,
	[empl_pension_fund_join_user_no] [nvarchar](20) NULL,
	[empl_pension_fund_serial_no] [nvarchar](20) NULL,
	[empl_pension_basic_salary_amnt] [numeric](12, 0) NULL,
	[empl_pension_first_add_flg] [bit] NULL,
	[empl_pension_second_add_flg] [bit] NULL,
	[empl_pension_take_date] [datetime] NULL,
	[empl_pension_loss_date] [datetime] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_social_labor_insurance] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_surety_detail]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_surety_detail](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[surety_name] [nvarchar](128) NULL,
	[relationship_surety_div] [nvarchar](20) NULL,
	[tel_no] [nvarchar](64) NULL,
	[domi_country_cd] [uniqueidentifier] NULL,
	[domi_postcode] [nvarchar](20) NULL,
	[domi_prefecture_name] [nvarchar](64) NULL,
	[domi_city_name] [nvarchar](64) NULL,
	[domi_town_name] [nvarchar](255) NULL,
	[domi_block_no_name] [nvarchar](64) NULL,
	[address_country_cd] [uniqueidentifier] NULL,
	[address_postcode] [nvarchar](20) NULL,
	[address_prefecture_name] [nvarchar](64) NULL,
	[address_city_name] [nvarchar](64) NULL,
	[address_town_name] [nvarchar](255) NULL,
	[address_block_no_name] [nvarchar](64) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_surety_detail] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_temporary_transfer]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_temporary_transfer](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[term_cd] [uniqueidentifier] NULL,
	[temporary_transfer_start_date] [datetime] NULL,
	[temporary_transfer_end_date] [datetime] NULL,
	[temporary_transfer_class_div] [nvarchar](20) NULL,
	[company_name] [nvarchar](128) NULL,
	[department_name] [nvarchar](128) NULL,
	[post_name] [nvarchar](128) NULL,
	[tel_no] [nvarchar](64) NULL,
	[work_name] [nvarchar](128) NULL,
	[address_country_cd] [uniqueidentifier] NULL,
	[address_postcode] [nvarchar](20) NULL,
	[address_prefecture_name] [nvarchar](64) NULL,
	[address_city_name] [nvarchar](64) NULL,
	[address_town_name] [nvarchar](255) NULL,
	[address_block_no_name] [nvarchar](64) NULL,
	[address_prefecture_name_kana] [nvarchar](64) NULL,
	[address_city_name_kana] [nvarchar](64) NULL,
	[address_town_name_kana] [nvarchar](255) NULL,
	[address_block_no_name_kana] [nvarchar](64) NULL,
	[abroad_work_status_flg] [bit] NULL,
	[visa_time_limit_date] [datetime] NULL,
	[go_alone_status_flg] [bit] NULL,
	[relocation_content_notes] [nvarchar](255) NULL,
	[rel_relocation_content_notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_temporary_transfer] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_treatment]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_treatment](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[company_cd] [uniqueidentifier] NULL,
	[work_place_cd] [uniqueidentifier] NULL,
	[work_system_cd] [uniqueidentifier] NULL,
	[empm_class_div] [nvarchar](20) NULL,
	[salary_class_div] [nvarchar](20) NULL,
	[abroad_work_status_flg] [bit] NULL,
	[station_name] [nvarchar](128) NULL,
	[station_start_date] [datetime] NULL,
	[station_end_date] [datetime] NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
	[grade_level] [nvarchar](20) NULL,
	[seniority_level] [nvarchar](20) NULL,
	[school_class_div] [nvarchar](20) NULL,
 CONSTRAINT [PK_hrm_t_treatment] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_union_executive]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_union_executive](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[union_executive_seq] [nvarchar](20) NOT NULL,
	[union_executive_name] [nvarchar](128) NULL,
	[union_executive_start_date] [datetime] NULL,
	[union_executive_end_date] [datetime] NULL,
	[full_time_flg] [bit] NULL,
	[notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_union_executive] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[hrm_t_union_join]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[hrm_t_union_join](
	[employee_cd] [uniqueidentifier] NOT NULL,
	[union_join_seq] [nvarchar](20) NOT NULL,
	[company_cd] [uniqueidentifier] NULL,
	[union_cd] [uniqueidentifier] NULL,
	[union_start_date] [datetime] NULL,
	[union_end_date] [datetime] NULL,
	[notes] [nvarchar](255) NULL,
	[record_user_cd] [uniqueidentifier] NULL,
	[record_date] [datetime] NULL,
 CONSTRAINT [PK_hrm_t_union_join] PRIMARY KEY CLUSTERED 
(
	[employee_cd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Location]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NOT NULL,
	[Description] [nvarchar](500) NULL,
	[Code] [varchar](50) NOT NULL,
	[FullCode] [nchar](20) NULL,
	[ProjectId] [int] NOT NULL,
	[LocationParent] [int] NULL,
	[Level] [int] NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Region]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Region](
	[RegionId] [int] IDENTITY(1,1) NOT NULL,
	[RegionName] [varchar](100) NOT NULL,
	[SortOrder] [int] NULL,
 CONSTRAINT [PK_Region] PRIMARY KEY CLUSTERED 
(
	[RegionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_Membership]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Membership](
	[UserId] [int] NOT NULL,
	[CreateDate] [datetime] NULL,
	[ConfirmationToken] [nvarchar](128) NULL,
	[IsConfirmed] [bit] NULL,
	[LastPasswordFailureDate] [datetime] NULL,
	[PasswordFailuresSinceLastSuccess] [int] NOT NULL,
	[Password] [nvarchar](128) NOT NULL,
	[PasswordChangedDate] [datetime] NULL,
	[PasswordSalt] [nvarchar](128) NOT NULL,
	[PasswordVerificationToken] [nvarchar](128) NULL,
	[PasswordVerificationTokenExpirationDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_OAuthMembership]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_OAuthMembership](
	[Provider] [nvarchar](30) NOT NULL,
	[ProviderUserId] [nvarchar](100) NOT NULL,
	[UserId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Provider] ASC,
	[ProviderUserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_Roles]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_Roles](
	[RoleId] [int] IDENTITY(1,1) NOT NULL,
	[RoleName] [nvarchar](256) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[webpages_UsersInRoles]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[webpages_UsersInRoles](
	[UserId] [int] NOT NULL,
	[RoleId] [int] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[RoleId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Ref].[TimeZone]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Ref].[TimeZone](
	[TimeZoneId] [int] NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[Time] [nvarchar](50) NULL,
 CONSTRAINT [PK_TimeZone] PRIMARY KEY CLUSTERED 
(
	[TimeZoneId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [Security].[SecurityMatrix]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [Security].[SecurityMatrix](
	[Resource] [varchar](50) NOT NULL,
	[Operation] [varchar](50) NOT NULL,
	[Role] [varchar](50) NOT NULL,
	[Value] [bit] NOT NULL,
	[CreatedBy] [nvarchar](50) NULL,
	[CreatedDate] [datetime] NULL,
	[ModifiedDate] [datetime] NULL,
	[ModifiedBy] [nvarchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[Role] ASC,
	[Resource] ASC,
	[Operation] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[hrm_t_employee_base] ON 

INSERT [dbo].[hrm_t_employee_base] ([employee_cd], [sex_div], [blood_type_div], [hometown_name], [birth_date], [maiden_name], [maiden_name_kana], [maiden_name_eng], [marriage_date], [householder_flg], [domi_country_cd], [domi_postcode], [domi_prefecture_name], [domi_city_name], [domi_town_name], [domi_block_no_name], [relationship_history_div], [single_status_flg], [image_file_logical_name], [image_file_physical_name], [record_user_cd], [record_date], [home_phone], [cell_phone], [email], [address], [idcard_number], [idcard_date], [idcard_place], [license_num], [license_type], [arg1], [arg2], [arg3], [arg4], [arg5], [arg6], [arg7], [arg8], [arg9], [arg10], [employee_id], [employee_code]) VALUES (N'5b1d7aa5-36b6-4c42-8d0a-1bb92bed75b1', N'Female', N'AB', N'Quê quán', CAST(N'1983-06-25T00:00:00.000' AS DateTime), N'Họ tên', NULL, N'Họ tên (tiếng Anh)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'TyChuot120161226013816197.jpg', N'TyChuot120161226013816197.jpg', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'SD10001')
INSERT [dbo].[hrm_t_employee_base] ([employee_cd], [sex_div], [blood_type_div], [hometown_name], [birth_date], [maiden_name], [maiden_name_kana], [maiden_name_eng], [marriage_date], [householder_flg], [domi_country_cd], [domi_postcode], [domi_prefecture_name], [domi_city_name], [domi_town_name], [domi_block_no_name], [relationship_history_div], [single_status_flg], [image_file_logical_name], [image_file_physical_name], [record_user_cd], [record_date], [home_phone], [cell_phone], [email], [address], [idcard_number], [idcard_date], [idcard_place], [license_num], [license_type], [arg1], [arg2], [arg3], [arg4], [arg5], [arg6], [arg7], [arg8], [arg9], [arg10], [employee_id], [employee_code]) VALUES (N'3763a89a-2891-48e8-b349-286436a60479', N'Female', N'O', N'Quê quán Quê quán', CAST(N'1983-06-25T00:00:00.000' AS DateTime), N'Họ tên', NULL, N'Họ tên (tiếng Anh)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'TyChuot.png', N'TyChuot20161226021812952.png', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 2, N'SD10002')
INSERT [dbo].[hrm_t_employee_base] ([employee_cd], [sex_div], [blood_type_div], [hometown_name], [birth_date], [maiden_name], [maiden_name_kana], [maiden_name_eng], [marriage_date], [householder_flg], [domi_country_cd], [domi_postcode], [domi_prefecture_name], [domi_city_name], [domi_town_name], [domi_block_no_name], [relationship_history_div], [single_status_flg], [image_file_logical_name], [image_file_physical_name], [record_user_cd], [record_date], [home_phone], [cell_phone], [email], [address], [idcard_number], [idcard_date], [idcard_place], [license_num], [license_type], [arg1], [arg2], [arg3], [arg4], [arg5], [arg6], [arg7], [arg8], [arg9], [arg10], [employee_id], [employee_code]) VALUES (N'0fb44c9b-ca31-4b20-8cff-b04b7b39a335', N'Female', N'O', N'Quê quán O', CAST(N'2016-12-26T00:00:00.000' AS DateTime), N'Họ tên', NULL, N'Họ tên (tiếng Anh)', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, N'TyChuot.png', N'TyChuot20161226023610217.png', NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, NULL, 3, N'SD10003')
SET IDENTITY_INSERT [dbo].[hrm_t_employee_base] OFF
SET IDENTITY_INSERT [dbo].[UserProfile] ON 

INSERT [dbo].[UserProfile] ([UserId], [UserName], [IsGroupAdmin], [LastLogIn]) VALUES (1, N'manhnv83@gmail.com', NULL, NULL)
SET IDENTITY_INSERT [dbo].[UserProfile] OFF
INSERT [dbo].[webpages_Membership] ([UserId], [CreateDate], [ConfirmationToken], [IsConfirmed], [LastPasswordFailureDate], [PasswordFailuresSinceLastSuccess], [Password], [PasswordChangedDate], [PasswordSalt], [PasswordVerificationToken], [PasswordVerificationTokenExpirationDate]) VALUES (1, CAST(N'2016-12-19T16:18:02.690' AS DateTime), NULL, 1, NULL, 0, N'AFi53Dt9FKRN/1v8RiNHcVyKbnUodPnu/ig7jPKSK7yFx2QJFCWT8Zs9Ouawtg4P5g==', CAST(N'2016-12-19T16:18:02.690' AS DateTime), N'', NULL, NULL)
SET ANSI_PADDING ON

GO
/****** Object:  Index [uc_BusinessDesc]    Script Date: 12/28/2016 9:18:59 AM ******/
ALTER TABLE [dbo].[BusinessUnit] ADD  CONSTRAINT [uc_BusinessDesc] UNIQUE NONCLUSTERED 
(
	[BusinessUnitName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uc_CountryDesc]    Script Date: 12/28/2016 9:18:59 AM ******/
ALTER TABLE [dbo].[Country] ADD  CONSTRAINT [uc_CountryDesc] UNIQUE NONCLUSTERED 
(
	[CountryName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [IX_hrm_t_employee_base]    Script Date: 12/28/2016 9:18:59 AM ******/
ALTER TABLE [dbo].[hrm_t_employee_base] ADD  CONSTRAINT [IX_hrm_t_employee_base] UNIQUE NONCLUSTERED 
(
	[employee_code] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uc_ProjectName]    Script Date: 12/28/2016 9:18:59 AM ******/
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [uc_ProjectName] UNIQUE NONCLUSTERED 
(
	[Name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uc_ProjectShortName]    Script Date: 12/28/2016 9:18:59 AM ******/
ALTER TABLE [dbo].[Project] ADD  CONSTRAINT [uc_ProjectShortName] UNIQUE NONCLUSTERED 
(
	[ShortName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uc_RegionDesc]    Script Date: 12/28/2016 9:18:59 AM ******/
ALTER TABLE [dbo].[Region] ADD  CONSTRAINT [uc_RegionDesc] UNIQUE NONCLUSTERED 
(
	[RegionName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [uc_UserName]    Script Date: 12/28/2016 9:18:59 AM ******/
ALTER TABLE [dbo].[UserProfile] ADD  CONSTRAINT [uc_UserName] UNIQUE NONCLUSTERED 
(
	[UserName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
SET ANSI_PADDING ON

GO
/****** Object:  Index [UQ__webpages__8A2B61603FF5DCB5]    Script Date: 12/28/2016 9:18:59 AM ******/
ALTER TABLE [dbo].[webpages_Roles] ADD UNIQUE NONCLUSTERED 
(
	[RoleName] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, SORT_IN_TEMPDB = OFF, IGNORE_DUP_KEY = OFF, ONLINE = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
GO
ALTER TABLE [dbo].[hrm_m_access_auth_b] ADD  DEFAULT (newid()) FOR [access_auth_cd]
GO
ALTER TABLE [dbo].[hrm_m_access_auth_department] ADD  DEFAULT (newid()) FOR [access_auth_cd]
GO
ALTER TABLE [dbo].[hrm_m_access_auth_detail] ADD  DEFAULT (newid()) FOR [access_auth_cd]
GO
ALTER TABLE [dbo].[hrm_m_access_auth_post] ADD  DEFAULT (newid()) FOR [access_auth_cd]
GO
ALTER TABLE [dbo].[hrm_m_access_auth_role] ADD  DEFAULT (newid()) FOR [access_auth_cd]
GO
ALTER TABLE [dbo].[hrm_m_appointment] ADD  DEFAULT (newid()) FOR [appointment_cd]
GO
ALTER TABLE [dbo].[hrm_m_appointment_condition] ADD  DEFAULT (newid()) FOR [appointment_cd]
GO
ALTER TABLE [dbo].[hrm_m_appointment_detail] ADD  DEFAULT (newid()) FOR [appointment_cd]
GO
ALTER TABLE [dbo].[hrm_m_appointment_detail_param] ADD  DEFAULT (newid()) FOR [appointment_cd]
GO
ALTER TABLE [dbo].[hrm_m_auth] ADD  DEFAULT (newid()) FOR [feature_cd]
GO
ALTER TABLE [dbo].[hrm_m_bank] ADD  DEFAULT (newid()) FOR [bank_cd]
GO
ALTER TABLE [dbo].[hrm_m_cd] ADD  DEFAULT (newid()) FOR [cd_group_cd]
GO
ALTER TABLE [dbo].[hrm_m_cd_group] ADD  DEFAULT (newid()) FOR [cd_group_cd]
GO
ALTER TABLE [dbo].[hrm_m_company_b] ADD  DEFAULT (newid()) FOR [company_cd]
GO
ALTER TABLE [dbo].[hrm_m_company_each_cd_group] ADD  DEFAULT (newid()) FOR [cd_group_cd]
GO
ALTER TABLE [dbo].[hrm_m_country] ADD  DEFAULT (newid()) FOR [country_cd]
GO
ALTER TABLE [dbo].[hrm_m_employee_b] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_m_id_management] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_m_list] ADD  DEFAULT (newid()) FOR [list_cd]
GO
ALTER TABLE [dbo].[hrm_m_list_condition] ADD  DEFAULT (newid()) FOR [list_cd]
GO
ALTER TABLE [dbo].[hrm_m_list_detail] ADD  DEFAULT (newid()) FOR [list_cd]
GO
ALTER TABLE [dbo].[hrm_m_list_detail_param] ADD  DEFAULT (newid()) FOR [list_cd]
GO
ALTER TABLE [dbo].[hrm_m_list_header] ADD  DEFAULT (newid()) FOR [list_cd]
GO
ALTER TABLE [dbo].[hrm_m_postcode] ADD  CONSTRAINT [DF__hrm_m_pos__count__23F3538A]  DEFAULT (newid()) FOR [country_cd]
GO
ALTER TABLE [dbo].[hrm_m_qualf_group] ADD  DEFAULT (newid()) FOR [qualf_group_cd]
GO
ALTER TABLE [dbo].[hrm_m_query] ADD  DEFAULT (newid()) FOR [query_cd]
GO
ALTER TABLE [dbo].[hrm_m_query_column] ADD  DEFAULT (newid()) FOR [query_cd]
GO
ALTER TABLE [dbo].[hrm_m_query_condition] ADD  DEFAULT (newid()) FOR [query_cd]
GO
ALTER TABLE [dbo].[hrm_m_sys_parameter] ADD  DEFAULT (newid()) FOR [sys_parameter_cd]
GO
ALTER TABLE [dbo].[hrm_m_sys_params] ADD  DEFAULT (newid()) FOR [sys_parameter_cd]
GO
ALTER TABLE [dbo].[hrm_t_award_punition] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_contact_address] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_dependent] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_dependent_detail] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_disabled] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_disaster] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_employee_base] ADD  CONSTRAINT [DF__hrm_t_emp__emplo__0697FACD]  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_employee_other] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_former_job] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_health_checkup] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_joining_company] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_old_school] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_previous_illness] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_qualf] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_retire] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_social_labor_insurance] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_treatment] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_union_executive] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[hrm_t_union_join] ADD  DEFAULT (newid()) FOR [employee_cd]
GO
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [IsConfirmed]
GO
ALTER TABLE [dbo].[webpages_Membership] ADD  DEFAULT ((0)) FOR [PasswordFailuresSinceLastSuccess]
GO
ALTER TABLE [Security].[SecurityMatrix] ADD  DEFAULT ((0)) FOR [Value]
GO
ALTER TABLE [dbo].[BusinessUnit]  WITH NOCHECK ADD  CONSTRAINT [FK_BusinessUnit_Region] FOREIGN KEY([RegionId])
REFERENCES [dbo].[Region] ([RegionId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[BusinessUnit] CHECK CONSTRAINT [FK_BusinessUnit_Region]
GO
ALTER TABLE [dbo].[Country]  WITH NOCHECK ADD  CONSTRAINT [FK_Country_BusinessUnit] FOREIGN KEY([BusinessUnitId])
REFERENCES [dbo].[BusinessUnit] ([BusinessUnitId])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Country] CHECK CONSTRAINT [FK_Country_BusinessUnit]
GO
ALTER TABLE [dbo].[GroupGeneralUser]  WITH CHECK ADD  CONSTRAINT [FK_GroupGeneralUser_BusinessUnit] FOREIGN KEY([BusinessUnitId])
REFERENCES [dbo].[BusinessUnit] ([BusinessUnitId])
GO
ALTER TABLE [dbo].[GroupGeneralUser] CHECK CONSTRAINT [FK_GroupGeneralUser_BusinessUnit]
GO
ALTER TABLE [dbo].[GroupGeneralUser]  WITH CHECK ADD  CONSTRAINT [FK_GroupGeneralUser_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([CountryId])
GO
ALTER TABLE [dbo].[GroupGeneralUser] CHECK CONSTRAINT [FK_GroupGeneralUser_Country]
GO
ALTER TABLE [dbo].[GroupGeneralUser]  WITH CHECK ADD  CONSTRAINT [FK_GroupGeneralUser_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[GroupGeneralUser] CHECK CONSTRAINT [FK_GroupGeneralUser_Project]
GO
ALTER TABLE [dbo].[GroupGeneralUser]  WITH CHECK ADD  CONSTRAINT [FK_GroupGeneralUser_Region] FOREIGN KEY([RegionId])
REFERENCES [dbo].[Region] ([RegionId])
GO
ALTER TABLE [dbo].[GroupGeneralUser] CHECK CONSTRAINT [FK_GroupGeneralUser_Region]
GO
ALTER TABLE [dbo].[GroupGeneralUser]  WITH CHECK ADD  CONSTRAINT [FK_GroupGeneralUser_UserProfile] FOREIGN KEY([UserProfileId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[GroupGeneralUser] CHECK CONSTRAINT [FK_GroupGeneralUser_UserProfile]
GO
ALTER TABLE [dbo].[Location]  WITH NOCHECK ADD  CONSTRAINT [FK_Location_Location] FOREIGN KEY([LocationParent])
REFERENCES [dbo].[Location] ([Id])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Location]
GO
ALTER TABLE [dbo].[Location]  WITH NOCHECK ADD  CONSTRAINT [FK_Location_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Project]
GO
ALTER TABLE [dbo].[Permissions]  WITH CHECK ADD  CONSTRAINT [FK_Permissions_Function] FOREIGN KEY([FunctionId])
REFERENCES [dbo].[Function] ([FunctionId])
GO
ALTER TABLE [dbo].[Permissions] CHECK CONSTRAINT [FK_Permissions_Function]
GO
ALTER TABLE [dbo].[Permissions]  WITH CHECK ADD  CONSTRAINT [FK_Permissions_ProjectRole] FOREIGN KEY([ProjectRoleId])
REFERENCES [dbo].[ProjectRole] ([ProjectRoleId])
GO
ALTER TABLE [dbo].[Permissions] CHECK CONSTRAINT [FK_Permissions_ProjectRole]
GO
ALTER TABLE [dbo].[Project]  WITH NOCHECK ADD  CONSTRAINT [FK_Project_Country] FOREIGN KEY([CountryId])
REFERENCES [dbo].[Country] ([CountryId])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_Country]
GO
ALTER TABLE [dbo].[Project]  WITH CHECK ADD  CONSTRAINT [FK_Project_TimeZone] FOREIGN KEY([TimeZone])
REFERENCES [Ref].[TimeZone] ([TimeZoneId])
GO
ALTER TABLE [dbo].[Project] CHECK CONSTRAINT [FK_Project_TimeZone]
GO
ALTER TABLE [dbo].[ProjectPermissions]  WITH CHECK ADD  CONSTRAINT [FK_ProjectPermissions_Permissions] FOREIGN KEY([PermissionId])
REFERENCES [dbo].[Permissions] ([PermissionId])
GO
ALTER TABLE [dbo].[ProjectPermissions] CHECK CONSTRAINT [FK_ProjectPermissions_Permissions]
GO
ALTER TABLE [dbo].[ProjectPermissions]  WITH CHECK ADD  CONSTRAINT [FK_ProjectPermissions_ProjectUser] FOREIGN KEY([ProjectUserId])
REFERENCES [dbo].[ProjectUser] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProjectPermissions] CHECK CONSTRAINT [FK_ProjectPermissions_ProjectUser]
GO
ALTER TABLE [dbo].[ProjectUser]  WITH CHECK ADD  CONSTRAINT [FK_ProjectUser_Project] FOREIGN KEY([ProjectId])
REFERENCES [dbo].[Project] ([Id])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[ProjectUser] CHECK CONSTRAINT [FK_ProjectUser_Project]
GO
ALTER TABLE [dbo].[ProjectUser]  WITH CHECK ADD  CONSTRAINT [FK_ProjectUser_UserProfile] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[ProjectUser] CHECK CONSTRAINT [FK_ProjectUser_UserProfile]
GO
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_RoleId] FOREIGN KEY([RoleId])
REFERENCES [dbo].[webpages_Roles] ([RoleId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_RoleId]
GO
ALTER TABLE [dbo].[webpages_UsersInRoles]  WITH CHECK ADD  CONSTRAINT [fk_UserId] FOREIGN KEY([UserId])
REFERENCES [dbo].[UserProfile] ([UserId])
GO
ALTER TABLE [dbo].[webpages_UsersInRoles] CHECK CONSTRAINT [fk_UserId]
GO
/****** Object:  StoredProcedure [dbo].[SearchEmployees]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[SearchEmployees] (@searchCriteria XML)
AS

 --EXEC [dbo].[SearchEmployees] 
 --N'<EmployeeSearchCriteria>
 --  <HomeTown>Quê quán</HomeTown>
 --  <FullName></FullName>
 --  <FullNameEnglish></FullNameEnglish>
 --  <Code></Code>
 --  <BirthDate></BirthDate>
 --</EmployeeSearchCriteria>'

BEGIN
	SET DATEFORMAT DMY;

	DECLARE @FullName NVARCHAR(128)
	,@FullNameEnglish NVARCHAR(128)
	,@HomeTown NVARCHAR(128)
	,@Code VARCHAR(10)
	,@BirthDate Date
	--,@Id int
		
	SELECT @FullName = b.query('FullName').value('.', 'NVARCHAR(128)')
	    ,@FullNameEnglish = b.query('FullNameEnglish').value('.', 'NVARCHAR(128)')
	    ,@HomeTown = b.query('HomeTown').value('.', 'NVARCHAR(128)')
	    ,@Code = b.query('Code').value('.', 'VARCHAR(10)')
		,@BirthDate = b.query('BirthDate').value('.', 'DATE')	
		--,@Id = b.query('Id').value('.','INT')

	FROM @searchCriteria.nodes('EmployeeSearchCriteria') AS a(b);

	IF @Code IS NULL
		SET @Code = '';

	IF @HomeTown IS NULL
		SET @HomeTown = '';

	IF @FullName IS NULL
		SET @FullName = '';

	IF @FullNameEnglish IS NULL
		SET @FullNameEnglish = '';
	
	IF (
			@BirthDate IS NULL
			OR @BirthDate = CAST('1900-01-01' AS DATE)
			)
		SET @BirthDate = '';

	PRINT '@BirthDate: '
	PRINT @BirthDate;
	--print 'Id: ';
	--print @Id;
		
	SELECT --[employee_cd]
      --,[sex_div]
      --,[blood_type_div]
      [hometown_name] as [HomeTown]
      ,[birth_date] as [BirthDate]
      ,[maiden_name] as [FullName]
      ,[maiden_name_kana] as [FullNameEnglish]
      --,[maiden_name_eng]
      --,[marriage_date]
      --,[householder_flg]
      --,[domi_country_cd]
      --,[domi_postcode]
      --,[domi_prefecture_name]
      --,[domi_city_name]
      --,[domi_town_name]
      --,[domi_block_no_name]
      --,[relationship_history_div]
      --,[single_status_flg]
      --,[image_file_logical_name]
      --,[image_file_physical_name]
      --,[record_user_cd]
      --,[record_date]
      --,[home_phone]
      --,[cell_phone]
      --,[email]
      --,[address]
      --,[idcard_number]
      --,[idcard_date]
      --,[idcard_place]
      --,[license_num]
      --,[license_type]
      --,[arg1]
      --,[arg2]
      --,[arg3]
      --,[arg4]
      --,[arg5]
      --,[arg6]
      --,[arg7]
      --,[arg8]
      --,[arg9]
      --,[arg10]
      ,[employee_id] as [Id]
      ,[employee_code] as [Code]
    --  ,REPLACE(CONCAT (
				--[record_date]
				--,' ('
				--,REPLACE(CONVERT(VARCHAR, (CONVERT(DATE, [record_date], 106)), 106), ' ', '-')
				--,')'
				--), '()', '') AS [CreatedDate]
	FROM [dbo].[hrm_t_employee_base]
	WHERE (
			@Code = ''
			OR [employee_code] LIKE '%' + @Code + '%'
			)
		AND (
			@FullName = ''
			OR [maiden_name] LIKE '%' + @FullName + '%'
			)
		AND (
			@FullNameEnglish = ''
			OR [maiden_name_eng] LIKE '%' + @FullNameEnglish + '%'
			)		
        AND (
			@HomeTown = ''
			OR [hometown_name] LIKE '%' + @HomeTown + '%'
			)
		AND (
			@BirthDate = ''
			OR [birth_date] = @BirthDate
			)
		--AND (
		--	@Active = ''
		--	OR Employees.Active = @Active
		--	)
		--AND (
		--	@TeamId = 0
		--	OR
		--	Employees.TeamId = @TeamId
		--	)
END

GO
/****** Object:  StoredProcedure [dbo].[SearchProjectRoleByUserName]    Script Date: 12/28/2016 9:18:59 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[SearchProjectRoleByUserName] (@UserId INT, @ProjectId INT)
AS
SELECT DISTINCT p.ProjectRoleId
FROM dbo.UserProfile up
INNER JOIN dbo.ProjectUser pu ON up.UserId = pu.UserId
INNER JOIN dbo.ProjectPermissions pp ON pu.Id = pp.ProjectUserId
INNER JOIN dbo.Permissions p ON pp.PermissionId = p.PermissionId
INNER JOIN dbo.ProjectRole pr ON p.ProjectRoleId = pr.ProjectRoleId
WHERE up.UserId = @UserId AND ProjectId = @ProjectId



GO
USE [master]
GO
ALTER DATABASE [scmv_hrm] SET  READ_WRITE 
GO
