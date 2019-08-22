begin transaction;

truncate table [dbo].[IntensityCheck];
truncate table [dbo].[Monochromator];

INSERT INTO [dbo].[IntensityCheck] ([Name], [Channel], [Ratio], [Initial], [Current], [LastModified], [Status])
VALUES ('Name1', 'Channel1', 345.34, 564.4, 56.5, '20120618 10:34:09 AM', 0);

INSERT INTO [dbo].[IntensityCheck] ([Name], [Channel], [Ratio], [Initial], [Current], [LastModified], [Status])
VALUES ('Name2', 'Channel2', 145.34, 964.4, 55.5, '20150618 10:34:09 AM', 0);

INSERT INTO [dbo].[IntensityCheck] ([Name], [Channel], [Ratio], [Initial], [Current], [LastModified], [Status])
VALUES ('Name3', 'Channel3', 645.34, 5564.4, 6.5, '20160618 10:34:09 AM', 0);

---------------------

INSERT INTO [dbo].[Monochromator] ([Name], [DetectorType], [Filter], [Disabled])
VALUES ('MgKa', 'FPC', 'Not fitted', 0);

INSERT INTO [dbo].[Monochromator] ([Name], [DetectorType], [Filter], [Disabled])
VALUES ('AlKa', 'FPC', 'Not fitted', 0);

INSERT INTO [dbo].[Monochromator] ([Name], [DetectorType], [Filter], [Disabled])
VALUES ('CrKa', 'ExKrBe', 'Fitted', 1);

INSERT INTO [dbo].[Monochromator] ([Name], [DetectorType], [Filter], [Disabled])
VALUES ('P_Ka', 'SC', 'Fitted', 0);

commit;