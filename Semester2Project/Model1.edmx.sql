
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/28/2022 19:55:50
-- Generated from EDMX file: C:\Users\S00211436\Documents\College Y2\Semerter 2\OOD\Project\Semester2Project\Semester2Project\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [FinalProjectOOD];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Orders'
CREATE TABLE [dbo].[Orders] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderDetails'
CREATE TABLE [dbo].[OrderDetails] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [OrderId] int  NOT NULL,
    [StructureName] nvarchar(max)  NOT NULL,
    [Quantity] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'OrderCosts'
CREATE TABLE [dbo].[OrderCosts] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Stone] nvarchar(max)  NOT NULL,
    [Wood] nvarchar(max)  NOT NULL,
    [Thatch] nvarchar(max)  NOT NULL,
    [Metal] nvarchar(max)  NOT NULL,
    [CementingPaste] nvarchar(max)  NOT NULL,
    [Crystal] nvarchar(max)  NOT NULL,
    [Polymer] nvarchar(max)  NOT NULL,
    [OrderId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Orders'
ALTER TABLE [dbo].[Orders]
ADD CONSTRAINT [PK_Orders]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [PK_OrderDetails]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'OrderCosts'
ALTER TABLE [dbo].[OrderCosts]
ADD CONSTRAINT [PK_OrderCosts]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [OrderId] in table 'OrderDetails'
ALTER TABLE [dbo].[OrderDetails]
ADD CONSTRAINT [FK_OrderOrderDetails]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderOrderDetails'
CREATE INDEX [IX_FK_OrderOrderDetails]
ON [dbo].[OrderDetails]
    ([OrderId]);
GO

-- Creating foreign key on [OrderId] in table 'OrderCosts'
ALTER TABLE [dbo].[OrderCosts]
ADD CONSTRAINT [FK_OrderOrderCost]
    FOREIGN KEY ([OrderId])
    REFERENCES [dbo].[Orders]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_OrderOrderCost'
CREATE INDEX [IX_FK_OrderOrderCost]
ON [dbo].[OrderCosts]
    ([OrderId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------