-- Table: public.vacinas

-- DROP TABLE IF EXISTS public.vacinas;

CREATE TABLE IF NOT EXISTS public.vacinas
(
  	id_vacina integer NOT NULL DEFAULT nextval('vacinas_id_vacina_seq'::regclass),
    id_animal integer NOT NULL,
    nome_vacina character varying(255) COLLATE pg_catalog."default" NOT NULL,
    dosagem numeric(10,3),
    data_vacinacao date NOT NULL,
    data_cadastro date,
    CONSTRAINT vacinas_pkey PRIMARY KEY (id_vacina),
    CONSTRAINT fk_id_bostaurus FOREIGN KEY (id_animal)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.vacinas
    OWNER to postgres;

INSERT INTO public.vacinas(
	id_bostaurus, nome_vacina, dosagem, data_aplicacao_vacina, data_cadastro)
	VALUES (1, 'VACINA DE TESTE', 5, '2022-09-01', '2022-10-01');