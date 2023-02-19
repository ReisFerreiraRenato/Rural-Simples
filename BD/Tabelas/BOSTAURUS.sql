-- Table: public.bostaurus

-- DROP TABLE IF EXISTS public.bostaurus;

CREATE TABLE IF NOT EXISTS public.bostaurus
(
    id_bostaurus serial,
	id_pessoa integer NOT NULL, --Para veincular a uma pessoa ou propriedade
    id_bostaurus_pai integer,
    id_bostaurus_mae integer,
    nome_pai character varying(255) COLLATE pg_catalog."default",
    nome_mae character varying(255) COLLATE pg_catalog."default",
    aptidao character varying(100) COLLATE pg_catalog."default",
		ciclo character varying(1) COLLATE pg_catalog."default",
		ciclo_reprodutivo character varying(1) COLLATE pg_catalog."default",
    identificacao character varying(255) COLLATE pg_catalog."default",
    numero_registro character varying(255) COLLATE pg_catalog."default",
    sexo character varying(1) COLLATE pg_catalog."default",
    classificacao_ossea character varying(255) COLLATE pg_catalog."default",
    classificacao_patas character varying(255) COLLATE pg_catalog."default",
    data_cadastro date,
    data_nascimento date,
    familia character varying(255) COLLATE pg_catalog."default",
    grupo character varying(255) COLLATE pg_catalog."default",
    nome_cientifico character varying(255) COLLATE pg_catalog."default",
    nome_animal character varying(255) COLLATE pg_catalog."default",
    raca character varying(255) COLLATE pg_catalog."default",
    tipo_reproducao character varying(20) COLLATE pg_catalog."default",
	inativo character varying(1) NOT NULL DEFAULT 'N'::character(1),
	data_descarte date,
    motivo_descarte character varying(100) COLLATE pg_catalog."default",
	observacoes_bostaurus character varying(255) COLLATE pg_catalog."default",
    CONSTRAINT bostaurus_pkey PRIMARY KEY (id_bostaurus),
		CONSTRAINT bostaurus_inativo CHECK (inativo = ANY (ARRAY['S'::bpchar, 'N'::bpchar])),
		CONSTRAINT bostaurus_ciclo CHECK (ciclo = ANY (ARRAY['A'::bpchar, 'B'::bpchar, 'C'::bpchar, 'E'::bpchar, 'R'::bpchar])),
		CONSTRAINT bostaurus_ciclo_reprodutivo CHECK (ciclo_reprodutivo = ANY (ARRAY['M'::bpchar, 'N'::bpchar, 'P'::bpchar, 'S'::bpchar, 'N'::bpchar])),
    CONSTRAINT fk_id_bostaurus_mae FOREIGN KEY (id_bostaurus_mae)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT fk_id_bostaurus_pai FOREIGN KEY (id_bostaurus_pai)
        REFERENCES public.bostaurus (id_bostaurus) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID,
    CONSTRAINT fk_id_pessoa FOREIGN KEY (id_pessoa)
        REFERENCES public.pessoas (id_pessoa) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE NO ACTION
        NOT VALID
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.bostaurus
    OWNER to postgres;
	
INSERT INTO public.bostaurus(
	id_pessoa, id_bostaurus_pai, id_bostaurus_mae, nome_pai, nome_mae, aptidao, identificacao, numero_registro, sexo, classificacao_ossea, classificacao_patas, data_cadastro, data_nascimento, familia, grupo, nome_cientifico, nome_animal, raca, tipo_reproducao, ciclo)
	VALUES (1, NULL, NULL, 'BOI TESTE', 'VACA TESTE', 'C', '2350012', NULL, 'M', 'VERTEBRADO', 'QUADRUPEDE', '2022-09-01', '2017-09-01', NULL, NULL, NULL, NULL, 'BOI TESTE', 'SEXUADA', 'BEZERRO');
	