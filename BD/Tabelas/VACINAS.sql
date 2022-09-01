-- Table: public.vacinas

-- DROP TABLE IF EXISTS public.vacinas;

CREATE TABLE IF NOT EXISTS public.vacinas
(
    id_vacina character varying(255) COLLATE pg_catalog."default" NOT NULL,
	id_bostaurus character varying(255) COLLATE pg_catalog."default" NOT NULL,
    nome_vacina character varying(255) COLLATE pg_catalog."default" NOT NULL,
    data_aplicacao_vacina date NOT NULL,
    CONSTRAINT vacinas_pkey PRIMARY KEY (id_vacina),
    CONSTRAINT fk_id_bostaurus FOREIGN KEY (id_bostaurus)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.vacinas
    OWNER to postgres;