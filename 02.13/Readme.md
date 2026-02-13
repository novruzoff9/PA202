# Lab 4 - 13 Feb
## Məktəb İdarəetmə Sistemi - Inheritance və Encapsulation:

1. `Person` adında base class yaratmalı:
   - **Public Properties:**
     - `Id` - yalnız `get`, constructor-da təyin edilir
     - `FullName` - get/set, boş və ya null ola bilməz
     - `BirthDate` - get/set, gələcək tarix ola bilməz
     - `Age` - yalnız get (hesablanır)
     - `RegistrationDate` - dəyəri yalnız constructor-da təyin edilir. İndiki tarixə bərabər olmalıdır
   - **Constructor:**
     - Parametrlər: id, fullName, birthDate
     - Validation-lar və RegistrationDate = İndiki tarix
   - **Virtual metod:**
     - `GetInfo()` - şəxs haqqında məlumat string olaraq qaytarır
     - `GetRole()` - string qaytarır


2. `Person`-dan miras alan class-lar:

   ### `Student` class-ı:
   - **Public Properties:**
     - `StudentNumber` - get/set, boş ola bilməz
     - `GPA` - get/set, 0-100 arası olmalıdır
     - `IsHonorStudent` - yalnız get (GPA > 90 olarsa true)
   - **Constructor parametrləri:** 
     - base(id, fullName, birthDate) + studentNumber, gpa
   - **Method override:**
     - `GetRole()` - "Student" qaytarır
     - `GetInfo()` - base.GetInfo() + student məlumatları
   - **Əlavə method:**
     - `IsEligibleForScholarship()` - yalnız get, true qaytarır əgər GPA > 85 və Age < 25 olarsa
     - `CalculateYearsUntilGraduation()` - yalnız get, təxminən 4 il təhsil müddəti olduğunu fərz edərək, yaşa əsasən qalan illəri qaytarır (18 yaşında başlayır)
     - `IsGraduated()` - yalnız get, true qaytarır əgər Age >= 22 olarsa

   ### `Teacher` class-ı:
   - **Public Properties:**
     - `Department` - get/set, boş ola bilməz
     - `Salary` - get/set, mənfi ola bilməz
     - `YearsOfExperience` - get/set, mənfi ola bilməz
     - `IsSeniorTeacher` - yalnız get (experience >= 10 olarsa true)
   - **Constructor parametrləri:**
     - base(id, fullName, birthDate) + department, salary, yearsOfExperience
   - **Method override:**
     - `GetRole()` - "Teacher" qaytarır
     - `GetInfo()` - base.GetInfo() + teacher məlumatları
   - **Əlavə method:**
     - `CalculateRetirementYears()` - yalnız get, təxminən 65 yaşında təqaüdə çıxacaqlarını fərz edərək, yaşa əsasən qalan illəri qaytarır

3. **Encapsulation tələbləri:**
   - Property-lərdə lazımi validation-lar olmalı
   - Constructor-larda `base()` düzgün istifadə edilməli
   - Yalnız get olan property-lər hesablanmalı (computed properties)

4. **İstifadə nümunəsi:**
   ```cs
   Student student1 = new Student(101, "Əli Məmmədov", new DateTime(2000, 5, 15), "ST2024001", 3.7);
   Teacher teacher1 = new Teacher(201, "Fatma Həsənova", new DateTime(1985, 8, 22), "Riyaziyyat", 1200, 12);
   
   Console.WriteLine(student1.GetInfo());
   // Output: Id: 101, Name: Əli Məmmədov, Age: 25, Role: Student, Student#: ST2024001, GPA: 3.7, Honor Student: Yes
   
   Console.WriteLine(teacher1.GetInfo());
   // Output: Id: 201, Name: Fatma Həsənova, Age: 40, Role: Teacher, Department: Riyaziyyat, Salary: 1200 AZN, Senior: Yes
   ```

5. **Test ssenariləri:**
   ```cs
   // Test array
   Person[] people = {
       new Student(101, "Nigar Əliyeva", new DateTime(2002, 3, 10), "ST001", 3.8),
       new Student(102, "Rəşad Cəfərov", new DateTime(2001, 7, 25), "ST002", 2.9),
       new Teacher(201, "Leyla Quliyeva", new DateTime(1980, 11, 5), "İngilis dili", 1400, 15),
       new Teacher(202, "Elşad Əhmədov", new DateTime(1990, 1, 18), "Fizika", 900, 6)
   };
   
   // Honor student-lərin sayını tap
   // Senior teacher-lərin orta maaşını hesabla
   // Hər şəxsin məlumatını çap et
   ```

**Əlavə tələblər:**
- Exception handling constructor-larda və property setter-lərində
- ToString() metodunu override edin (GetInfo() əvəzinə)
- Property validation-larında meaningful exception message-lar