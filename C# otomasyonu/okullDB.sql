-- Okul tablosu
CREATE TABLE Okul (
    okul_id SERIAL PRIMARY KEY,
    okul_adi VARCHAR(100),
    adres VARCHAR(255)
);

-- Fakülteler tablosu
CREATE TABLE Fakulteler (
    fakulte_id SERIAL PRIMARY KEY,
    fakulte_adi VARCHAR(100),
    okul_id INT REFERENCES Okul(okul_id)
);

-- Bölümler tablosu
CREATE TABLE Bolumler (
    bolum_id SERIAL PRIMARY KEY,
    bolum_adi VARCHAR(100),
    fakulte_id INT REFERENCES Fakulteler(fakulte_id)
);

-- Öğrenciler tablosu
CREATE TABLE Ogrenciler (
    ogrenci_id SERIAL PRIMARY KEY,
    ad VARCHAR(50),
    soyad VARCHAR(50),
    dogum_tarihi DATE,
    bolum_id INT REFERENCES Bolumler(bolum_id)
);

-- Öğretmenler tablosu
CREATE TABLE Ogretmenler (
    ogretmen_id SERIAL PRIMARY KEY,
    ad VARCHAR(50),
    soyad VARCHAR(50),
    ise_baslama_tarihi DATE,
    bolum_id INT REFERENCES Bolumler(bolum_id)
);

-- Dersler tablosu
CREATE TABLE Dersler (
    ders_id SERIAL PRIMARY KEY,
    ders_adi VARCHAR(100),
    bolum_id INT REFERENCES Bolumler(bolum_id),
    ogretmen_id INT REFERENCES Ogretmenler(ogretmen_id)
);

-- Sınavlar tablosu
CREATE TABLE Sinavlar (
    sinav_id SERIAL PRIMARY KEY,
    sinav_adi VARCHAR(100),
    ders_id INT REFERENCES Dersler(ders_id),
    sinav_tarihi DATE
);

-- Öğrenci-Sınav ilişkisini ifade eden tablo
CREATE TABLE Ogrenci_Sinav (
    ogrenci_id INT REFERENCES Ogrenciler(ogrenci_id),
    sinav_id INT REFERENCES Sinavlar(sinav_id),
    notu INT,
    PRIMARY KEY (ogrenci_id, sinav_id)
);
