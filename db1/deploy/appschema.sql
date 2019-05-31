-- Deploy db1:appschema to pg

BEGIN;

CREATE EXTENSION IF NOT EXISTS "uuid-ossp";

CREATE SCHEMA db1;

COMMIT;
