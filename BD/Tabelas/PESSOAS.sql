-- Table: public.pessoas

-- DROP TABLE IF EXISTS public.pessoas;

CREATE TABLE IF NOT EXISTS public.pessoas
(
	id_pessoa serial,
	cpf	character varying(14) COLLATE pg_catalog."default",
	cnpj character varying(18) COLLATE pg_catalog."default",
	cei character varying(20) COLLATE pg_catalog."default",
	acesso_sistema character(1) COLLATE pg_catalog."default" NOT NULL DEFAULT 'N'::character(1),
	classificacao character(1) COLLATE pg_catalog."default" NOT NULL DEFAULT 'C'::character(1),
	data_nascimento_fundacao 	date NOT NULL,
	data_cadastro date NOT NULL,
	inativo character(1) NOT NULL DEFAULT 'N'::character(1),
	inscricao_estadual character varying(255) COLLATE pg_catalog."default",
	inscricao_municipal character varying(255) COLLATE pg_catalog."default",
	login character varying(100) COLLATE pg_catalog."default",
	nome_razao_social character varying(255) COLLATE pg_catalog."default" NOT NULL,
	nome_fantasia character varying(255) COLLATE pg_catalog."default",
	nome_fazenda character varying(255) COLLATE pg_catalog."default",
	orgao_expedidor character varying(100) COLLATE pg_catalog."default",
	rg character varying(100) COLLATE pg_catalog."default",
	senha character varying(50) COLLATE pg_catalog."default",
	tipo_pessoa character(1) COLLATE pg_catalog."default" NOT NULL,
	uf_orgao_expedidor character varying(2) COLLATE pg_catalog."default",
	observacoes character varying(255) COLLATE pg_catalog."default",
	
  CONSTRAINT pessoas_pkey PRIMARY KEY (id_pessoa),
	CONSTRAINT pessoas_inativo CHECK (inativo = ANY (ARRAY['S'::bpchar, 'N'::bpchar])),
  CONSTRAINT pessoas_acessosistema_check CHECK (acesso_sistema = ANY (ARRAY['S'::bpchar, 'N'::bpchar])),
  CONSTRAINT pessoas_data_nascimento_fundacao_check CHECK (data_nascimento_fundacao > '1900-01-01'::date),
  CONSTRAINT pessoas_check CHECK (data_cadastro >= data_nascimento_fundacao),
  CONSTRAINT pessoas_tipo_pessoa_check CHECK (tipo_pessoa = ANY (ARRAY['F'::bpchar, 'J'::bpchar])),
  CONSTRAINT pessoas_classificacao_check CHECK (classificacao = ANY (ARRAY['A'::bpchar, 'C'::bpchar, 'F'::bpchar, 'P'::bpchar, 'O'::bpchar, 'S'::bpchar, 'F'::bpchar])),
	CONSTRAINT pessoas_inativo_check CHECK (inativo = ANY (ARRAY['S'::bpchar, 'N'::bpchar]))
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.pessoas
    OWNER to postgres;
	
INSERT INTO public.pessoas(
	cpf, cnpj, acesso_sistema, classificacao, data_nascimento_fundacao, data_cadastro, nome_fazenda, inativo, inscricao_estadual, inscricao_municipal, login, nome_razao_social, nome_fantasia, orgao_expedidor, rg, senha, tipo_pessoa, uf_orgao_expedidor)
	VALUES ('123.456.789-00', NULL, 'S', 'A', '2022-01-01', '2022-01-09', 'FAZENDA TESTE', 'N', NULL, NULL, 'ADM', 'USER_MASTER', 'NOME_FANTASIA_TESTE', 'SSP', 'RG 123456', '123', 'F', 'TO');