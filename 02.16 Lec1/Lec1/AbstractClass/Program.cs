using AbstractClass.Models;




Worker worker = new();
Student student = new();

//worker.Age();
//student.Age();

//worker.Role();
//student.Role();

Student[] students = new Student[4]
{
    new Student { Name = "Elvindsa", Point = 90 },
    new Student { Name = "Elnurdsgerfgrd", Point = 80 },
    new Student { Name = "Elmirfsfews", Point = 70 },
    new Student { Name = "Samirfefd", Point = 85 }
};

Array.Sort(students);

foreach (var item in students)
{
    Console.WriteLine(item);
}