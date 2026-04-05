# Order Sistemi

1. `Order` adında class yaratmalı
2. Fieldlar:
    - Id
    - Məhsulun adı
    - Məhsulun sayı
    - Məhsulun qiyməti
3. Dəyərlər Construcor ilə verilməlidir. 2 ədəd constructor olmalıdır:
    1. Əgər Obyekt yaradılarkən Məhsulun sayı göndərilərsə, `Məhsul sayı` field-ı həmin dəyərə bərabər olmalıdır.
    2. Əgər göndərilməzsə 1-ə
4. Yaradılmalı olan metodlar
    1. Sifarişin ümumi məbləğini geri qaytaran metod
    2. Metoda `n` dəyəri göndəriləcək. Sifarişdə olan məhsulun sayını `n` qədər artıran metod. Əgər `n` göndərilməsə 1 vahid artırılacaq.
    3. `Sifariş məlumatlarını ekrana yazdıram metod:
    Çıxış nümunəsi:
        ```
        Sifariş ID: 1
        Məhsul: Kitab
        Sayı: 2
        Qiymət: 15 AZN
        Ümumi Məbləğ: 30 AZN
        ```
    4. `diff` adında dəyəri olmayan bir dəyişən təyin edəcəm. Məhsulun qiymətini dəyişmək üçün elə bir metod yaradın ki, metod-a məhsulun yeni qiymətini göndərim və o metod həm məhsulun qiymətini dəyişsin, həm də məhsulun köhnə qiyməti ilə yeni qiyməti arasındakı fərqi mənə `diff` dəyişəni vasitəsilə qaytarsın.
        ```cs
        int diff;
        order1.ChangePrice(....);
        Console.WriteLine(diff); // Yeni və köhnə qiymət arasındakı fərq
        Console.WriteLine(order1.Price); // Yeni qiymət
        ```
        **Şərti başa düşməyən təkrar soruşsun*
5. `Order` class-ından miras alan, `OnlineOrder` class-ı yaratmalı
6. Fieldlar:
    - Id
    - Məhsulun adı
    - Məhsulun sayı
    - Məhsulun qiyməti
    - Sifarişin məsafəsi
7. Dəyərlər constructor vasitəsilə verilməlidir
8. Yaradılmalı olan metodlar:
    1. Hər 5km məsafə üçün 2 manat çatdırılma ödənişi alınmalıdır. Çatdırılma üçün olan ümumi ödənişi geri qaytaran metod.
    2. Çatıdırılma məbləği ilə birlikdə ümumi məbləği detallı şəkildə göstərən metod. 
    Çıxış nümunəsi:
        ```
        Sifariş ID: 1
        Məhsul: Kitab
        Sayı: 2
        Qiymət: 15 AZN
        Ümumi Məbləğ: 30 AZN
        Məsafə: 12 Km
        Çatıdırlma: 3 AZN
        Ümumi Məbləğ Çatdırılma ilə: 33 AZN
        ```