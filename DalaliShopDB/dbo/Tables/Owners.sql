CREATE TABLE [dbo].[Owners] (
    [UsedId]          INT            IDENTITY (1, 1) NOT NULL,
    [FirstName]       VARCHAR (255)  NOT NULL,
    [MiddleName]      VARCHAR (255)  NULL,
    [LastName]        VARCHAR (255)  NULL,
    [FullName]        VARCHAR (1000) NULL,
    [CreatedBy]       VARCHAR (255)  NOT NULL,
    [UpdatedBy]       VARCHAR (255)  NULL,
    [EmailAdress]     VARCHAR (400)  NULL,
    [MobileNumber]    BIGINT         NULL,
    [PermanantAdress] VARCHAR (2000) NULL,
    [Place]           VARCHAR (200)  NULL,
    [Taluq]           VARCHAR (200)  NULL,
    [District]        VARCHAR (200)  NULL,
    [Pincode]         INT            NOT NULL,
    [FingerPrint]     BINARY (1)     NULL,
    [Active]          BIT            NULL,
    [DateCreated]     DATETIME       NOT NULL,
    PRIMARY KEY CLUSTERED ([FirstName] ASC)
);



