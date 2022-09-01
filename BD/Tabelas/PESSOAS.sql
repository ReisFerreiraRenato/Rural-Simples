-- Table: public.pessoas

-- DROP TABLE IF EXISTS public.pessoas;

CREATE TABLE IF NOT EXISTS public.pessoas
(
    id_pessoa character varying(255) COLLATE pg_catalog."default" NOT NULL,
    cpf_cnpj character varying(18) COLLATE pg_catalog."default" NOT NULL,
    acesso_sistema character(1) COLLATE pg_catalog."default" NOT NULL,
    classificacao character(1) COLLATE pg_catalog."default" NOT NULL,
    data_nascimento_fundacao date,
    data_cadastro date,
    fantasia_fazenda character varying(255) COLLATE pg_catalog."default",
    inscricao_estadual character varying(255) COLLATE pg_catalog."default",
    inscricao_municipal character varying(255) COLLATE pg_catalog."default",
    login character varying(100) COLLATE pg_catalog."default",
    nome_razao_social character varying(255) COLLATE pg_catalog."default" NOT NULL,
    orgao_emissor character varying(100) COLLATE pg_catalog."default",
    rg character varying(100) COLLATE pg_catalog."default",
    senha character varying(50) COLLATE pg_catalog."default",
    tipo character(1) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT pessoas_pkey PRIMARY KEY (id_pessoa),
    CONSTRAINT pessoas_acessosistema_check CHECK (acesso_sistema = ANY (ARRAY['S'::bpchar, 'N'::bpchar])),
    CONSTRAINT pessoas_data_nascimento_fundacao_check CHECK (data_nascimento_fundacao > '1900-01-01'::date),
    CONSTRAINT pessoas_check CHECK (data_cadastro > data_nascimento_fundacao),
    CONSTRAINT pessoas_tipo_check CHECK (tipo = ANY (ARRAY['F'::bpchar, 'J'::bpchar])),
    CONSTRAINT pessoas_classificacao_check CHECK (classificacao = ANY (ARRAY['A'::bpchar, 'C'::bpchar, 'F'::bpchar, 'P'::bpchar, 'O'::bpchar, 'S'::bpchar, 'F'::bpchar]))
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.pessoas
    OWNER to postgres;