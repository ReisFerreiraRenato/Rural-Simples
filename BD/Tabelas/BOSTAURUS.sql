-- Table: public.bostaurus

-- DROP TABLE IF EXISTS public.bostaurus;

CREATE TABLE IF NOT EXISTS public.bostaurus
(
    id_bostaurus character varying(255) COLLATE pg_catalog."default" NOT NULL,
	id_pessoa character varying(255) COLLATE pg_catalog."default",
    id_bostaurus_pai character varying(255) COLLATE pg_catalog."default",
    id_bostaurus_mae character varying(255) COLLATE pg_catalog."default",
    nome_pai character varying(255) COLLATE pg_catalog."default",
    nome_mae character varying(255) COLLATE pg_catalog."default",
    aptidao "char",
    identificacao character varying(255) COLLATE pg_catalog."default",
    numero_registro character varying(255) COLLATE pg_catalog."default",
    sexo "char",
    classificacao_ossea character varying(255) COLLATE pg_catalog."default",
    classificacao_patas character varying(255) COLLATE pg_catalog."default",
    data_cadastro date,
    data_nascimento date,
    familia character varying(255) COLLATE pg_catalog."default",
    grupo character varying(255) COLLATE pg_catalog."default",
    nome_cientifico character varying(255) COLLATE pg_catalog."default",
    nome character varying(255) COLLATE pg_catalog."default",
    raca character varying(255) COLLATE pg_catalog."default",
    tipo_reproducao "char",
    CONSTRAINT bostaurus_pkey PRIMARY KEY (id_bostaurus),
    CONSTRAINT fk_id_bostaurus_mae FOREIGN KEY (id_bostaurus_mae)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT fk_id_bostaurus_pai FOREIGN KEY (id_bostaurus_pai)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT fk_id_pessoa FOREIGN KEY (id_pessoa)
        REFERENCES public.pessoas (id_pessoa) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.bostaurus
    OWNER to postgres;