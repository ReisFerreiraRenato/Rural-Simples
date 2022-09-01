-- Table: public.vermifugacoes

-- DROP TABLE IF EXISTS public.vermifugacoes;

CREATE TABLE IF NOT EXISTS public.vermifugacoes
(
    id_vermifugacao character varying(255) COLLATE pg_catalog."default" NOT NULL,
    id_bostaurus character varying(255) COLLATE pg_catalog."default" NOT NULL,
    data_aplicacao_vermifugo date NOT NULL,
    nome_vermifugo character varying(255) COLLATE pg_catalog."default" NOT NULL,
    CONSTRAINT vermifugacoes_pkey PRIMARY KEY (id_vermifugacao),
    CONSTRAINT fk_id_bostaurus FOREIGN KEY (id_bostaurus)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.vermifugacoes
    OWNER to postgres;