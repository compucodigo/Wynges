
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/11/2018 08:31:23
-- Generated from EDMX file: C:\Codigo\Wynges\Wynges\Models\WyngesModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [WyngesDB];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_AlquilerDetallePelicula]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlquilerDetalleSet] DROP CONSTRAINT [FK_AlquilerDetallePelicula];
GO
IF OBJECT_ID(N'[dbo].[FK_AlquilerDetalleAlquiler]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlquilerDetalleSet] DROP CONSTRAINT [FK_AlquilerDetalleAlquiler];
GO
IF OBJECT_ID(N'[dbo].[FK_AlquilerCliente]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[AlquilerSet] DROP CONSTRAINT [FK_AlquilerCliente];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[ClienteSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[ClienteSet];
GO
IF OBJECT_ID(N'[dbo].[PeliculaSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[PeliculaSet];
GO
IF OBJECT_ID(N'[dbo].[AlquilerSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlquilerSet];
GO
IF OBJECT_ID(N'[dbo].[AlquilerDetalleSet]', 'U') IS NOT NULL
    DROP TABLE [dbo].[AlquilerDetalleSet];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'ClienteSet'
CREATE TABLE [dbo].[ClienteSet] (
    [ClienteId] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(50)  NOT NULL,
    [Telefono] nvarchar(15)  NOT NULL,
    [Direccion] nvarchar(150)  NOT NULL,
    [Correo] nvarchar(50)  NOT NULL,
    [Estado] nvarchar(1)  NOT NULL,
    [Clasificacion] nvarchar(14)  NOT NULL
);
GO

-- Creating table 'PeliculaSet'
CREATE TABLE [dbo].[PeliculaSet] (
    [PeliculaId] int IDENTITY(1,1) NOT NULL,
    [Nombre] nvarchar(40)  NOT NULL,
    [Genero] nvarchar(20)  NOT NULL,
    [Estado] nvarchar(1)  NOT NULL
);
GO

-- Creating table 'AlquilerSet'
CREATE TABLE [dbo].[AlquilerSet] (
    [AlquilerId] int IDENTITY(1,1) NOT NULL,
    [Fecha] datetime  NOT NULL,
    [Descuento] decimal(18,0)  NOT NULL,
    [SubTotal] decimal(18,0)  NOT NULL,
    [Impuesto] decimal(18,0)  NOT NULL,
    [Total] decimal(18,0)  NOT NULL,
    [Estado] nvarchar(12)  NOT NULL,
    [ClienteClienteId] int  NOT NULL
);
GO

-- Creating table 'AlquilerDetalleSet'
CREATE TABLE [dbo].[AlquilerDetalleSet] (
    [AlquilerDetalleId] int IDENTITY(1,1) NOT NULL,
    [Precio] decimal(18,0)  NOT NULL,
    [FechaDevolucion] nvarchar(max)  NOT NULL,
    [PeliculaPeliculaId] int  NOT NULL,
    [AlquilerAlquilerId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [ClienteId] in table 'ClienteSet'
ALTER TABLE [dbo].[ClienteSet]
ADD CONSTRAINT [PK_ClienteSet]
    PRIMARY KEY CLUSTERED ([ClienteId] ASC);
GO

-- Creating primary key on [PeliculaId] in table 'PeliculaSet'
ALTER TABLE [dbo].[PeliculaSet]
ADD CONSTRAINT [PK_PeliculaSet]
    PRIMARY KEY CLUSTERED ([PeliculaId] ASC);
GO

-- Creating primary key on [AlquilerId] in table 'AlquilerSet'
ALTER TABLE [dbo].[AlquilerSet]
ADD CONSTRAINT [PK_AlquilerSet]
    PRIMARY KEY CLUSTERED ([AlquilerId] ASC);
GO

-- Creating primary key on [AlquilerDetalleId] in table 'AlquilerDetalleSet'
ALTER TABLE [dbo].[AlquilerDetalleSet]
ADD CONSTRAINT [PK_AlquilerDetalleSet]
    PRIMARY KEY CLUSTERED ([AlquilerDetalleId] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [PeliculaPeliculaId] in table 'AlquilerDetalleSet'
ALTER TABLE [dbo].[AlquilerDetalleSet]
ADD CONSTRAINT [FK_AlquilerDetallePelicula]
    FOREIGN KEY ([PeliculaPeliculaId])
    REFERENCES [dbo].[PeliculaSet]
        ([PeliculaId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlquilerDetallePelicula'
CREATE INDEX [IX_FK_AlquilerDetallePelicula]
ON [dbo].[AlquilerDetalleSet]
    ([PeliculaPeliculaId]);
GO

-- Creating foreign key on [AlquilerAlquilerId] in table 'AlquilerDetalleSet'
ALTER TABLE [dbo].[AlquilerDetalleSet]
ADD CONSTRAINT [FK_AlquilerDetalleAlquiler]
    FOREIGN KEY ([AlquilerAlquilerId])
    REFERENCES [dbo].[AlquilerSet]
        ([AlquilerId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlquilerDetalleAlquiler'
CREATE INDEX [IX_FK_AlquilerDetalleAlquiler]
ON [dbo].[AlquilerDetalleSet]
    ([AlquilerAlquilerId]);
GO

-- Creating foreign key on [ClienteClienteId] in table 'AlquilerSet'
ALTER TABLE [dbo].[AlquilerSet]
ADD CONSTRAINT [FK_AlquilerCliente]
    FOREIGN KEY ([ClienteClienteId])
    REFERENCES [dbo].[ClienteSet]
        ([ClienteId])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_AlquilerCliente'
CREATE INDEX [IX_FK_AlquilerCliente]
ON [dbo].[AlquilerSet]
    ([ClienteClienteId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------