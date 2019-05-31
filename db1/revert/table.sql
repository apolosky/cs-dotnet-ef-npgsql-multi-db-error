-- Revert db1:table from pg

BEGIN;

DROP TABLE db1.table_1;

DROP TYPE custom_type_1;

COMMIT;
