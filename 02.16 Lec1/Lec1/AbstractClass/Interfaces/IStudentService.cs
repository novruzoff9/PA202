using AbstractClass.Models;

namespace AbstractClass.Interfaces;


internal interface IStudentService
{
    public void Add(Student student);
    public void GetAll();
}

internal class StudentService : Student, IStudentService
{
    public string Name { get; set; }

    public void Test()
    {
        Console.WriteLine("Test");
    }
    public void Add(Student student)
    {
        throw new NotImplementedException();
    }

    public void GetAll()
    {
        throw new NotImplementedException();
    }
}
