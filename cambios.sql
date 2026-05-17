USE sakila2021;

-- 1. Primero eliminar la tabla de relación (claves foráneas)
DROP TABLE IF EXISTS FilmActors;

-- 2. Luego eliminar las tablas principales
DROP TABLE IF EXISTS Films;
DROP TABLE IF EXISTS Actors;

-- 3. También eliminar el historial de migraciones de EF
DROP TABLE __EFMigrationsHistory;

ALTER TABLE film
ADD estado VARCHAR(10) NOT NULL DEFAULT 'Activo';


select * from film where title = 'ADAPTATION HOLES';


ALTER TABLE customer ALTER COLUMN active BIT;
UPDATE customer SET active = 1 WHERE active = '1';
UPDATE customer SET active = 0 WHERE active = '0';

SELECT name 
FROM sys.default_constraints 
WHERE parent_object_id = OBJECT_ID('customer') 
AND parent_column_id = (SELECT column_id FROM sys.columns WHERE name = 'active' AND object_id = OBJECT_ID('customer'));


ALTER TABLE customer DROP CONSTRAINT DF__customer__active__5BE2A6F2;


ALTER TABLE customer ALTER COLUMN active BIT;



UPDATE customer SET active = 1 WHERE active = '1';
UPDATE customer SET active = 0 WHERE active = '0';

ALTER TABLE customer ADD DEFAULT 1 FOR active;

