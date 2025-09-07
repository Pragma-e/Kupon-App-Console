# Kupon Uygulaması

## Genel Bakış
Bu konsol uygulaması, kullanıcıların bilgilerini girerek rastgele indirim kuponları kazanabildiği basit bir sistemdir.

## Özellikler
- Kullanıcı bilgileri (ad, soyad, telefon, e-posta) toplanır
- Rastgele kupon kodu oluşturulur
- 200 TL ile 2000 TL arasında rastgele indirim miktarı atanır
- Kullanıcı ve kupon bilgileri SQL veritabanına kaydedilir

## Gereksinimler
- .NET 9.0
- Microsoft.Data.SqlClient
- SQL Server veritabanı

## Kurulum
1. Projeyi klonlayın
2. Veritabanı bağlantı bilgilerini Program.cs dosyasında güncelleyin
3. Projeyi derleyin ve çalıştırın

## Veritabanı
Uygulama "KuponKonsol" adlı bir veritabanı ve "KuponKullanici" tablosu kullanmaktadır.
