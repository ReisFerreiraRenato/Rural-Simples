-- Table: public.vacinas

-- DROP TABLE IF EXISTS public.vacinas;

CREATE TABLE IF NOT EXISTS public.vacinas
(
  id_vacina serial,
	id_bostaurus integer NOT NULL,
  nome_vacina character varying(255) COLLATE pg_catalog."default" NOT NULL,
	dosagem numeric(10,3),
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

INSERT INTO public.vacinas(
	id_bostaurus, nome_vacina, dosagem, data_aplicacao_vacina)
	VALUES (1, 'VACINA DE TESTE', 5, '2022-09-01');