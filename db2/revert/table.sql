-- Revert db2:table from pg

BEGIN;

DROP TABLE db2.table_2;

DROP TYPE db2.custom_type_2;

COMMIT;
