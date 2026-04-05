
# Inheritance Tapşırığı — Nəqliyyat Sistemi

1. Bir `Vehicle` base class-ı yaradın. Class daxilində aşağıdakı property-ləri yaradın:
	- Brand
	- Model
	- Year
	- MileageKm
	- IsRunning

2. `Vehicle` constructor aşağıdakı məlumatları qəbul etməlidir:
	- Brand
	- Model
	- Year

	Qaydalar:
	- `Year` 1886-dan kiçik ola bilməz.
	- `MileageKm` default olaraq `0` olmalıdır.
	- `IsRunning` default olaraq `false` olmalıdır.

3. `Vehicle` class daxilində aşağıdakı method-ları yaradın:
	- `StartEngine()`
		Mühərriki işə salır (`IsRunning = true`).

	- `StopEngine()`
		Mühərriki söndürür (`IsRunning = false`).

	- `Drive(int km)` (virtual)
		Avtomobili sürür və `MileageKm` artırır.

		Şərt:
		```text
		km > 0
		IsRunning == true
		```

	- `VehicleInfo()` (virtual)
		Nəqliyyat vasitəsi haqqında məlumat göstərir.
		Məlumat aşağıdakı formatda göstərilməlidir:
		```
		Type: Vehicle
		Brand: Toyota
		Model: Corolla
		Year: 2018
		Mileage: 120000 km
		Running: Yes
		```

4. `Vehicle`-dan miras alan `Car` class-ı yaradın.
	- Əlavə property-lər:
		- FuelCapacityLiters
		- FuelLiters
		- FuelConsumptionPer100Km (məsələn 7.5)

	- Constructor aşağıdakı məlumatları qəbul etməlidir:
		- Brand
		- Model
		- Year
		- FuelCapacityLiters
		- FuelConsumptionPer100Km
		- InitialFuelLiters

		Qaydalar:
		```text
		FuelCapacityLiters > 0
		FuelConsumptionPer100Km > 0
		0 <= InitialFuelLiters <= FuelCapacityLiters
		```

	- `Refuel(double liters)`
		Yanacaq doldurur.

		Şərt:
		```text
		liters > 0
		FuelLiters + liters <= FuelCapacityLiters
		```

	- `Drive(int km)` method-un override edin.
		Sürüş zamanı yanacaq sərf olunmalıdır.

		Sərf:
		```text
		requiredLiters = (km / 100.0) * FuelConsumptionPer100Km
		```

		Əlavə şərt:
		```text
		FuelLiters >= requiredLiters
		```

	- `VehicleInfo()` method-un override edin və `Type` sətrini `Car` göstərin, əlavə olaraq `Fuel` sətri də çıxsın:
		```
		Fuel: 20.0L / 50.0L
		```

5. `Vehicle`-dan miras alan `ElectricCar` class-ı yaradın.
	- Əlavə property-lər:
		- BatteryCapacityKWh
		- BatteryKWh
		- ConsumptionKWhPer100Km (məsələn 15)

	- Constructor aşağıdakı məlumatları qəbul etməlidir:
		- Brand
		- Model
		- Year
		- BatteryCapacityKWh
		- ConsumptionKWhPer100Km
		- InitialBatteryKWh

		Qaydalar:
		```text
		BatteryCapacityKWh > 0
		ConsumptionKWhPer100Km > 0
		0 <= InitialBatteryKWh <= BatteryCapacityKWh
		```

	- `Charge(double kwh)`
		Batareyanı doldurur.

		Şərt:
		```text
		kwh > 0
		BatteryKWh + kwh <= BatteryCapacityKWh
		```

	- `Drive(int km)` method-un override edin.
		Sürüş zamanı enerji sərf olunmalıdır.

		Sərf:
		```text
		requiredKWh = (km / 100.0) * ConsumptionKWhPer100Km
		```

		Əlavə şərt:
		```text
		BatteryKWh >= requiredKWh
		```

	- `VehicleInfo()` method-un override edin və `Type` sətrini `ElectricCar` göstərin, əlavə olaraq `Battery` sətri də çıxsın:
		```
		Battery: 30.0kWh / 60.0kWh
		```

6. `Program.cs` daxilində aşağıdakıları edin:
	- Həm `Car`, həm də `ElectricCar` üçün obyekt yaradın.
	- Derived ctor-larda `base(...)` constructor çağırışından istifadə edin.
	- Ən azı 1 dəfə `Drive` method-un polymorphism ilə çağırın:
		```csharp
		Vehicle v = new ElectricCar(...);
		v.StartEngine();
		v.Drive(120);
		```
	- `StartEngine/StopEngine`, `Drive`, `Refuel/Charge`, `VehicleInfo` çağırışlarını test edin.
