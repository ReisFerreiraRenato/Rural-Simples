-- Table: public.enderecos

-- DROP TABLE IF EXISTS public.enderecos;

CREATE TABLE IF NOT EXISTS public.enderecos
(
    id_endereco serial,
    id_pessoa integer NOT NULL,
    cep character varying(10) COLLATE pg_catalog."default",
    logradouro character varying(255) COLLATE pg_catalog."default",
    numero character varying(50) COLLATE pg_catalog."default",
    complemento character varying(50) COLLATE pg_catalog."default",
    bairro character varying(255) COLLATE pg_catalog."default",
    cidade character varying(255) COLLATE pg_catalog."default",
    uf character varying(2) COLLATE pg_catalog."default",
    ibge integer,
    gia integer,
    siafi integer,
    ddd integer,
    CONSTRAINT enderecos_pkey PRIMARY KEY (id_endereco),
    CONSTRAINT fk_pessoas FOREIGN KEY (id_pessoa)
        REFERENCES public.pessoas (id_pessoa) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.enderecos
    OWNER to postgres;
	
INSERT INTO public.enderecos(
	id_pessoa, cep, logradouro, numero, complemento, bairro, cidade, uf, ibge, gia, siafi, ddd)
	VALUES (1, '77.820-496', 'RUA TESTE', '319', 'CASA PERTO DO ECONÔMICA', 'CENTRO', 'ARAGUAÍNA', 'TO', '123456', '321654', '987456', '63');