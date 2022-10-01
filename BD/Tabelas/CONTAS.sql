-- Table: public.contas

-- DROP TABLE IF EXISTS public.contas;

CREATE TABLE IF NOT EXISTS public.contas
(
    id_conta serial,
	id_pessoa integer NOT NULL,
    tipo_conta "char" NOT NULL DEFAULT 'R'::"char",
    id_pessoa_favorecido integer,
    favorecido character varying(255) COLLATE pg_catalog."default",
    id_pessoa_devedor integer,
    devedor character varying(255) COLLATE pg_catalog."default",
    data_emissao date NOT NULL,
    data_vencimento date NOT NULL,
    data_cadastro date NOT NULL,
    data_pagamento date,
    valor_juros numeric(10,2),
    valor_multa numeric(10,2),
    valor_outros numeric(10,2),
    valor_desconto numeric(10,2),
    valor_total numeric(10,2),
    valor_pago numeric(10,2),
    valor_principal numeric(10,2),
    cancelado "char" NOT NULL DEFAULT 'N'::"char",
    CONSTRAINT contas_pkey PRIMARY KEY (id_conta),
		CONSTRAINT fk_pessoas FOREIGN KEY (id_pessoa)
        REFERENCES public.pessoas (id_pessoa) MATCH SIMPLE
        ON UPDATE CASCADE
        ON DELETE CASCADE
)

TABLESPACE pg_default;

ALTER TABLE IF EXISTS public.contas
    OWNER to postgres;
	
INSERT INTO public.contas(
	id_pessoa, tipo_conta, id_pessoa_favorecido, favorecido, id_pessoa_devedor, devedor, data_emissao, data_vencimento, data_cadastro, data_pagamento, valor_juros, valor_multa, valor_outros, valor_desconto, valor_total, valor_pago, valor_principal, cancelado)
	VALUES (1, 'R', 1, 'CONTA TESTE FAVORECIDO', 1, 'CONTA TESTE DEVEDOR', '2022-09-01', '2022-10-01', '2022-09-04', NULL, NULL, NULL, NULL, NULL, NULL, NULL, 100, 'N');