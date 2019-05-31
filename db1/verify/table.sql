-- Verify db1:table on pg

BEGIN;

SELECT 1/COUNT(*) FROM pg_catalog.pg_tables WHERE schemaname  = 'db1' AND tablename = 'table_1';

SELECT enum_range(NULL::custom_type_1);

ROLLBACK;
