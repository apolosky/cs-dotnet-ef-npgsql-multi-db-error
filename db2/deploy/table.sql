-- Deploy db2:table to pg
-- requires: appschema

BEGIN;

CREATE TYPE db2.custom_type_2
    AS ENUM (
        'asdf',
        'zxcv',
        'wer'
    );

CREATE TABLE db2.table_2
(
    id uuid PRIMARY KEY DEFAULT uuid_generate_v4(),
    custom db2.custom_type_2 NOT NULL,
    id_from_table_1 int NOT NULL
);

COMMIT;
