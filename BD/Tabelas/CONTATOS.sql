-- Table: public.contatos

-- DROP TABLE IF EXISTS public.contatos;

CREATE TABLE IF NOT EXISTS public.contatos
(
    id_contato serial,
    id_pessoa integer NOT NULL,
    facebook character varying(255) COLLATE pg_catalog."default",
		instagram character varying(255) COLLATE pg_catalog."default",
    twiter character varying(255) COLLATE pg_catalog."default",
		tiktok character varying(255) COLLATE pg_catalog."default",
    youtube character varying(255) COLLATE pg_catalog."default",
		site character varying(255) COLLATE pg_catalog."default",
		telefone_fixo character varying(15) COLLATE pg_catalog."default",
    celular character varying(15) COLLATE pg_catalog."default",
		celular_whatsapp character varying(1) NOT NULL DEFAULT 'N'::character(1), 
    email character varying(255) COLLATE pg_catalog."default",
    telefone_recado character varying(15) COLLATE pg_catalog."default",
	  nome_pessoa_recado character varying(255) COLLATE pg_catalog."default",
    CONSTRAINT "Contatos_pkey" PRIMARY KEY (id_contato),
		CONSTRAINT contatos_celular_whatsapp CHECK (celular_whatsapp = ANY (ARRAY['S'::bpchar, 'N'::bpchar])),
    CONSTRAINT "Fk_Pessoa" FOREIGN KEY (id_pessoa)
        REFERENCES public.pessoas (id_pessoa) MATCH SIMPLE
        ON UPDATE NO ACTION
        ON DELETE CASCADE
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.contatos
    OWNER to postgres;
	
INSERT INTO public.contatos(
	id_pessoa, facebook, instagram, twiter, tiktok, youtube, site, telefone_fixo, celular, email, telefone_recado)
	VALUES (1, 'facebook.com\NewTeste', 'instagram.com\NewTeste', 'twiter.com\NewTeste', 'tiktok.com\NewTeste', 'youtube.com\NewTeste', 'siteteste.com.br\siteteste', '(63)1111-1111', '(63)22222-2222', 'email@teste.com', '(63)33333-3333');