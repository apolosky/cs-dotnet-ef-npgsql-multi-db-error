-- Verify db1:appschema on pg

BEGIN;

SELECT 1/COUNT(*) FROM information_schema.schemata WHERE schema_name = 'db1';

ROLLBACK;
