# PA202 — C# OOP Praktika Tapşırıqları

Bu repo **PA202 qrupu** tələbələri üçün hazırlanmış C# obyekt yönümlü proqramlaşdırma (OOP) tapşırıqlarını özündə saxlayır. Hər qovluqda bir layihənin tam şərti (`Readme.md`) yerləşir — tələbələr şərti oxuyub layihəni sıfırdan implement etməlidirlər.

## 📂 Layihələr

| # | Layihə | Qısa təsvir | Praktika olunan mövzular |
|---|--------|-------------|--------------------------|
| 1 | [Smartphone](Smartphone/Readme.md) | Telefonun batareya, yaddaş və kilid vəziyyətini idarə edən sadə model | Class, property, constructor, metodlar, şərti yoxlamalar |
| 2 | [Order System](Order%20System/Readme.md) | Sifariş və onlayn sifariş modeli, çatdırılma haqqının hesablanması | Constructor overloading, inheritance, `out` parametr, metod overloading |
| 3 | [Vehicle](Vehicle/Readme.md) | Nəqliyyat vasitələri iyerarxiyası — adi və elektrik avtomobil | Inheritance, `virtual`/`override`, polymorphism, `base()` constructor, validation |
| 4 | [School Management](School%20Management/Readme.md) | Tələbə və müəllim modeli olan məktəb idarəetmə sistemi | Inheritance, encapsulation, computed property-lər, `ToString()` override, exception handling |
| 5 | [Restaurant Management](Restaurant%20Management/Readme.md) | Yemək (Pizza, Fries) qiymət hesablaması olan restoran simulyasiyası | Abstract class və metod, override, interface, service layer, `TimeSpan`/`DateTime` |
| 6 | [Bank System](Bank%20System/Readme.md) | Debet və kredit kartları olan bank sistemi | Abstract class, `sealed` class, enum, indexer, extension metodlar, custom exception |
| 7 | [Cargo System](Cargo%20System/Readme.md) | Müştəri–kuryer–sifariş əlaqəli karqo sistemi | Static id artımı, enum ilə status axını, entity əlaqələri, service məntiqi, custom exception |
| 8 | [Task Management](Task%20Management/Readme.md) | Prioritet və istifadəçi təyinatı olan task idarəetmə sistemi | Enum, interface, CRUD əməliyyatları, string→enum çevrilməsi, extension metodlar, custom exception |
| 9 | [Library Management](Library%20Management/Readme.md) | Kitab əlavə etmə, axtarış və qiymət analizi olan kitabxana sistemi | `List<T>`, filter/axtarış metodları, aqreqasiya (min/max/orta qiymət), extension metodlar, custom exception |
| 10 | [Hotel Reservation](Hotel%20Reservation/Readme.md) | Qonaq–otaq–rezervasiya əlaqəsi, tarix toqquşması və ödəniş axını olan sistem | Çoxlu entity əlaqəsi, enum status axını, custom exception-lar, extension metodlar, JSON ilə data saxlama |

> Layihələr sadədən mürəkkəbə doğru sıralanıb — yeni başlayanlar üçün **Smartphone** ilə başlamaq tövsiyə olunur.

## 🎯 Əhatə olunan mövzular

- **OOP əsasları** — class, object, property, constructor
- **Inheritance & Polymorphism** — base/derived class-lar, `virtual`, `override`, `abstract`, `sealed`
- **Encapsulation** — property validation, computed (yalnız `get`) property-lər
- **Enum-lar** — status və kateqoriya əsaslı axınlar (`OrderStatus`, `PaymentStatus` və s.)
- **Interface & Service layer** — `IService` interfeysləri və onların implementasiyası
- **Extension metodlar** — mövcud class-lara əlavə funksionallıq
- **Custom Exception-lar** — `ConflictException`, `NotFoundException` və s.
- **Indexer, static üzvlər, constructor overloading**
- **Kolleksiyalar** — massiv və `List<T>` ilə iş, filter və axtarış
- **JSON ilə işləmə** — sadə data persistence (Hotel Reservation)

## 🚀 İstifadə qaydası

1. Üzərində işləmək istədiyiniz layihənin qovluğuna keçin və `Readme.md` faylındakı şərti diqqətlə oxuyun.
2. Həmin qovluqda yeni Console App yaradın:
   ```bash
   dotnet new console
   ```
3. Şərtdəki class, enum, interface və servisləri mərhələli şəkildə implement edin.
4. `Program.cs`-də şərtdə verilən nümunə ssenariləri (test case-ləri) işlədərək nəticəni yoxlayın.
5. Exception ssenarilərini mütləq test edin — düzgün exception atılması qiymətləndirmənin bir hissəsidir.

## 📌 Qeyd

Bu repoda yalnız **tapşırıq şərtləri** yerləşir — hazır həllər yoxdur. Hər tələbə həlli öz repository-sində saxlamalıdır.
