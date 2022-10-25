-- Table: public.vacinas

-- DROP TABLE IF EXISTS public.propriedades_pessoas;

CREATE TABLE IF NOT EXISTS public.propriedades_pessoas
(
  id_propriedade_pessoa SERIAL,
  id_pessoa INTEGER NOT NULL,
	id_propriedade INTEGER NOT NULL,
	participacao_societaria INTEGER,
    CONSTRAINT vacinas_pkey PRIMARY KEY (id_propriedade_pessoa),
    CONSTRAINT fk_id_pessoa FOREIGN KEY (id_pessoa)
        REFERENCES public.pessoas (id_pessoa) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
				NOT VALID,
		CONSTRAINT fk_id_propriedade FOREIGN KEY (id_propriedade)
        REFERENCES public.propriedades (id_propriedade) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
				NOT VALID	
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.propriedades_pessoas
    OWNER to postgres;

INSERT INTO public.propriedades_pessoas(
	id_pessoa, id_propriedade, participacao_societaria)
	VALUES (1, 1, 100);