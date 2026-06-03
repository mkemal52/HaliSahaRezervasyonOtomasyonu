-- =====================================================
-- HALI SAHA REZERVASYON OTOMASYONU
-- Veritabanı Oluşturma Scripti (T-SQL)
-- =====================================================
-- Bu script MSSQL Server Management Studio (SSMS) 
-- üzerinde doğrudan çalıştırılabilir.
-- =====================================================

-- Veritabanını oluştur
CREATE DATABASE HaliSahaDB;
GO

USE HaliSahaDB;
GO

-- =====================================================
-- 1) MÜSTERİLER TABLOSU (Müstakil Tablo)
-- Açıklama: Halı saha müşterilerinin bilgilerini tutar.
-- İlişki: Bir müşterinin birden fazla rezervasyonu olabilir (One-to-Many).
-- =====================================================
CREATE TABLE Musteriler (
    MusteriID   INT IDENTITY(1,1) PRIMARY KEY,  -- Birincil Anahtar (PK), Otomatik artan
    Ad          NVARCHAR(50)   NOT NULL,         -- Müşteri adı
    Soyad       NVARCHAR(50)   NOT NULL,         -- Müşteri soyadı
    Telefon     NVARCHAR(20)   NOT NULL          -- Müşteri telefon numarası
);
GO

-- =====================================================
-- 2) SAHALAR TABLOSU (Müstakil Tablo)
-- Açıklama: Halı saha bilgilerini tutar (ad, tür, ücret).
-- İlişki: Bir sahanın birden fazla rezervasyonu olabilir (One-to-Many).
-- =====================================================
CREATE TABLE Sahalar (
    SahaID       INT IDENTITY(1,1) PRIMARY KEY,  -- Birincil Anahtar (PK), Otomatik artan
    SahaAdi      NVARCHAR(100)  NOT NULL,        -- Saha adı
    SahaTuru     NVARCHAR(50)   NOT NULL,        -- Saha türü (Açık / Kapalı)
    SaatlikUcret DECIMAL(10,2)  NOT NULL         -- Saatlik kiralama ücreti (TL)
);
GO

-- =====================================================
-- 3) REZERVASYONLAR TABLOSU (Aracı Tablo)
-- Açıklama: Müşteri ile Saha arasındaki rezervasyon ilişkisini kurar.
-- İlişki: Her rezervasyon bir müşteriye ve bir sahaya bağlıdır (Many-to-One).
-- Foreign Key: MusteriID -> Musteriler(MusteriID)
-- Foreign Key: SahaID -> Sahalar(SahaID)
-- =====================================================
CREATE TABLE Rezervasyonlar (
    RezervasyonID INT IDENTITY(1,1) PRIMARY KEY,  -- Birincil Anahtar (PK), Otomatik artan
    MusteriID     INT       NOT NULL,              -- Yabancı Anahtar (FK) -> Musteriler
    SahaID        INT       NOT NULL,              -- Yabancı Anahtar (FK) -> Sahalar
    MacTarihi     DATETIME  NOT NULL,              -- Maç tarihi
    MacSaati      NVARCHAR(10) NOT NULL,           -- Maç saati (Örn: "19:00")

    -- Foreign Key Kısıtlamaları (İlişkiler)
    CONSTRAINT FK_Rezervasyonlar_Musteriler 
        FOREIGN KEY (MusteriID) REFERENCES Musteriler(MusteriID)
        ON DELETE CASCADE,

    CONSTRAINT FK_Rezervasyonlar_Sahalar 
        FOREIGN KEY (SahaID) REFERENCES Sahalar(SahaID)
        ON DELETE CASCADE
);
GO

-- =====================================================
-- ÖRNEK VERİLER
-- =====================================================

-- Müşteri verileri
INSERT INTO Musteriler (Ad, Soyad, Telefon) VALUES
(N'Ahmet',   N'Yılmaz',   N'0532 111 2233'),
(N'Mehmet',  N'Kaya',     N'0533 222 3344'),
(N'Ali',     N'Demir',    N'0534 333 4455'),
(N'Fatih',   N'Çelik',    N'0535 444 5566'),
(N'Emre',    N'Şahin',    N'0536 555 6677');
GO

-- Saha verileri
INSERT INTO Sahalar (SahaAdi, SahaTuru, SaatlikUcret) VALUES
(N'Yıldız Saha',      N'Kapalı',  1200.00),
(N'Şampiyon Saha',    N'Açık',     800.00),
(N'Gol Arena',        N'Kapalı',  1600.00),
(N'Kartal Saha',      N'Açık',     950.00),
(N'Zafer Sahası',     N'Kapalı',  1800.00);
GO

-- Rezervasyon verileri
INSERT INTO Rezervasyonlar (MusteriID, SahaID, MacTarihi, MacSaati) VALUES
(1, 1, '2026-06-10', N'19:00'),
(2, 3, '2026-06-11', N'20:00'),
(3, 2, '2026-06-12', N'21:00'),
(4, 5, '2026-06-13', N'18:00'),
(5, 4, '2026-06-14', N'22:00'),
(1, 3, '2026-06-15', N'19:00'),
(2, 1, '2026-06-16', N'20:00');
GO

-- Verileri kontrol et
SELECT * FROM Musteriler;
SELECT * FROM Sahalar;
SELECT * FROM Rezervasyonlar;
GO
