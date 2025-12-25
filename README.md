# 🛍️ Scalable E-Commerce Platform (Mobile & API)

![React Native](https://img.shields.io/badge/Mobile-React%20Native-blue)
![ASP.NET](https://img.shields.io/badge/Backend-ASP.NET%20Core-purple)
![Status](https://img.shields.io/badge/Architecture-Full%20Stack-success)

## 🚀 Proje Hakkında
Bu proje, modern yazılım mimarilerine uygun olarak geliştirilmiş, **React Native (Expo)** tabanlı bir mobil ön yüz ve **ASP.NET Core Web API** tabanlı güçlü bir arka yüzden oluşan uçtan uca (Full Stack) bir e-ticaret sistemidir.

Sadece bir arayüz değil, veritabanı yönetiminden güvenliğe (**JWT**) kadar tüm katmanları içeren, Tazi AI gibi şirketlerin aradığı "Sistem Tasarımı" yetkinliğini gösteren profesyonel bir mimari kurgulanmıştır.

## ✨ Temel Özellikler
* **Güvenli Kimlik Doğrulama:** JWT (JSON Web Token) ile güvenli giriş, kayıt ve oturum yönetimi.
* **RESTful API Mimarisi:** ASP.NET Core ile yazılmış, performanslı ve ölçeklenebilir backend servisleri.
* **Modern Navigasyon:** Expo Router kullanılarak akıcı sayfa geçişleri.
* **Kullanıcı Deneyimi (UX):** Dinamik ürün listeleme, sepete ekleme, favoriler ve profil yönetimi.
* **Veritabanı Yönetimi:** MSSQL ve Entity Framework Core (Code-First) yaklaşımı.

## 🛠️ Teknoloji Yığını (Tech Stack)

### Frontend (Mobil)
* **Framework:** React Native (Expo SDK 50+)
* **Dil:** JavaScript / TypeScript
* **State Yönetimi:** React Hooks

### Backend (API)
* **Framework:** ASP.NET Core Web API
* **Dil:** C#
* **ORM:** Entity Framework Core
* **Veritabanı:** MSSQL

## 💻 Kurulum ve Çalıştırma

Bu proje **Client** (Mobil) ve **Server** (API) olmak üzere iki parçadan oluşur.

### 1. Backend (API) Kurulumu
Backend klasörüne gidin ve veritabanını ayağa kaldırın:
```bash
cd Server
dotnet restore
dotnet ef database update  # Veritabanı tablolarını oluşturur
dotnet run
```
<p align="center"> Mustafa Gürhan tarafından ❤️ ile geliştirildi. </p>
