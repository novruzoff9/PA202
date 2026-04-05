# 20 fevral
## Task idarəetmə sistemi
1. `TaskStatus` adlı enum
    - ToDo
    - InProgress
    - Done
2. `MyTask` adında class yaradılacaq
    - Id
    - Başlıq
    - İzahat
    - Created
    - DeadLine (tarix və saat olaraq)
    - TaskStatus (enum)
    - `Id` dəyəri Constructor vasitəsilə statik olaraq avtomatik veriləcək, `Created` dəyəri constructor-da hazırki vaxtı göstərəcək.
    - `ToString()` override edilməli
3. `ITaskService` interfeysi yaradırıq
    - 3.1. Siyahıya Task əlavə etmək üçün metod. (eyni başlıqlı Task artırılsa `ConflictException` qaytaracaq)
    - 3.2 Title-a görə Siyahıdan task-i tapan metod
    - 3.3 Göndərilən Status-da olan task-ları tapan metod
    - 3.4 Göndərilən Id-də olan elementi siyahıdan silmək üçün metod
4. `TaskService` class-ı yaradırıq
    - Task-lar üçün statik Massiv saxlayır özündə
    - 3.1-deki tapsirigda Siyahıya Task əlavə etmək üçün metodda eyni başlıqlı Task artırılsa `ConflictException` qaytaracaq
    - 3.2 -deki Title-a görə Siyahıdan task-i tapan metod-da eger hec bir task tapilmasa `NotFoundException` qaytarsın
    - **3.3 string-i enum-a cevirmeyi goster**
    - 3.4 -də göndərilən Id-də element tapılmasa `NotFoundException`
5. Extension metodlar `TaskHelper` class-ı
    - Task-ın bitməyinə nə qədər müddət qaldığını qaytaran metod
    - Task üçün nə qədər vaxt ayrıldığını göstərən metod

## Əlavə funksionallıq
1. `TaskPriority` adlı enum yaradılacaq və aşağıdakı dəyərləri saxlayacaq:
    - Low
    - Medium
    - High
2. `MyTask` class-ına `Priority` adlı bir property əlavə ediləcək və bu property `TaskPriority` enum tipində olacaq.
3. `ITaskService` interfeysində aşağıdakı metodlar əlavə ediləcək:
    - 3.5 Göndərilən Prioritetdə olan task-ları tapan metod
    - 3.6 Task-ın Prioritetini dəyişdirmək üçün metod
4. `TaskService` class-ında aşağıdakı metodlar əlavə ediləcək:
    - 3.5 -deki tapsirigda Göndərilən Prioritetdə olan task-ları tapan metod-da eger hec bir task tapilmasa `NotFoundException` qaytarsın
    - 3.6 -deki Task-ın Prioritetini dəyişdirmək üçün metodda eğer göndərilən Id-də element tapılmasa `NotFoundException` qaytarsın

## Assignment funksionallıq
1. `User` adlı class yaradılacaq
    - Id
    - Name
    - Email
2. `TaskAssignment` adlı class yaradılacaq
    - Id
    - TaskId
    - UserId
    - AssignedDate
3. `IUserService` adlı interfeys yaradılacaq
    - 2.1 İstifadəçi əlavə etmək üçün metod
    - 2.2 Email-ə görə istifadəçini tapan metod
4. `UserService` class-ı yaradılacaq
    - İstifadəçilər üçün statik Massiv saxlayır özündə
    - 2.1 -deki tapsirigda İstifadəçi əlavə etmək üçün metod-da eyni email-li istifadəçi artırılsa `ConflictException` qaytaracaq
    - 2.2 -deki Email-ə görə istifadəçini tapan metod-da eger hec bir istifadəçi tapilmasa `NotFoundException` qaytarsın
3. `ITaskService` interfeysində aşağıdakı metodlar əlavə ediləcək:
    - 3.7 Task-ı istifadəçiyə təyin etmək üçün metod
    - 3.8 İstifadəçiyə təyin edilmiş task-ları tapan metod
4. `TaskService` class-ında aşağıdakı metodlar əlavə ediləcək:
    - 3.7 -deki tapsirigda Task-ı istifadəçiyə təyin etmək üçün metodda eğer göndərilən TaskId və UserId-də element tapılmasa `NotFoundException` qaytarsın
    - 3.8 -deki İstifadəçiyə təyin edilmiş task-ları tapan metod-da eger hec bir task tapilmasa `NotFoundException` qaytarsın