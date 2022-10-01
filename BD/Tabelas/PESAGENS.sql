-- Table: public.pesagens

-- DROP TABLE IF EXISTS public.pesagens;

CREATE TABLE IF NOT EXISTS public.pesagens
(
    id_pesagem serial,
    id_bostaurus integer NOT NULL,
    data_pesagem date NOT NULL,
    peso numeric(10,3),
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
	
INSERT INTO public.pesagens(
	id_bostaurus, data_pesagem, peso)
	VALUES (1, '2022-08-01', '454.319');