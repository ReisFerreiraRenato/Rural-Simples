-- Database: rural_simples_base

-- DROP DATABASE IF EXISTS rural_simples_base;

CREATE DATABASE rural_simples_base
    WITH
    OWNER = postgres
    ENCODING = 'UTF8'
    LC_COLLATE = 'en_US.UTF8'
    LC_CTYPE = 'en_US.UTF8'
    TABLESPACE = pg_default
    CONNECTION LIMIT = -1
    IS_TEMPLATE = False;

COMMENT ON DATABASE rural_simples_base
    IS 'Tabela base de testes do Rural Simples';