# Hotel Rezervasiya Sistemi

1. Yaradılmalı class-lar:
    - `Guest`
        - `Id` (statik olaraq artacaq)
        - `FullName`
        - `PhoneNumber` (unikal olmalıdır)
        - `Email`
    - `Room`
        - `Id` (statik olaraq artacaq)
        - `RoomNumber` (unikal olmalıdır)
        - `Capacity` (neçə nəfərlik)
        - `NightPrice`
        - `RoomType` (enum, aşağıda verilib)
        - `IsActive`
    - `Reservation`
        - `Id` (statik olaraq artacaq)
        - `GuestId`
        - `RoomId`
        - `CheckInDate`
        - `CheckOutDate`
        - `ReservationStatus` (default `Created`)
        - `PaymentStatus` (default `Pending`)
        - `Complete()` metodu:
            Yalnız `PaymentStatus = Paid` olarsa `Completed` etsin, əks halda exception atsın.

2. Enum-lar:
    - `RoomType`: `Standard`, `Deluxe`, `Suite`
    - `ReservationStatus`: `Created`, `CheckedIn`, `Completed`, `Cancelled`
    - `PaymentStatus`: `Pending`, `Paid`, `Failed`

3. İnterfeyslər:
    - `IGuestService`
        - Qonaq əlavə etmə metodu
        - PhoneNumber-a görə qonaq tapan metod
    - `IRoomService`
        - Otaq əlavə etmə metodu
        - RoomNumber-a görə otaq tapan metod
        - RoomType-a görə otaqları filtr edən metod
    - `IReservationService`
        - Yeni rezervasiya yaratmaq metodu
        - Qonağın rezervasiyalarını gətirən metod
        - Verilən tarix aralığında rezervasiyaları gətirən metod
        - Rezervasiya statusunu yeniləyən metod
        - Ödəniş statusunu yeniləyən metod

4. Service class-lar:
    - `GuestService`
        - Daxildə statik `List<Guest>` saxlasın
        - Eyni `PhoneNumber` ilə qonaq əlavə olunarsa `ConflictException` atılsın
        - Qonaq tapılmasa `NotFoundException` atılsın
    - `RoomService`
        - Daxildə statik `List<Room>` saxlasın
        - Eyni `RoomNumber` əlavə olunarsa `ConflictException` atılsın
        - Otaq tapılmasa `NotFoundException` atılsın
    - `ReservationService`
        - Daxildə statik `List<Reservation>` saxlasın
        - Rezervasiya yaradılarkən:
            - `GuestId` və `RoomId` yoxlanılsın, tapılmasa `NotFoundException`
            - `CheckOutDate <= CheckInDate` olarsa `InvalidDateRangeException` (custom)
            - Eyni otaq üçün tarixlər toqquşursa `RoomNotAvailableException` (custom)
        - Rezervasiya tamamlanarkən:
            - `PaymentStatus != Paid` olarsa `PaymentRequiredException` (custom)

5. Extension metodlar (`ReservationExtensions`):
    - `GetStayDays(this Reservation reservation)`:
        Qalma gün sayını qaytarsın
    - `CalculateTotalPrice(this Reservation reservation, Room room)`:
        `StayDays * NightPrice` hesablasın
    - `MaskPhone(this Guest guest)`:
        Telefonu `050*** ** **` formatında qaytarsın

6. Əlavə hissə (mini layihə səviyyəsi):
    - `Data` qovluğu yaradın
    - `guests.json`, `rooms.json`, `reservations.json` faylları ilə işləyin
    - Service-lərdə `GetAll()` metodları olsun
    - Yeni məlumat əlavə ediləndə uyğun json faylına yazılsın

7. Demo (Program.cs):
    - Minimum 3 qonaq, 4 otaq yaradın
    - Müxtəlif tarixlərdə rezervasiyalar yaradın
    - Tarix toqquşması və ödəniş edilmədən tamamlanma ssenarilərini test edin
    - Ən azı 3 fərqli exception ssenarisini göstərin