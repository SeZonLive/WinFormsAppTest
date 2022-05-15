SET ANSI_NULLS ON

SET QUOTED_IDENTIFIER ON

CREATE DATABASE [TEST]
GO

USE [TEST]
GO

/****** Объект: Table [dbo].[T_Clients] ******/
CREATE TABLE [dbo].[T_Clients] (
    [ID_Client]            INT            IDENTITY (1, 1) NOT NULL,
    [Naimenovanie]         NVARCHAR (MAX) NULL,
    [INN]                  NVARCHAR (MAX) NULL,
    [ID_SferyDeyatelnosti] INT            NOT NULL,
    [Primechanie]          NVARCHAR (MAX) NULL
);

/****** Объект: Table [dbo].[T_SferyDeyatelnosti] ******/
CREATE TABLE [dbo].[T_SferyDeyatelnosti] (
    [ID_SferyDeyatelnosti] INT            IDENTITY (1, 1) NOT NULL,
    [SferaDeyatelnosti]    NVARCHAR (MAX) NULL
);

/****** Объект: Table [dbo].[T_Statusy] ******/
CREATE TABLE [dbo].[T_Statusy] (
    [ID_Status] INT            IDENTITY (1, 1) NOT NULL,
    [Status]    NVARCHAR (MAX) NULL
);

/****** Объект: Table [dbo].[T_Zayavki] ******/
CREATE TABLE [dbo].[T_Zayavki] (
    [ID_Zayavki]        INT            IDENTITY (1, 1) NOT NULL,
    [DataZayavki]       DATETIME       NULL,
    [NaimenovanieRabot] NVARCHAR (MAX) NULL,
    [OpisanieRabot]     NVARCHAR (MAX) NULL,
    [ID_Status]         INT            NOT NULL,
    [ID_Client]         INT            NOT NULL
);

/****** Заполнение ******/

INSERT INTO [dbo].[T_Clients] ([Naimenovanie],[INN],[ID_SferyDeyatelnosti],[Primechanie])
VALUES (N'Клиент 1', '111', 1, N'Примечание 1')

INSERT INTO [dbo].[T_Clients] ([Naimenovanie],[INN],[ID_SferyDeyatelnosti],[Primechanie])
VALUES (N'Клиент 2', '222', 1, N'Примечание 2')

INSERT INTO [dbo].[T_Clients] ([Naimenovanie],[INN],[ID_SferyDeyatelnosti],[Primechanie])
VALUES (N'Клиент 3', '333', 2, N'Примечание 3')

INSERT INTO [dbo].[T_SferyDeyatelnosti] ([SferaDeyatelnosti]) VALUES (N'Сфера 1')
INSERT INTO [dbo].[T_SferyDeyatelnosti] ([SferaDeyatelnosti]) VALUES (N'Сфера 2')

INSERT INTO [dbo].[T_Statusy] ([Status]) VALUES (N'новая')
INSERT INTO [dbo].[T_Statusy] ([Status]) VALUES (N'в работе')
INSERT INTO [dbo].[T_Statusy] ([Status]) VALUES (N'выполнена')

INSERT INTO [dbo].[T_Zayavki] ([DataZayavki],[NaimenovanieRabot],[OpisanieRabot],[ID_Status],[ID_Client])
VALUES (DATEADD(DAY, -1, GETDATE()), N'Наименование работ 1', N'Описание работ 1', 1, 1)

INSERT INTO [dbo].[T_Zayavki] ([DataZayavki],[NaimenovanieRabot],[OpisanieRabot],[ID_Status],[ID_Client])
VALUES (DATEADD(DAY, -2, GETDATE()), N'Наименование работ 2', N'Описание работ 2', 1, 2)

INSERT INTO [dbo].[T_Zayavki] ([DataZayavki],[NaimenovanieRabot],[OpisanieRabot],[ID_Status],[ID_Client])
VALUES (DATEADD(DAY, -3, GETDATE()), N'Наименование работ 3', N'Описание работ 3', 1, 3)

INSERT INTO [dbo].[T_Zayavki] ([DataZayavki],[NaimenovanieRabot],[OpisanieRabot],[ID_Status],[ID_Client])
VALUES (DATEADD(DAY, -4, GETDATE()), N'Наименование работ 4', N'Описание работ 4', 2, 3)









