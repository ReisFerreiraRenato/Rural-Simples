-- Table: public.vermifugacoes

-- DROP TABLE IF EXISTS public.vermifugacoes;

CREATE TABLE IF NOT EXISTS public.vermifugacoes
(
    id_vermifugacao serial,
    id_bostaurus integer NOT NULL,
    data_aplicacao_vermifugo date NOT NULL,
    nome_vermifugo character varying(255) COLLATE pg_catalog."default" NOT NULL,
		dosagem numeric(10,3),
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
	
INSERT INTO public.vermifugacoes(
	id_bostaurus, data_aplicacao_vermifugo, nome_vermifugo, dosagem)
	VALUES (1, '2022-09-01', 'VERMIFUGO DE TESTE', 5);