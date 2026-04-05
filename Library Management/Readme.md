# Kitabxana İdarəetmə Sistemi

1. Yalnız 1 class yaradılacaq: `Book`
    - `Id` (statik olaraq artacaq)
    - `Title`
    - `Author`
    - `PageCount`
    - `Price`
    - `StockCount`
    - `Genre` (enum)
    - `CreatedAt` (default olaraq indiki vaxt)

2. Enum:
    - `Genre`: `Programming`, `Science`, `History`, `Novel`, `Other`

3. İnterfeys: `IBookService`
    - `Add(Book book)` -> kitab əlavə et
    - `GetById(int id)` -> id-yə görə kitab qaytar
    - `GetByGenre(Genre genre)` -> janra görə filter
    - `GetMostExpensiveBook()` -> ən bahalı kitab
    - `GetCheapestBook()` -> ən ucuz kitab
    - `GetAveragePrice()` -> orta qiymət
    - `CountByGenre(Genre genre)` -> janra görə say
    - `GetByPriceRange(double min, double max)` -> qiymət aralığına görə filter

4. `BookService` class-ı:
    - Daxildə statik `List<Book>` saxlasın
    - Eyni `Title + Author` ilə kitab əlavə olunarsa `ConflictException` atılsın
    - Tapılmayan id üçün `NotFoundException` atılsın

5. Extension metodlar (`BookExtensions`):
    - `GetShortInfo(this Book book)`:
        `Title - Author - Price AZN` formatında qaytarsın
    - `IsInStock(this Book book)`:
        `bool` qaytarsın
    - `ApplyDiscount(this Book book, double percent)`:
        qiyməti faiz qədər endirsin

6. Demo (Program.cs):
    - Minimum 6 kitab əlavə edin
    - Filter, add, get metodlarını test edin
    - Exceptionları handle edin:
        - duplicate kitab
        - tapılmayan id