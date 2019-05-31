-- Revert db1:appschema from pg

BEGIN;

DROP SCHEMA db1;

COMMIT;
