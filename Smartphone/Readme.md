# SmartPhone Sistemi

1. Bir `SmartPhone` class-ı yaradın. Class daxilində aşağıdakı property-ləri yaradın:
    - Brand
    - Model
    - BatteryLevel
    - StorageCapacity
    - UsedStorage
    - IsLocked

2. Constructor aşağıdakı məlumatları qəbul etməlidir:
    - Brand
    - Model
    - StorageCapacity

3. Class daxilində aşağıdakı method-ları yaradın:
    -  `UnlockPhone`:  
    Telefon kilidlidirsə açır.
    `IsLocked` property istifadə olunmalıdır

    - `InstallApp(int size)`
    Telefon yaddaşına tətbiq quraşdırır.

    Şərt:
    ```text
    UsedStorage + size <= StorageCapacity
    ```

    - `ChargeBattery(int amount)`

    Telefonu şarj edir.

    Şərt:
    
    ```
    BatteryLevel 100-dən çox ola bilməz
    ```

    - `PhoneInfo()`

    Telefon haqqında məlumat göstərir.

    Məlumat aşağıdakı formatda göstərilməlidir:

    ```
    Brand: Apple
    Model: iPhone 14
    Battery Level: 80%
    Storage: 256GB (Used: 100GB)
    Is Locked: No
    ```