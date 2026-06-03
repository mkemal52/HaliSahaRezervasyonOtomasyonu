# ⚽ Halı Saha Rezervasyon Otomasyonu

## 📋 Proje Hakkında

Bu proje, **.NET Framework** ve **Entity Framework 6 (EF6)** kullanılarak geliştirilmiş bir **Windows Forms** masaüstü uygulamasıdır. Halı saha işletmelerinin müşteri, saha ve rezervasyon bilgilerini yönetmelerini sağlar.

Proje, **MSSQL Server** veritabanı üzerine inşa edilmiş olup, ilişkisel veritabanı tasarımı, ORM (Object-Relational Mapping) yapısı ve LINQ sorgulama teknikleri gibi temel yazılım mühendisliği konseptlerini kapsamaktadır.

---

## 🛠️ Kullanılan Teknolojiler

| Teknoloji | Sürüm | Açıklama |
|---|---|---|
| **.NET Framework** | 4.7.2 | Uygulama altyapısı |
| **Entity Framework** | 6.x (EF6) | ORM kütüphanesi |
| **MSSQL Server** | 2019+ | Veritabanı sunucusu |
| **Windows Forms** | - | Masaüstü arayüz |
| **C#** | 7.3 | Programlama dili |
| **LINQ** | - | Sorgulama dili |

---

## 🗂️ Proje Dosya Yapısı

```
HaliSahaRezervasyonOtomasyonu/
│
├── SQL/
│   └── VeritabaniOlustur.sql        → Veritabanı oluşturma scripti (T-SQL)
│
├── Models/
│   ├── Musteri.cs                   → Müşteri entity sınıfı (Müstakil tablo)
│   ├── Saha.cs                      → Saha entity sınıfı (Müstakil tablo)
│   └── Rezervasyon.cs               → Rezervasyon entity sınıfı (Aracı tablo)
│
├── ContextDb.cs                     → EF6 DbContext sınıfı
├── Form1.cs                         → Form kod dosyası (CRUD + LINQ)
├── Form1.Designer.cs                → Form tasarım dosyası (Arayüz)
├── Program.cs                       → Uygulama giriş noktası
├── App.config                       → Bağlantı dizesi ve EF6 yapılandırması
├── README.md                        → Bu dosya
└── Proje_Detayli_Aciklama.txt       → Detaylı öğretici doküman
```

---

## 🗄️ Veritabanı Tasarımı (E-R Diyagramı)

Projede **3 tablo** birbiriyle **Foreign Key** ilişkileri ile bağlıdır:

```
┌──────────────────┐         ┌──────────────────────┐         ┌──────────────────┐
│    MUSTERİLER     │         │    REZERVASYONLAR     │         │     SAHALAR      │
│   (Müstakil)      │         │    (Aracı Tablo)      │         │   (Müstakil)     │
├──────────────────┤         ├──────────────────────┤         ├──────────────────┤
│ MusteriID (PK)   │◄───────┐│ RezervasyonID (PK)   │┌───────►│ SahaID (PK)      │
│ Ad               │  1:N   ││ MusteriID (FK)       ││  N:1   │ SahaAdi          │
│ Soyad            │        ││ SahaID (FK)          ││        │ SahaTuru         │
│ Telefon          │        ││ MacTarihi            ││        │ SaatlikUcret     │
└──────────────────┘        ││ MacSaati             ││        └──────────────────┘
                             │└──────────────────────┘│
                             └────────────────────────┘
```

### İlişki Açıklamaları:
- **Musteriler → Rezervasyonlar** : Bire-Çok (One-to-Many) — Bir müşteri birden fazla rezervasyon yapabilir.
- **Sahalar → Rezervasyonlar** : Bire-Çok (One-to-Many) — Bir sahaya birden fazla rezervasyon yapılabilir.
- **Rezervasyonlar** tablosu, Musteriler ve Sahalar tablolarını birbirine bağlayan **aracı tablodur**.

---

## 📊 Tablo Detayları

### 1. Musteriler Tablosu
| Kolon Adı | Veri Tipi | Kısıtlama | Açıklama |
|---|---|---|---|
| MusteriID | INT | PK, IDENTITY | Otomatik artan birincil anahtar |
| Ad | NVARCHAR(50) | NOT NULL | Müşteri adı |
| Soyad | NVARCHAR(50) | NOT NULL | Müşteri soyadı |
| Telefon | NVARCHAR(20) | NOT NULL | Telefon numarası |

### 2. Sahalar Tablosu
| Kolon Adı | Veri Tipi | Kısıtlama | Açıklama |
|---|---|---|---|
| SahaID | INT | PK, IDENTITY | Otomatik artan birincil anahtar |
| SahaAdi | NVARCHAR(100) | NOT NULL | Saha adı |
| SahaTuru | NVARCHAR(50) | NOT NULL | Saha türü (Açık/Kapalı) |
| SaatlikUcret | DECIMAL(10,2) | NOT NULL | Saatlik kiralama ücreti |

### 3. Rezervasyonlar Tablosu (Aracı)
| Kolon Adı | Veri Tipi | Kısıtlama | Açıklama |
|---|---|---|---|
| RezervasyonID | INT | PK, IDENTITY | Otomatik artan birincil anahtar |
| MusteriID | INT | FK, NOT NULL | Müşteri referansı |
| SahaID | INT | FK, NOT NULL | Saha referansı |
| MacTarihi | DATETIME | NOT NULL | Maç tarihi |
| MacSaati | NVARCHAR(10) | NOT NULL | Maç saati |

---

## ⚙️ Kurulum Adımları

### 1. Veritabanı Oluşturma
1. **SQL Server Management Studio (SSMS)** uygulamasını açın.
2. `SQL/VeritabaniOlustur.sql` dosyasının içeriğini kopyalayın.
3. SSMS'de yeni bir sorgu penceresi açıp yapıştırın ve **Execute (F5)** ile çalıştırın.
4. "HaliSahaDB" veritabanı, 3 tablo ve örnek veriler otomatik oluşacaktır.

### 2. Visual Studio Proje Oluşturma
1. **Visual Studio 2019/2022** uygulamasını açın.
2. **File → New → Project** seçeneğine tıklayın.
3. **"Windows Forms App (.NET Framework)"** şablonunu seçin.
   - ⚠️ DİKKAT: ".NET Framework" yazan şablonu seçin, ".NET" veya ".NET Core" DEĞİL!
4. Proje adını **"HaliSahaRezervasyonOtomasyonu"** olarak yazın.
5. Framework olarak **.NET Framework 4.7.2** seçin.
6. **Create** butonuna tıklayın.

### 3. Entity Framework 6 Kurulumu (NuGet)
1. Visual Studio'da **Tools → NuGet Package Manager → Package Manager Console** açın.
2. Aşağıdaki komutu yazıp **Enter** tuşuna basın:
   ```
   Install-Package EntityFramework -Version 6.4.4
   ```
3. Kurulum tamamlandığında References kısmında `EntityFramework` ve `EntityFramework.SqlServer` DLL'lerini göreceksiniz.

### 4. Dosyaları Projeye Ekleme
1. Proje klasörüne gidin (Solution Explorer'da projeye sağ tık → **Open Folder in File Explorer**).
2. Projenin kök dizininde bir **"Models"** klasörü oluşturun.
3. Aşağıdaki dosyaları ilgili konumlara kopyalayın:
   - `Models/Musteri.cs` → Proje/Models/ klasörüne
   - `Models/Saha.cs` → Proje/Models/ klasörüne
   - `Models/Rezervasyon.cs` → Proje/Models/ klasörüne
   - `ContextDb.cs` → Proje kök dizinine
4. Visual Studio'da Solution Explorer'da projeye sağ tık → **Add → Existing Item** ile bu dosyaları ekleyin.
5. Mevcut `Form1.cs` ve `Form1.Designer.cs` dosyalarının **içeriğini** proje dosyalarındaki kodlarla **değiştirin**.
6. `App.config` dosyasının içeriğini projedeki App.config ile **değiştirin**.
7. `Program.cs` dosyasının içeriğini projedeki kodla **değiştirin**.

### 5. Projeyi Çalıştırma
1. **Ctrl + Shift + B** ile projeyi derleyin (Build).
2. Hata yoksa **F5** veya **Ctrl + F5** ile çalıştırın.

---

## 🖥️ Uygulama Arayüzü

Uygulama **3 sekmeden** oluşur:

### Sekme 1: Müşteri İşlemleri
- **Ekle**: Yeni müşteri kaydı oluşturur.
- **Güncelle**: Seçili müşteri bilgilerini günceller.
- **Sil**: Seçili müşteriyi siler.
- **Temizle**: Formdaki giriş alanlarını temizler.
- **Listele**: Tüm müşterileri tabloda gösterir.

### Sekme 2: Rezervasyon İşlemleri
- **Ekle**: Yeni rezervasyon oluşturur (Müşteri + Saha + Tarih + Saat seçimi).
- **Sil**: Seçili rezervasyonu siler.
- **Listele**: Tüm rezervasyonları ilişkili bilgilerle gösterir.
- ⚠️ **Güncelleme işlemi yoktur** (hocanın talimatı gereği).

### Sekme 3: LINQ Sorguları
- **Sorgu 1**: Saatlik ücreti 1500 TL'den fazla olan sahaların rezervasyonları.
- **Sorgu 2**: Her müşterinin toplam rezervasyon sayısı ve harcadığı tutar.
- Sonuçlar **RadioButton** ile seçilip **Label'a** yazdırılır.

---

## 📐 Class Diagram (Sınıf Diyagramı)

Visual Studio'da Class Diagram oluşturmak için:
1. Solution Explorer'da projeye sağ tıklayın.
2. **Add → New Item → Class Diagram** seçin.
3. Models klasöründeki 3 sınıfı diyagram üzerine sürükleyin.
4. İlişki okları otomatik olarak görünecektir:
   - `Musteri` ← One-to-Many → `Rezervasyon`
   - `Saha` ← One-to-Many → `Rezervasyon`

---

## 🔍 LINQ Sorgu Örnekleri

### Sorgu 1: Pahalı Sahaların Rezervasyonları
```csharp
var sonuclar = db.Rezervasyonlar
    .Where(r => r.Saha.SaatlikUcret > 1500)
    .Select(r => new {
        r.RezervasyonID,
        MusteriAdSoyad = r.Musteri.Ad + " " + r.Musteri.Soyad,
        SahaAdi = r.Saha.SahaAdi,
        SaatlikUcret = r.Saha.SaatlikUcret
    }).ToList();
```

### Sorgu 2: Müşteri Rezervasyon Özeti
```csharp
var sonuclar = db.Musteriler
    .Select(m => new {
        MusteriAdSoyad = m.Ad + " " + m.Soyad,
        RezervasyonSayisi = m.Rezervasyonlar.Count,
        ToplamTutar = m.Rezervasyonlar.Sum(r => r.Saha.SaatlikUcret)
    }).ToList();
```

---

## 👨‍💻 Geliştirici Bilgileri

| Bilgi | Değer |
|---|---|
| Proje Türü | Dönem Sonu Ödevi |
| Ders | Veritabanı / Yazılım Mühendisliği |
| Platform | .NET Framework 4.7.2 |
| ORM | Entity Framework 6 |
| Veritabanı | Microsoft SQL Server |
| Arayüz | Windows Forms (WinForms) |

---

## 📝 Notlar

- Proje koyu tema (dark theme) arayüz tasarımına sahiptir.
- Tüm tablo, kolon, sınıf ve değişken isimleri Türkçedir.
- Navigation Property'ler sayesinde Class Diagram'da ilişki okları görünür.
- Primary Key formatı: `TabloAdiID` (Örn: MusteriID, SahaID, RezervasyonID).
- Aracı tablo (Rezervasyonlar) için güncelleme işlemi kasıtlı olarak eklenmemiştir.
