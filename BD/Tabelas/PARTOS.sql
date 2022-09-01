-- Table: public.partos

-- DROP TABLE IF EXISTS public.partos;

CREATE TABLE IF NOT EXISTS public.partos
(
    id_parto character varying(255) COLLATE pg_catalog."default" NOT NULL,
    id_bostaurus_mae character varying(255) COLLATE pg_catalog."default" NOT NULL,
    data_previsao_parto date,
    data_parto date,
    observacoes character varying(500) COLLATE pg_catalog."default",
    CONSTRAINT partos_pkey PRIMARY KEY (id_parto),
    CONSTRAINT fk_id_bostaurus_mae FOREIGN KEY (id_bostaurus_mae)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.partos
    OWNER to postgres;