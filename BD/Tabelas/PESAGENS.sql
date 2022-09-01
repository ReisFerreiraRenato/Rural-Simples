-- Table: public.pesagens

-- DROP TABLE IF EXISTS public.pesagens;

CREATE TABLE IF NOT EXISTS public.pesagens
(
    id_pesagem character varying(255) COLLATE pg_catalog."default" NOT NULL,
    id_bostaurus character varying(255) COLLATE pg_catalog."default" NOT NULL,
    data_pesagem date NOT NULL,
    peso numeric,
    CONSTRAINT pesagens_pkey PRIMARY KEY (id_pesagem),
    CONSTRAINT fk_id_bos_taurus FOREIGN KEY (id_bostaurus)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.pesagens
    OWNER to postgres;