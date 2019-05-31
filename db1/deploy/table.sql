-- Deploy db1:table to pg
-- requires: appschema

BEGIN;

CREATE TYPE custom_type_1
    AS ENUM (
        'fizz',
        'buzz'
    );

CREATE TABLE db1.table_1
(
    id SERIAL PRIMARY KEY,
    custom custom_type_1
);

COMMIT;
