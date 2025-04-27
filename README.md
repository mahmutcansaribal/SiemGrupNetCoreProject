# 📚 Siem Grup - Kütüphane Yönetim API Projesi

Bu proje, **Siem Grup** firması adına geliştirilmiş basit bir **API** projesidir.  
Proje geliştirirken **katmanlı mimari** prensibi benimsenmiş ve temiz kod yapısına özen gösterilmiştir.

## Kullanılan Teknolojiler ve Yapılar

- **Katmanlı Mimari** kullanılmıştır:
  - Entities Katmanı (Varlıklar/Modeller)
  - Data Access Katmanı (Veritabanı işlemleri)
  - Business Katmanı (İş kuralları)
  - API Katmanı (Servis uç noktaları)

- **DTO (Data Transfer Object)** yapısı kullanılarak, veriler katmanlar arasında güvenli ve doğru şekilde taşınmıştır.

- **AutoMapper** kullanılarak, entity'ler ile DTO'lar arasında dönüşümler otomatik hale getirilmiştir.

- **Entity Framework Core** ile veritabanı işlemleri gerçekleştirilmiştir.

- **Validation** model üzerinde `[Required]`, `[MaxLength]` gibi attribute'lar ile doğrulamalar yapılmıştır.

---
## Katmanlarda Kullanılan Kütüphaneler Ve Katmanlar Arası Referanslar

#### Business
##### Library
- AutoMapper 13.0.1
##### Project Referans
- DataAccess
- Entities
---
#### DataAccess
##### Library
- EntitiyFrameworkCore 6.0.36
- EntitiyFrameworkCore.Design 6.0.36
- EntitiyFrameworkCore.SqlServer 6.0.36
- EntitiyFrameworkCore.Tools 6.0.36
##### Project Referans
- Entities
---
#### Entities
##### Library
- 
##### Project Reference
-
---
#### API.SiemGrupLibraryManagementProject
##### Library
- EntitiyFrameworkCore.Design 6.0.36
- Swashbuckle.AspNetCore 6.5.0
##### Project Referans
- DataAccess
---

## Resimler

![Swagger](https://github.com/mahmutcansaribal/SiemGrupNetCoreProject/blob/main/SiemGrupLibraryManagementProject/Images/Swagger.png?raw=true)
![Schema](https://github.com/mahmutcansaribal/SiemGrupNetCoreProject/blob/main/SiemGrupLibraryManagementProject/Images/Schema.png?raw=true)
![Get](https://github.com/mahmutcansaribal/SiemGrupNetCoreProject/blob/main/SiemGrupLibraryManagementProject/Images/Get.png?raw=true)
![Post](https://github.com/mahmutcansaribal/SiemGrupNetCoreProject/blob/main/SiemGrupLibraryManagementProject/Images/Post.png?raw=true)
![Put](https://github.com/mahmutcansaribal/SiemGrupNetCoreProject/blob/main/SiemGrupLibraryManagementProject/Images/Put.png?raw=true)
