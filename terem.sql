DROP TABLE IF EXISTS terem_szekek;
CREATE TABLE terem_szekek
(
	terem_id INT(5) NOT NULL,
	sor TINYINT(2) NOT NULL,
	oszlop TINYINT(2) NOT NULL,
	ertek TINYINT(1) NOT NULL,	
    PRIMARY KEY (terem_id,sor,oszlop),
    FOREIGN KEY (terem_id) REFERENCES terem_adatok(terem_id)
);