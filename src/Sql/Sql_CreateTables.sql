IF OBJECT_ID('dbo.IntensityCheck', 'U') IS NOT NULL
 DROP TABLE dbo.IntensityCheck;

IF OBJECT_ID('dbo.MaintenanceCheck', 'U') IS NOT NULL
 DROP TABLE dbo.MaintenanceCheck;

IF OBJECT_ID('dbo.MeasuredSample', 'U') IS NOT NULL
 DROP TABLE dbo.MeasuredSample;

IF OBJECT_ID('dbo.MeasuredElement', 'U') IS NOT NULL
 DROP TABLE dbo.MeasuredElement;

IF OBJECT_ID('dbo.Monochromator', 'U') IS NOT NULL
 DROP TABLE dbo.Monochromator;

CREATE TABLE [dbo].[IntensityCheck] (
    [Id] INT PRIMARY KEY IDENTITY (1, 1),
    [Name] NCHAR (100) NOT NULL,
    [Channel] NCHAR (100) NOT NULL,
	[Ratio] Numeric(18,5),
	[Initial] Numeric(18,5),
	[Current] Numeric(18,5),
    [LastModified] DATETIME,
    [Status] BIT NOT NULL DEFAULT 0
);

CREATE TABLE [dbo].[MaintenanceCheck] (
    [Id] INT PRIMARY KEY IDENTITY (1, 1),
    [Label] NCHAR (100) NOT NULL,
    [Status] BIT NOT NULL DEFAULT 0
);

CREATE TABLE [dbo].[MeasuredElement] (
    [Id] INT PRIMARY KEY IDENTITY (1, 1),
    [Name] NCHAR (100) NOT NULL,
	[Crystal] NCHAR (100),
	[Detector] NCHAR (100),
	[Collimator] Numeric(18,5)
);

CREATE TABLE [dbo].[MeasuredSample] (
    [Id] INT PRIMARY KEY IDENTITY (1, 1),
    [Name] NCHAR (100) NOT NULL,
	[Certif] Numeric(18,5),
	[Measure] Numeric(18,5),
	[Difference] Numeric(18,5),
	[ElementId] INT NOT NULL,
	FOREIGN KEY ([ElementId]) REFERENCES [dbo].[MeasuredElement] ([Id])
);

CREATE TABLE [dbo].[Monochromator] (
    [Id] INT PRIMARY KEY IDENTITY (1, 1),
    [Name] NCHAR (100) NOT NULL,
	[DetectorType] NCHAR (100),
	[Filter] NCHAR (100),
	[Disabled] BIT NOT NULL DEFAULT 0
);



