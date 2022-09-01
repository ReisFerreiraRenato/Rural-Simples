-- Table: public.contatos

-- DROP TABLE IF EXISTS public.contatos;

CREATE TABLE IF NOT EXISTS public.contatos
(
    id_contato character varying(255) COLLATE pg_catalog."default" NOT NULL,
    id_pessoa character varying(255) COLLATE pg_catalog."default",
    facebook character varying(255) COLLATE pg_catalog."default",
    twiter character varying(255) COLLATE pg_catalog."default",
    linkedin character varying(255) COLLATE pg_catalog."default",
    instagram character varying(255) COLLATE pg_catalog."default",
    github character varying(255) COLLATE pg_catalog."default",
    site character varying(255) COLLATE pg_catalog."default",
    pinterest character varying(255) COLLATE pg_catalog."default",
    tiktok character varying(255) COLLATE pg_catalog."default",
    snapchat character varying(255) COLLATE pg_catalog."default",
    skype character varying(255) COLLATE pg_catalog."default",
    messeger character varying(255) COLLATE pg_catalog."default",
    teams character varying(255) COLLATE pg_catalog."default",
    youtube character varying(255) COLLATE pg_catalog."default",
    CONSTRAINT "Contatos_pkey" PRIMARY KEY (id_contato),
    CONSTRAINT "Fk_Pessoa" FOREIGN KEY (id_pessoa)
        REFERENCES public.pessoas (id_pessoa) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.contatos
    OWNER to postgres;