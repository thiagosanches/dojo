/****** Object:  Table [dbo].[Cartao]    Script Date: 25/03/2014 17:19:16 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Cartao](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Validade] [datetime] NOT NULL,
 CONSTRAINT [PK_Cartao] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO





/****** Object:  Table [dbo].[Conta]    Script Date: 25/03/2014 17:19:02 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Conta](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Saldo] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_Conta] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO



/****** Object:  Table [dbo].[Cliente]    Script Date: 25/03/2014 17:19:20 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Cliente](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](50) NOT NULL,
	[Sobrenome] [varchar](50) NULL,
	[Idade] [int] NOT NULL,
	[Cpf] [varchar](11) NOT NULL,
	[Rg] [varchar](11) NOT NULL,
	[IdCartao] [int] NOT NULL,
	[IdConta] [int] NOT NULL,
 CONSTRAINT [PK_Cliente] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Cartao] FOREIGN KEY([IdCartao])
REFERENCES [dbo].[Cartao] ([Id])
GO

ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Cartao]
GO

ALTER TABLE [dbo].[Cliente]  WITH CHECK ADD  CONSTRAINT [FK_Cliente_Conta] FOREIGN KEY([IdConta])
REFERENCES [dbo].[Conta] ([Id])
GO

ALTER TABLE [dbo].[Cliente] CHECK CONSTRAINT [FK_Cliente_Conta]
GO


