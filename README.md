# MiniProjektAnkete
Ide gas

CREATE OR REPLACE FUNCTION vnesiDijaka(ime_ varchar, priimek_ varchar, sola varchar, datum_rojstva varchar, kraj varchar, postna varchar)
RETURNS boolean
AS $$
DECLARE
	kraj_ajdi integer;
	preveritev boolean;
	dijak_ajdi integer;
BEGIN
kraj_ajdi := 0;
dijak_ajdi := 0;
preveritev := false;
SELECT INTO kraj_ajdi id FROM kraji WHERE ime = kraj AND postna_st = postna;

IF (kraj_ajdi = 0) THEN
	RETURN preveritev;
ELSE
	SELECT INTO dijak_ajdi id FROM dijaki WHERE (ime = ime_) AND (priimek = priimek_) AND (šola = sola) AND (CAST(datum_rojstva AS timestamp) = datum_roj) AND (kraj_id = kraj_ajdi);
	
	IF (dijak_ajdi IS NULL) THEN
		INSERT INTO dijaki(ime, priimek, šola, datum_roj, kraj_id)
		VALUES(ime_, priimek_, sola, CAST(datum_rojstva AS timestamp), kraj_ajdi);
		preveritev := true;
	END IF;
END IF;

return preveritev;
END;
$$
LANGUAGE 'plpgsql'

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION izpisDijakov()
RETURNS TABLE(ime varchar, priimek varchar, sola varchar, datum_roj timestamp, kraj varchar)
AS $$
DECLARE

BEGIN
	RETURN QUERY
		SELECT d.ime, d.priimek, d.šola, d.datum_roj, k.ime 
		FROM dijaki d INNER JOIN kraji k ON d.kraj_id=k.id;
END;

$$
LANGUAGE 'plpgsql'

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION dodajAnketo(naslov_ varchar, url_ varchar, opis_ varchar, naziv_ varchar)
RETURNS boolean 
AS 
$$
DECLARE
	admin_ajdi integer;
	anketa_ajdi integer;
	preveritev boolean;
BEGIN


SELECT INTO anketa_ajdi id FROM ankete WHERE (url = url_);

IF (anketa_ajdi IS NOT NULL) THEN
	preveritev := false;
	RETURN preveritev;
ELSE
	SELECT INTO admin_ajdi id FROM admin WHERE naziv=naziv_;	
	
	INSERT INTO ankete(naslov, url, opis, admin_id)
	VALUES(naslov_, url_, opis_, admin_ajdi);
	
	preveritev := true;
	RETURN preveritev;
END IF;

RETURN preveritev;
END;
$$
LANGUAGE 'plpgsql'

--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION izpisAnketDijak(ajdi integer)
RETURNS TABLE(id_a integer, naslov_ varchar, url_ varchar, opis_ varchar, datum_ timestamp)
AS $$
DECLARE

BEGIN
RETURN QUERY
	SELECT a.id, a.naslov, a.url, a.opis, p.datum FROM poslane_ankete p INNER JOIN ankete a ON p.anketa_id=a.id WHERE (p.dijak_id = ajdi);
	
	END;
    $$
    LANGUAGE 'plpgsql'

--------------------------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION prikazanket(ajdi integer)
RETURNS TABLE(id integer, naslov character varying, url character varying, opis character varying)
AS $$
DECLARE

BEGIN
RETURN QUERY
	SELECT a.id, a.naslov, a.url, a.opis FROM ankete a WHERE (a.id NOT IN (SELECT p.anketa_id FROM poslane_ankete p WHERE p.dijak_id = ajdi));


END;
$$
LANGUAGE 'plpgsql'


---------------------------------------------------------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION anketeSearch(beseda varchar, ajdi integer)
RETURNS TABLE(id integer, naslov character varying, url character varying, opis character varying)
AS $$
DECLARE

BEGIN
RETURN QUERY
	SELECT a.id, a.naslov, a.url, a.opis FROM ankete a WHERE (a.id NOT IN (SELECT p.anketa_id FROM poslane_ankete p WHERE p.dijak_id = ajdi)) AND ((CAST(a.id AS varchar) LIKE beseda) OR (a.naslov LIKE beseda) OR (a.url LIKE beseda) OR (a.opis LIKE beseda));


END;
$$
LANGUAGE 'plpgsql'

------------------------------------------------------------------------------------------

CREATE OR REPLACE FUNCTION dodajAnketoDijaku(id_d integer, id_a integer, datum_ varchar)
RETURNS VOID
AS $$
DECLARE

BEGIN
INSERT INTO poslane_ankete(dijak_id, anketa_id, datum)
VALUES (id_d, id_a, CAST(datum_ AS timestamp));


END;
$$
LANGUAGE 'plpgsql'

------------------------------------------
CREATE FUNCTION izbrisiAnketo(id_a integer)
RETURNS VOID AS $$
DECLARE

BEGIN
	DELETE FROM poslane_ankete WHERE (id = id_a);
END;
$$
LANGUAGE 'plpgsql'

-----------------------------------------------------
CREATE OR REPLACE FUNCTION prikazanket(ajdi integer)
RETURNS TABLE(id integer, naslov character varying, url character varying, opis character varying)
AS $$
DECLARE

BEGIN
RETURN QUERY
	SELECT a.id, a.naslov, a.url, a.opis FROM ankete a WHERE (a.id NOT IN (SELECT p.anketa_id FROM poslane_ankete p WHERE p.dijak_id = ajdi));


END;
$$
LANGUAGE 'plpgsql'

--------------------------------------------------------------------

CREATE OR REPLACE FUNCTION UrediDijaka(ajdi integer, ime_ varchar, priimek_ varchar, sola_ varchar, kraj_ varchar, postna varchar, datum varchar)
RETURNS VOID
AS $$
DECLARE 
	kraj integer;
BEGIN
SELECT INTO kraj id FROM kraji WHERE ime = kraj_ AND postna_st = postna;

UPDATE dijaki
SET ime = ime_,
priimek = priimek_,
šola = sola_,
datum_roj = CAST(datum AS timestamp),
kraj_id = kraj
WHERE id = ajdi;						  

END;
$$
LANGUAGE 'plpgsql'


TO je večina funkcij, neki jih je zgubljenih notr med tk 720imi funkcijami v pgAdminu kr je neke default cudne funkcije uzelo zraun in je tk celo sintakso mojih funkcij nemogoce dobit vn.

