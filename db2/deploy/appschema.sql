-- Deploy db2:appschema to pg

BEGIN;

CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

CREATE SCHEMA db2;

COMMIT;
