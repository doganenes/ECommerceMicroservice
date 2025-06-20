# 🛍 ECommerceMicroservice

**ECommerceMicroservice**, .NET Core, RabbitMQ, Redis, Docker ve IdentityServer4 gibi modern teknolojilerle geliştirilen, konteyner tabanlı dağıtık bir e-ticaret uygulamasıdır. Gerçek dünya senaryolarına uygun, ölçeklenebilir ve modüler bir yapı sunar. Sorunların ayrıştırılması (separation of concerns) ve en iyi yazılım geliştirme pratikleri dikkate alınarak hazırlanmıştır.

---

## 📦 Mimari Genel Bakış

![Architecture Overview](https://github.com/user-attachments/assets/acad5058-efd3-48ee-8e27-ec107b06a252)

---

## ⚙ Kullanılan Teknolojiler

### 🧱 Backend & Mikroservisler
- **.NET 8.0** – Mikroservis geliştirme
- **ASP.NET Core MVC** – Web UI (MultiShop.WebUI)
- **Entity Framework Core** – ORM (ilişkisel veritabanı için)
- **Dapper** – Hafif ve hızlı veri erişimi
- **AutoMapper** – DTO ↔ Entity dönüşümleri
- **Ocelot** – API Gateway (routing ve aggregation)

### 🔐 Kimlik Doğrulama & Yetkilendirme
- **IdentityServer4** – OAuth2 / OpenID Connect sağlayıcısı
- **JWT (JSON Web Token)** – Token tabanlı kimlik doğrulama

### 🧵 İletişim & Gerçek Zamanlı Veri
- **RabbitMQ** – Asenkron servisler arası mesajlaşma
- **SignalR** – Gerçek zamanlı iletişim altyapısı

### 🧠 Önbellekleme & Performans
- **Redis** – Dağıtık önbellekleme sistemi

### 🗄 Veritabanları
- **SQL Server** – İlişkisel veritabanı
- **MongoDB** – NoSQL (Catalog servisi için)
- **PostgreSQL** – Message servisi için

### ☁ Dosya Depolama
- **Google Cloud Storage** – Görsel/dosya yükleme servisi

### 🐳 Konteyner & DevOps
- **Docker & Docker Compose** – Konteyner yönetimi
- **Portainer** – Docker arayüz yönetim aracı

### 🧪 Geliştirme Araçları
- **Postman** – API testleri için

---

## 🧩 Mikroservisler Özeti

| Servis    | Teknoloji           | Veritabanı            | Açıklama                        |
|-----------|---------------------|------------------------|---------------------------------|
| Catalog   | ASP.NET Core API    | MongoDB                | Ürün listeleme                  |
| Basket    | ASP.NET Core API    | Redis                  | Alışveriş sepeti                |
| Discount  | ASP.NET Core API    | SQL Server             | İndirim kodu yönetimi          |
| Order     | ASP.NET Core API    | SQL Server             | Sipariş işleme                  |
| Cargo     | ASP.NET Core API    | SQL Server             | Kargo & takip                   |
| Message   | ASP.NET Core API    | PostgreSQL             | Mesajlaşma sistemi              |
| Comment   | ASP.NET Core API    | SQL Server             | Ürün yorumları                  |
| Images    | ASP.NET Core API    | Google Cloud Storage   | Görsel/dosya yükleme servisi    |
| Identity  | IdentityServer4     | SQL Server             | Giriş, kayıt, rol yönetimi      |

---

## 🐳 Docker Compose ile Çalışan Servisler

Proje, aşağıdaki servisleri bir arada çalıştırmak için `docker-compose.yml` kullanır:

- Tüm mikroservisler
- IdentityServer4
- API Gateway (Ocelot)
- Redis
- RabbitMQ (UI arayüzü dahil)
- SQL Server
- MongoDB
- PostgreSQL
- Portainer

Detaylı konfigürasyon için `docker-compose.yml` dosyasını inceleyin.

---

## 🚀 Başlarken

### Gereksinimler

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)
- (Opsiyonel) [Postman](https://www.postman.com/)

### Sistemi Başlatmak için

```bash
git clone https://github.com/your-username/ECommerceMicroservice.git
cd ECommerceMicroservice

docker-compose up --build

---

## 📸 Screenshots
![Image1](https://github.com/user-attachments/assets/cf75a300-a221-4746-afb9-99338bec1b4e)
![Image](https://github.com/user-attachments/assets/197d13d9-1166-42e0-b26f-22862dbb40db)
![Image](https://github.com/user-attachments/assets/c65a66ad-f720-4f4d-b6d6-a0461c4036a9)
![Image](https://github.com/user-attachments/assets/a0d0a2bb-a843-424a-a5f3-1d93df0ed790)
![Image](https://github.com/user-attachments/assets/d08ce291-db8b-4b81-b1f1-44c2717724c0)
![Image](https://github.com/user-attachments/assets/4f242297-a504-4cf3-9f84-c77d1814c592)
![Image](https://github.com/user-attachments/assets/07672fea-7fee-4622-bebe-cf7c7ef9ea13)
