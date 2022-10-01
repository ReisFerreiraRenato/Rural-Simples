-- Table: public.estacoes_monta

-- DROP TABLE IF EXISTS public.estacoes_monta;

CREATE TABLE IF NOT EXISTS public.estacoes_monta
(
    id_estacao_monta serial,
    id_bostaurus_mae integer NOT NULL,
    data_inseminacao date NOT NULL,
    id_bostaurus_pai integer,
    identificacao_pai character varying(255) COLLATE pg_catalog."default", 
    data_toque date NOT NULL,
    prenha "char",
    CONSTRAINT estacoes_monta_pkey PRIMARY KEY (id_estacao_monta),
    CONSTRAINT "fk_Id_bostauros_pai" FOREIGN KEY (id_bostaurus_pai)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT fk_id_bostaurus_mae FOREIGN KEY (id_bostaurus_mae)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.estacoes_monta
    OWNER to postgres;
	
INSERT INTO public.estacoes_monta(
	id_bostaurus_mae, data_inseminacao, id_bostaurus_pai, identificacao_pai, data_toque, prenha)
	VALUES (1, '2022-08-01', '1', 'BOI TESTE ESTACAO', '2022-09-01', 'S');