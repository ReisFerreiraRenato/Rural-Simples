-- Table: public.pessoas

-- DROP TABLE IF EXISTS public.pessoas;

CREATE TABLE IF NOT EXISTS public.propriedades
(
	id_propriedade serial,
	
	--Caracterísitcas da propriedades
	aptidao character varying(255) COLLATE pg_catalog."default",
	area_produtiva numeric(10,2),
	area_reserva numeric(10,2),
	area_total numeric(10,2),
	car character varying(255) COLLATE pg_catalog."default",
	data_aquisicao date NOT NULL,
	data_venda date,
	escritura character varying(255) COLLATE pg_catalog."default",
	inativa character varying(1) COLLATE pg_catalog."default",
	itr character varying(255) COLLATE pg_catalog."default",
	latitude character varying(50) COLLATE pg_catalog."default",
	longitude character varying(50) COLLATE pg_catalog."default",
	motivo_venda character varying(255) COLLATE pg_catalog."default",
	nome_propriedade character varying(255) COLLATE pg_catalog."default" NOT NULL,
	
  CONSTRAINT propriedades_pkey PRIMARY KEY (id_propriedade),
  CONSTRAINT propriedades_inativo_check CHECK (inativa = ANY (ARRAY['S'::bpchar, 'N'::bpchar])),
  CONSTRAINT propriedades_data_aquisicao_check CHECK (data_aquisicao > '1900-01-01'::date)
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.propriedades
    OWNER to postgres;
	
INSERT INTO public.propriedades(
	aptidao, area_produtiva, area_reserva, area_total, car, data_aquisicao, data_venda, escritura, inativa, itr, latitude, longitude, motivo_venda)
	VALUES ('PECUÁRIA', 60, 40, 100, 'CAR TESTE', '2022-10-23', null, 'ESCRITURA TESTE', 'N', 'ITR TESTE', 'LATITUDE TESTE', 'LONGITUDE TESTE', NULL);