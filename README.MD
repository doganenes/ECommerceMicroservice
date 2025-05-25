# 🛍 ECommerceMicroservice

**ECommerceMicroservice** is a containerized, distributed e-commerce application built with a microservice architecture using modern technologies like .NET Core, RabbitMQ, Redis, Docker, and IdentityServer4. It represents a real-world, scalable, and modular system designed with separation of concerns and best practices.

---

## 📦 Architecture Overview
![test](https://github.com/user-attachments/assets/acad5058-efd3-48ee-8e27-ec107b06a252)
---

## ⚙ Technologies Used

### 🧱 Backend & Microservices
- **.NET Core 8.0** – Microservice development
- **ASP.NET Core MVC** – Web UI (MultiShop.WebUI)
- **Entity Framework Core** – ORM for relational databases
- **Dapper** – Lightweight ORM for fast data access
- **AutoMapper** – Object-Object mapping (DTO ↔ Entity)
- **Ocelot** – API Gateway for routing and aggregation

### 🔐 Authentication & Authorization
- **IdentityServer4** – OAuth2 / OpenID Connect provider
- **JWT (JSON Web Token)** – Secure token-based authentication

### 🧵 Communication & Real-Time
- **RabbitMQ** – Asynchronous messaging between services
- **SignalR** – Real-time messaging and communication

### 🧠 Caching & Performance
- **Redis** – Distributed caching (e.g., for Basket service)

### 🗄 Databases
- **SQL Server** – Relational database for most services
- **MongoDB** – NoSQL for the Catalog service
- **PostgreSQL** – Used in the Message microservice

### ☁ Storage
- **Google Cloud Storage** – File/image upload service

### 🐳 Containerization & DevOps
- **Docker & Docker Compose** – Containerized service orchestration
- **Portainer** – Docker container management UI

### 🧪 Development Tools
- **Postman** – API testing
---

## 🧩 Microservices Breakdown

| Service   | Technology         | Database     | Features                          |
|-----------|--------------------|--------------|-----------------------------------|
| Catalog   | ASP.NET Core API   | MongoDB      | Product listing                   |
| Basket    | ASP.NET Core API   | Redis        | Shopping cart with caching        |
| Discount  | ASP.NET Core API   | SQL Server   | Discount code management          |
| Order     | ASP.NET Core API   | SQL Server   | Order placement and tracking      |
| Cargo     | ASP.NET Core API   | SQL Server   | Shipping & tracking               |
| Message   | ASP.NET Core API   | PostgreSQL   | Messaging between users           |
| Comment   | ASP.NET Core API   | SQL Server   | Product reviews                   |
| Images    | ASP.NET Core API   | Google Cloud Services          | File/image uploads                |
| Identity  | IdentityServer    | SQL Server   | User login, registration, roles   |

---

## 🐳 Dockerized Services

This project uses **Docker Compose** to orchestrate the following services:

- All microservices
- IdentityServer4
- API Gateway (Ocelot)
- Redis
- RabbitMQ (with management UI)
- SQL Server
- MongoDB
- PostgreSQL
- Portainer

Check the `docker-compose.yml` file for the full configuration.

---

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/en-us/download)
- [Docker](https://www.docker.com/)
- [Docker Compose](https://docs.docker.com/compose/)
- (Optional) [Postman](https://www.postman.com/) – for testing APIs

### Run the System

```bash
git clone https://github.com/your-username/ECommerceMicroservice.git
cd ECommerceMicroservice

docker-compose up --build
