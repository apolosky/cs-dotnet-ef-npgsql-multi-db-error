-- Verify db2:table on pg

BEGIN;

SELECT 1/COUNT(*) FROM pg_catalog.pg_tables WHERE schemaname  = 'db2' AND tablename = 'table_2';

SELECT enum_range(NULL::db2.custom_type_2);

ROLLBACK;
