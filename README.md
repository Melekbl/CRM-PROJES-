# Otel Yönetim Sistemi (WinForms)

Bu proje, bir **otel işletmesi / hizmet odaklı işletme** için geliştirilmiş; **müşteri yönetimi, personel yönetimi, oda & hizmet tanımlama ve raporlama** süreçlerini dijital ortamda yönetmeyi amaçlayan bir **Windows Forms masaüstü uygulamasıdır**.

Projede **katmanlı mimari (N-Tier)** kullanılmış, böylece sürdürülebilir ve geliştirilebilir bir yapı sağlanmıştır.

---

## 📌 Özellikler

### 🔐 Kullanıcı Girişi ve Rol Yönetimi

* Rol bazlı giriş sistemi:

  * **Admin**
  * **Çağrı Personeli**
  * **Destek Personeli**
* Kullanıcı rolüne göre ekranlara erişim
* Güvenlik: Kullanıcı adı & şifre kontrolü

---

### 👥 Müşteri Yönetimi

* Müşteri ekleme, güncelleme, silme
* İletişim ve oda/hizmet geçmişi takibi
* DataGridView üzerinden listeleme

---

### 🧑‍💼 Personel Yönetimi

* Personel ekleme, güncelleme, silme
* Rol ve uzmanlık alanı tanımlama
* Oda ve hizmet süreçlerine personel atama

---

### 🛎️ Oda & Hizmet Yönetimi

* Oda ve hizmet ekleme, güncelleme, silme
* Oda tipi, fiyat ve hizmet açıklaması
* Müşteri ile entegre yapı

---

### 📊 Raporlama & Dashboard

* Tarih aralığına göre raporlama
* Oda/hizmet ve durum bazlı filtreleme
* İşletme performansını analiz etmeye yönelik ekranlar

---

## 🏗️ Mimari Yapı

* **UI (User Interface):** Windows Forms arayüzleri
* **BLL (Business Logic Layer):** İş kuralları ve kontroller
* **DAL (Data Access Layer):** MySQL veritabanı işlemleri
* **Domain / Entities:** Veri modelleri (Customer, Room, Staff, Service vb.)

---

## 📂 Proje Yapısı

```
OtelYonetimSistemi
│
├── OtelUI           → Windows Forms arayüzleri
├── OtelBLL          → İş mantığı
├── OtelDAL          → Veritabanı işlemleri
├── OtelDomain       → Veri modelleri
│
├── App.config       → MySQL bağlantı ayarları
├── Program.cs       → Uygulama başlangıcı
└── OtelYonetim.sln
```

---

## 🛠️ Kullanılan Teknolojiler

* **Dil:** C# (.NET Framework)
* **Arayüz:** Windows Forms
* **Veritabanı:** MySQL (phpMyAdmin)
* **Mimari:** Katmanlı Mimari (N-Tier)
* **Veri İşleme:** LINQ
* **Versiyon Kontrol:** Git & GitHub

---

Projeyi Klonlayın
git clone https://github.com/Melekbl/CRM-PROJES-
2️⃣ Visual Studio ile Açın
CRMProjesi1.sln dosyasını açın
3️⃣ Veritabanı Ayarları
App.config içindeki MySQL bağlantı bilgilerini düzenleyin
4️⃣ Veritabanı Tabloları
MySQL üzerinde aşağıdaki tabloların oluşturulması gerekmektedir:

kullanicilar
musteriler
personeller
hizmetler
talepler

5️⃣ Çalıştırın
Visual Studio üzerinden F5 ile projeyi başlatın
🎯 Projenin Amaçları
✅ Müşteri ve hizmet süreçlerini dijitalleştirmek ✅ İşletme içi iş akışını düzenlemek ✅ Manuel hataları azaltmak ✅ Gerçek hayata uygun kurumsal bir CRM sistemi geliştirmek ✅ Katmanlı mimariyi uygulamalı olarak öğrenmek

## 🎯 Amaç

✅ Müşteri, oda ve hizmet süreçlerini dijitalleştirmek
✅ İşletme içi iş akışını düzenlemek
✅ Manuel hataları azaltmak
✅ Kurumsal bir CRM sistemi geliştirmek
✅ Katmanlı mimariyi uygulamalı olarak öğrenmek

---

## 📌 Geliştirilebilecek Özellikler

* PDF / Excel rapor çıktısı
* Şifrelerin hashlenerek saklanması (SHA-256)
* Grafik tabanlı dashboard
* Web veya mobil versiyon
* Otomatik bildirim sistemi

---

## 👤 Geliştirici

**Ad Soyad:** Melek Balcıbaşı
**Bölüm:** Yönetim Bilişim Sistemleri – Bursa Uludağ Üniversitesi
video https://youtu.be/8vndftnLtw0?si=TI-Hbsc9_FWU8feY
📌 Not: Bu proje **eğitim ve akademik amaçlı** geliştirilmiştir.
