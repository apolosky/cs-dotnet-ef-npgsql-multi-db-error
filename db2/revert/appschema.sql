-- Revert db2:appschema from pg

BEGIN;

DROP SCHEMA db2;

COMMIT;
