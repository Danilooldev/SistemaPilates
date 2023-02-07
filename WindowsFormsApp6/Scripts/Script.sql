CREATE PROCEDURE [dbo].[CancelarNotaDeSaida]
@Id BIGINT
AS BEGIN
	UPDATE [dbo].[Documento]
		SET 
			[Status] = 4
		WHERE Id = @id


		DECLARE @IdItem BIGINT

		-- Cursor para percorrer os registros
		DECLARE cursor1 CURSOR FOR
		--select codcliente, nome, sobrenome from clientes
		SELECT Id FROM ItemDocumento WHERE IdDocumento = @Id
 
		--Abrindo Cursor
		OPEN cursor1
 
		-- Lendo a próxima linha
		FETCH NEXT FROM cursor1 INTO @IdItem
 
		-- Percorrendo linhas do cursor (enquanto houverem)
		WHILE @@FETCH_STATUS = 0
		BEGIN
 
			UPDATE ItemDocumento SET Status = 4
			WHERE Id = @IdItem


		-- Lendo a próxima linha
		FETCH NEXT FROM cursor1 INTO @IdItem
		END
 
		-- Fechando Cursor para leitura
		CLOSE cursor1
 
		-- Finalizado o cursor
		DEALLOCATE cursor1
END

GO
/****** Object:  StoredProcedure [dbo].[SalvarCliente]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalvarCliente]

	@Id BIGINT,
	@Nome VARCHAR(MAX),
	@Cpf VARCHAR(MAX),
	@Endereco VARCHAR(MAX),
	@Numero VARCHAR(MAX),
	@Bairro VARCHAR(MAX),
	@Complemento VARCHAR(MAX),
	@Telefone VARCHAR(MAX),
	@Cidade BIGINT,
	@Fornecedor BIT,
	@Obs VARCHAR(MAX),
	@Ativo BIT
	


AS BEGIN

DECLARE @Return BIGINT;

	SET NOCOUNT ON;

	IF(@Id IS NULL OR @Id = 0)
	BEGIN
		INSERT INTO [dbo].[Cliente]
           ([Nome]
           ,[Cpf]
           ,[Endereco]
           ,[Numero]
           ,[Bairro]
           ,[Complemento]
           ,[Telefone]
           ,[Cidade]
           ,[Obs]
		   ,[Fornecedor]
		   ,[Ativo])
		VALUES
           (@Nome
           ,@Cpf
           ,@Endereco
           ,@Numero
           ,@Bairro
           ,@Complemento
           ,@Telefone
           ,@Cidade
           ,@Obs
		   ,@Fornecedor
		   ,@Ativo)

		  RETURN SCOPE_IDENTITY()
	END
	ELSE
	BEGIN
		UPDATE [dbo].[Cliente]
		   SET [Nome] = @Nome
			  ,[Cpf] = @Cpf
			  ,[Endereco] = @Endereco
			  ,[Numero] = @Numero
			  ,[Bairro] = @Bairro
			  ,[Complemento] = @Complemento
			  ,[Telefone] = @Telefone
			  ,[Cidade] = @Cidade
			  ,[Obs] = @Obs
			  ,[Fornecedor] = @Fornecedor
			  ,[Ativo] = @Ativo
		 WHERE Id = @Id
	END

	RETURN @Id

	END

	


GO
/****** Object:  StoredProcedure [dbo].[SalvarConfiguracoes]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalvarConfiguracoes]
@ValorFrete DECIMAL(11,2),
@PortaImpressora VARCHAR(MAX),
@MostrarExcluidos BIT

AS BEGIN

	IF((SELECT COUNT(ValorFrete) FROM Configuracoes) = 1 )
	BEGIN

		UPDATE [dbo].[Configuracoes]
			SET  ValorFrete = @ValorFrete
				,PortaImpressora = @PortaImpressora
				,MostrarExcluidos = @MostrarExcluidos
	 END
	 ELSE
		INSERT Configuracoes
		SELECT @ValorFrete, @PortaImpressora, @MostrarExcluidos
END






GO
/****** Object:  StoredProcedure [dbo].[SalvarItemMovimentacao]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalvarItemMovimentacao]
	@Id BIGINT,
	@IdDocumento BIGINT,
	@IdMercadoria BIGINT, 
	@Descricao VARCHAR(MAX),
	@Quantidade DECIMAL(11,2),
	@PrecoCusto DECIMAL(11,2),
	@PrecoVenda DECIMAL(11,2),
	@ValorTotal DECIMAL(11,2),
	@Operacao TINYINT,
	@Status TINYINT

AS BEGIN

	IF(@Id IS NULL OR @Id = 0)
	BEGIN	
		INSERT INTO [dbo].[ItemDocumento]
				   ([IdDocumento],[Descricao],[Quantidade],[PrecoCusto],[PrecoVenda],[ValorTotal],[Operacao], [IdMercadoria], [Status])
			 VALUES
				   (@IdDocumento,@Descricao,@Quantidade,@PrecoCusto,@PrecoVenda,@ValorTotal,@Operacao, @IdMercadoria, @Status)
	END
	ELSE
	BEGIN
	
		UPDATE [dbo].[ItemDocumento]
		   SET [IdDocumento] = @IdDocumento
			  ,[Descricao]   = @Descricao   
			  ,[Quantidade]  = @Quantidade
			  ,[PrecoCusto]  = @PrecoCusto
			  ,[PrecoVenda]  = @PrecoVenda
			  ,[ValorTotal]  = @ValorTotal
			  ,[Operacao]    = @Operacao
			  ,IdMercadoria  = @IdMercadoria
			  ,Status= @Status
		 WHERE Id = @Id

	END
END




GO
/****** Object:  StoredProcedure [dbo].[SalvarMercadoria]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SalvarMercadoria]

	@Id BIGINT,
	@Descricao VARCHAR(255),
	@Quantidade DECIMAL(11,2),
	@PrecoCusto	DECIMAL(11,2),
	@PrecoVenda	DECIMAL(11,2),
	@Ativo BIT

AS BEGIN

SET NOCOUNT ON;

	IF(@Id IS NULL OR @Id = 0)
	BEGIN
		INSERT INTO [dbo].[Mercadoria]
				   ([Nome]
				   ,[Quantidade]
				   ,[PrecoCusto]
				   ,[PrecoVenda]
				   ,[Ativo])
			 VALUES
				   (@Descricao
				   ,@Quantidade
				   ,@PrecoCusto
				   ,@PrecoVenda
				   ,@Ativo)

		RETURN SCOPE_IDENTITY()
	END

	ELSE
	BEGIN
		UPDATE [dbo].[Mercadoria]
		   SET [Nome]       = @Descricao
			  --,[Quantidade] = @Quantidade
			  ,[PrecoCusto] = @PrecoCusto
			  ,[PrecoVenda] = @PrecoVenda
			  ,[Ativo] = @Ativo
		 WHERE Id = @Id
		 	 
	END

	RETURN @Id

	END



GO
/****** Object:  StoredProcedure [dbo].[SalvarMovimentacao]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE  PROCEDURE [dbo].[SalvarMovimentacao]
@Id BIGINT,
@Descricao VARCHAR(MAX),
@IdParceiro BIGINT,
@Data DATETIME,
@Status TINYINT,
@Operacao TINYINT,
@DescAcres DECIMAL(11,2),
@ValorTotal DECIMAL(11,2),
@ValorLiquidoTotal DECIMAL(11,2),
@NumeroNota VARCHAR(MAX),
@Frete DECIMAL(11,2)

AS BEGIN
	IF(@Id IS NULL OR @Id = 0)
	BEGIN
		INSERT INTO [dbo].[Documento]
				   ([Descricao],[IdParceiro],[Data],[Status],[Operacao],[DescAcres],[ValorTotal],[NumeroNota], [Frete])
			 VALUES
				   (@Descricao, @IdParceiro, @Data, @Status, @Operacao, @DescAcres, @ValorTotal, @NumeroNota, @Frete )

		  RETURN SCOPE_IDENTITY()
	END
	ELSE
	BEGIN

		UPDATE [dbo].[Documento]
		   SET [Descricao]  = @Descricao
			  ,[IdParceiro] = @IdParceiro
			  ,[Data] = 	  @Data
			  ,[Status] =	  @Status
			  ,[Operacao] =	  @Operacao
			  ,[DescAcres] =  @DescAcres
			  ,[ValorTotal] = @ValorTotal
			  ,[NumeroNota] = @NumeroNota
			  ,[Frete]		= @Frete 
		 WHERE Id = @id

	END
	RETURN @Id
END





GO
/****** Object:  Table [dbo].[Cidade]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cidade](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](max) NOT NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Cliente](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](max) NOT NULL,
	[Cpf] [varchar](max) NOT NULL,
	[Endereco] [varchar](max) NOT NULL,
	[Numero] [varchar](max) NOT NULL,
	[Bairro] [varchar](max) NOT NULL,
	[Complemento] [varchar](max) NULL,
	[Telefone] [varchar](max) NULL,
	[Cidade] [bigint] NOT NULL,
	[Obs] [varchar](max) NULL,
	[Fornecedor] [bit] NOT NULL DEFAULT ((0)),
	[Ativo] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Configuracoes]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Configuracoes](
	[ValorFrete] [decimal](11, 2) NOT NULL,
	[PortaImpressora] [varchar](max) NOT NULL,
	[MostrarExcluidos] [bit] NOT NULL DEFAULT ((0))
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Documento]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Documento](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Descricao] [varchar](max) NOT NULL,
	[IdParceiro] [bigint] NOT NULL,
	[Data] [datetime] NOT NULL,
	[Status] [tinyint] NOT NULL,
	[Operacao] [tinyint] NOT NULL,
	[DescAcres] [decimal](11, 2) NOT NULL,
	[ValorTotal] [decimal](11, 2) NOT NULL,
	[NumeroNota] [varchar](max) NOT NULL,
	[ValorLiquidoTotal]  AS ([ValorTotal]+[DescAcres]),
	[Frete] [decimal](11, 2) NOT NULL DEFAULT ((0)),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[ItemDocumento]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[ItemDocumento](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[IdDocumento] [bigint] NOT NULL,
	[Descricao] [varchar](max) NOT NULL,
	[Quantidade] [decimal](11, 2) NOT NULL,
	[PrecoCusto] [decimal](11, 2) NOT NULL,
	[PrecoVenda] [decimal](11, 2) NOT NULL,
	[ValorTotal] [decimal](11, 2) NOT NULL,
	[Operacao] [tinyint] NOT NULL,
	[IdMercadoria] [bigint] NOT NULL,
	[Status] [tinyint] NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Mercadoria]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Mercadoria](
	[Id] [bigint] IDENTITY(1,1) NOT NULL,
	[Nome] [varchar](255) NOT NULL,
	[Quantidade] [decimal](11, 2) NOT NULL,
	[PrecoCusto] [decimal](11, 2) NOT NULL,
	[PrecoVenda] [decimal](11, 2) NOT NULL,
	[Ativo] [bit] NOT NULL DEFAULT ((1)),
PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
 CONSTRAINT [UQ_Mercadoria] UNIQUE NONCLUSTERED 
(
	[Nome] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET ANSI_PADDING OFF
GO
/****** Object:  UserDefinedFunction [dbo].[ConsultaNotas]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ConsultaNotas](@Operacao TINYINT, @Status TINYINT)
RETURNS TABLE AS RETURN
SELECT [Id]
      ,[Descricao]
      ,[IdParceiro]
      ,[Data]
      ,[Status]
      ,[Operacao]
      ,[DescAcres]
      ,[ValorTotal]
      ,[NumeroNota]
	  ,[ValorLiquidoTotal]
  FROM [dbo].[Documento]
  WHERE (@Status = 1 AND Status = 1
	 OR (@Status = 2 AND Status= 2)
	 OR (@Status = 4 AND Status= 4)
	 OR (@Status = 7)) AND Operacao = @Operacao





GO
/****** Object:  UserDefinedFunction [dbo].[ConsultaNotasPorPeriodo]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ConsultaNotasPorPeriodo]
(
	@Operacao TINYINT,
	@Status TINYINT, 
	@inicio VARCHAR(MAX), 
	@fim VARCHAR(MAX)
)
RETURNS TABLE AS RETURN
SELECT
	doc.Id,
	cli.Nome,
	doc.Data,
	doc.ValorLiquidoTotal

  FROM [dbo].[Documento] doc
  INNER JOIN Cliente cli
  ON cli.id = doc.IdParceiro
  WHERE
	Data BETWEEN @inicio AND @fim
	AND (@Status = 1 AND Status = 1
	 OR (@Status = 2 AND Status= 2)
	 OR (@Status = 4 AND Status= 4)
	 OR (@Status = 7)) AND Operacao = @Operacao





GO
/****** Object:  UserDefinedFunction [dbo].[ConsultarCliente]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ConsultarCliente] ()
RETURNS TABLE AS RETURN
SELECT [Id]
      ,[Nome]
      ,[Cpf]
      ,[Endereco]
      ,[Numero]
      ,[Bairro]
      ,[Complemento]
      ,[Telefone]
      ,[Cidade]
      ,[Obs]
	  ,[Fornecedor]
	  ,[Ativo]
  FROM [dbo].[Cliente]
  WHERE Ativo = 1 OR 1 = (SELECT MostrarExcluidos FROM Configuracoes)

/*
@Ativo TINYINT
@Ativo = 1 AND Ativo = 1
			AND ((@ApenasUnitarios = 1 AND mer.Unidade = 2) OR @ApenasUnitarios = 0)
			OR (@Ativo = 2 AND Ativo = 0)
			OR (@Ativo = 4)*/

GO
/****** Object:  UserDefinedFunction [dbo].[ConsultarConfiguracoes]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ConsultarConfiguracoes]()
RETURNS TABLE AS RETURN
SELECT [ValorFrete]
      ,[PortaImpressora]
	  ,[MostrarExcluidos]
  FROM [dbo].[Configuracoes]




GO
/****** Object:  UserDefinedFunction [dbo].[ConsultarMercadoria]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ConsultarMercadoria] ()
RETURNS TABLE AS RETURN
SELECT [Id]
      ,Nome as Descricao
      ,[Quantidade]
      ,[PrecoCusto]
      ,[PrecoVenda]
	  ,[Ativo]
  FROM [dbo].[Mercadoria]
   WHERE Ativo = 1 OR 1 = (SELECT MostrarExcluidos FROM Configuracoes)





GO
/****** Object:  UserDefinedFunction [dbo].[ListaMercadoriasNotas]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ListaMercadoriasNotas](@idDocumento BIGINT, @Operacao TINYINT, @Status TINYINT)
RETURNS TABLE AS RETURN
SELECT [Id]
      ,[IdDocumento]
      ,[Descricao]
      ,[Quantidade]
      ,[PrecoCusto]
      ,[PrecoVenda]
      ,[ValorTotal]
      ,[Operacao]
      ,[IdMercadoria]
      ,[Status]
  FROM [dbo].[ItemDocumento]
 WHERE (@Status = 1 AND Status = 1
	 OR (@Status = 0 AND Status= 0)
	 OR (@Status = 7)) AND IdDocumento = @idDocumento



GO
/****** Object:  UserDefinedFunction [dbo].[ListarNotasPorCliente]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ListarNotasPorCliente] (@IdCliente BIGINT)
RETURNS TABLE AS RETURN
SELECT 
doc.Id,
doc.NumeroNota Nota,
CONVERT(DATE, doc.Data) Data,
doc.Operacao

FROM Mercadoria merc
INNER JOIN ItemDocumento item
ON item.IdMercadoria  = merc.Id
INNER JOIN Documento doc
ON doc.Id = item.IdDocumento
WHERE doc.Status = 2
AND item.IdMercadoria = @IdCliente
GROUP BY doc.Id, doc.NumeroNota,
doc.Data, doc.Operacao


GO
/****** Object:  UserDefinedFunction [dbo].[ListarNotasPorMercadoria]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[ListarNotasPorMercadoria] (@IdMercadoria BIGINT)
RETURNS TABLE AS RETURN
SELECT 
doc.Id,
doc.NumeroNota Nota,
CONVERT(DATE, doc.Data) Data

FROM Mercadoria merc
INNER JOIN ItemDocumento item
ON item.IdMercadoria  = merc.Id
INNER JOIN Documento doc
ON doc.Id = item.IdDocumento
WHERE doc.Status = 2 AND doc.Operacao = 1
AND item.IdMercadoria = @IdMercadoria
GROUP BY doc.Id, doc.NumeroNota, doc.Data


GO
/****** Object:  UserDefinedFunction [dbo].[Relatorio01_ListaClientes]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--select * from Cliente WHERE Ativo 

CREATE FUNCTION [dbo].[Relatorio01_ListaClientes]
(
	@Ativo TINYINT,
	@Fornecedor TINYINT
)
RETURNS TABLE AS RETURN
SELECT cli.Id
      ,cli.Nome
      ,cli.Cpf
      ,cli.Endereco
      ,cli.Numero
      ,cli.Bairro
      ,cli.Complemento
      ,cli.Telefone
      ,cid.Nome Cidade
      ,cli.Obs
	  ,cli.Fornecedor
	  ,cli.Ativo
  FROM [dbo].[Cliente] cli
  INNER JOIN Cidade cid 
  ON cid.Id = cli.Cidade

  WHERE 
       (Ativo = @Ativo OR @Ativo = 4)
	   AND (Fornecedor = @Fornecedor OR @Fornecedor = 4)
   
	

GO
/****** Object:  UserDefinedFunction [dbo].[Relatorio02_EstoqueMercadorias]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[Relatorio02_EstoqueMercadorias](@Ativo BIT)
RETURNS TABLE AS RETURN
SELECT [Id]
      ,[Nome]
      ,[Quantidade]
      ,[PrecoCusto]
      ,[PrecoVenda]
      ,[Ativo]
  FROM [dbo].[Mercadoria]
  WHERE 
   (Ativo = @Ativo OR @Ativo = 4)

  

GO
/****** Object:  UserDefinedFunction [dbo].[Relatorio03_ListaNotasDeEntradaComItens]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[Relatorio03_ListaNotasDeEntradaComItens]
(
	@Inicio VARCHAR(MAX), @Fim VARCHAR(MAX)
)
RETURNS TABLE AS RETURN
SELECT
doc.Id,
doc.Descricao DescricaoNota,
pn.Nome Fornecedor,
CONVERT(DATE, doc.Data) Data,
doc.ValorLiquidoTotal,
item.Descricao Mercadoria,
item.PrecoVenda,
item.PrecoCusto,
item.Quantidade,
doc.DescAcres,
doc.ValorTotal
FROM Documento doc
INNER JOIN ItemDocumento item
ON item.IdDocumento = doc.Id
INNER JOIN Cliente pn
ON pn.id = doc.IdParceiro
WHERE doc.Data BETWEEN @Inicio AND @Fim
AND doc.Operacao = 1 AND doc.Status = 2

GO
/****** Object:  UserDefinedFunction [dbo].[Relatorio04_VendaMercadoriaPorPeriodo]    Script Date: 17/10/2022 14:16:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE FUNCTION [dbo].[Relatorio04_VendaMercadoriaPorPeriodo]
(
	@Inicio VARCHAR(MAX), @Fim VARCHAR(MAX)
)
RETURNS TABLE AS RETURN
select 
mer.Nome,
item.PrecoVenda,
sum(item.Quantidade) Quantidade,
sum(item.ValorTotal) Valor,
sum(doc.ValorLiquidoTotal) ValorTotal,
CONVERT(DATE, doc.Data) Data,
doc.Frete
from ItemDocumento item
INNER JOIN Mercadoria mer
ON item.IdMercadoria = mer.Id
INNER JOIN Documento doc
ON doc.Id = item.IdDocumento
WHERE doc.Data BETWEEN @Inicio AND @Fim
AND doc.Operacao = 2 AND doc.Status = 2
group by mer.Nome, CONVERT(DATE, doc.Data), item.PrecoVenda, doc.Frete




GO
ALTER TABLE [dbo].[Documento]  WITH CHECK ADD  CONSTRAINT [FK_Parceiro] FOREIGN KEY([IdParceiro])
REFERENCES [dbo].[Cliente] ([Id])
GO
ALTER TABLE [dbo].[Documento] CHECK CONSTRAINT [FK_Parceiro]
GO
ALTER TABLE [dbo].[ItemDocumento]  WITH CHECK ADD  CONSTRAINT [FK_Documento] FOREIGN KEY([IdDocumento])
REFERENCES [dbo].[Documento] ([Id])
GO
ALTER TABLE [dbo].[ItemDocumento] CHECK CONSTRAINT [FK_Documento]
GO
ALTER TABLE [dbo].[ItemDocumento]  WITH CHECK ADD  CONSTRAINT [FK_MercadoriaEntrada] FOREIGN KEY([IdMercadoria])
REFERENCES [dbo].[Mercadoria] ([Id])
GO
ALTER TABLE [dbo].[ItemDocumento] CHECK CONSTRAINT [FK_MercadoriaEntrada]
GO





CREATE TRIGGER [dbo].[TG_AtualizarMercadoriaProcessada_AI]
ON [dbo].[ItemDocumento] FOR INSERT AS BEGIN
    DECLARE
	@Id BIGINT,
	@Operacao TINYINT,
	@Status TINYINT,
	@Quantidade DECIMAL(11,2),
	@PrecoCusto	DECIMAL(11,2),
	@PrecoVenda	DECIMAL(11,2)

	SELECT 
		@Quantidade = [Quantidade]
       ,@PrecoCusto = [PrecoCusto]
       ,@PrecoVenda = [PrecoVenda]
       ,@Operacao   = [Operacao]
       ,@Id         = [IdMercadoria]
       ,@Status     = [Status]
    FROM INSERTED

	-- ENTRADAS
	IF(@Operacao = 1 AND @Status = 2) 
	BEGIN

		UPDATE [dbo].[Mercadoria]
			SET 
				[Quantidade] += @Quantidade
			   ,[PrecoCusto] = @PrecoCusto
			   ,[PrecoVenda] = @PrecoVenda
				WHERE Id = @Id
	END
	ELSE IF(@Operacao = 1 AND @Status = 4)
	BEGIN
		UPDATE [dbo].[Mercadoria]
			SET 
				[Quantidade] -= @Quantidade
			   ,[PrecoCusto] = @PrecoCusto
			   ,[PrecoVenda] = @PrecoVenda
				WHERE Id = @Id
	END


	-- SAÍDAS
	ELSE IF(@Operacao = 2 AND @Status = 2)
	BEGIN
		UPDATE [dbo].[Mercadoria]
			SET 
				[Quantidade] -= @Quantidade
			   ,[PrecoCusto] = @PrecoCusto
			   ,[PrecoVenda] = @PrecoVenda
				WHERE Id = @Id
	END
	ELSE IF(@Operacao = 2 AND @Status = 4)
	BEGIN
		UPDATE [dbo].[Mercadoria]
			SET 
				[Quantidade] += @Quantidade
			   ,[PrecoCusto] = @PrecoCusto
			   ,[PrecoVenda] = @PrecoVenda
				WHERE Id = @Id
	END
END

GO

CREATE TRIGGER [dbo].[TG_AtualizarMercadoriaProcessada_AU]
ON [dbo].[ItemDocumento] FOR UPDATE AS BEGIN
    DECLARE
	@Id BIGINT,
	@Operacao TINYINT,
	@Status TINYINT,
	@Quantidade DECIMAL(11,2),
	@PrecoCusto	DECIMAL(11,2),
	@PrecoVenda	DECIMAL(11,2)

 
 SELECT 
       @Quantidade = [Quantidade]
      ,@PrecoCusto = [PrecoCusto]
      ,@PrecoVenda = [PrecoVenda]
      ,@Operacao   = [Operacao]
      ,@Id         = [IdMercadoria]
      ,@Status     = [Status]
  FROM INSERTED

	-- ENTRADAS
	IF(@Operacao = 1 AND @Status = 2) 
	BEGIN

		UPDATE [dbo].[Mercadoria]
			SET 
				[Quantidade] += @Quantidade
			   ,[PrecoCusto] = @PrecoCusto
			   ,[PrecoVenda] = @PrecoVenda
				WHERE Id = @Id
	END
	ELSE IF(@Operacao = 1 AND @Status = 4)
	BEGIN
		UPDATE [dbo].[Mercadoria]
			SET 
				[Quantidade] -= @Quantidade
			   ,[PrecoCusto] = @PrecoCusto
			   ,[PrecoVenda] = @PrecoVenda
				WHERE Id = @Id
	END


	-- SAÍDAS
	ELSE IF(@Operacao = 2 AND @Status = 2)
	BEGIN
		UPDATE [dbo].[Mercadoria]
			SET 
				[Quantidade] -= @Quantidade
			   ,[PrecoCusto] = @PrecoCusto
			   ,[PrecoVenda] = @PrecoVenda
				WHERE Id = @Id
	END
	ELSE IF(@Operacao = 2 AND @Status = 4)
	BEGIN
		UPDATE [dbo].[Mercadoria]
			SET 
				[Quantidade] += @Quantidade
			   ,[PrecoCusto] = @PrecoCusto
			   ,[PrecoVenda] = @PrecoVenda
				WHERE Id = @Id
	END
END

GO

insert configuracoes
select 0,'LPT1', 0

GO

insert cidade
select 'Assai'
insert cidade
select 'São Sebastião da Amoreira'
insert cidade
select 'Santa Cecilia do Pavao'
insert cidade
select 'Nova Santa Bárbara'
insert cidade
select 'Jataizinho'
insert cidade
select 'São Jeronimo da Serra'
insert cidade
select 'Sapopema'
insert cidade
select 'Londrina'
insert cidade
select 'Cambe'