using AbstractClass.Models;

namespace AbstractClass.Interfaces;

internal interface IPersonService
{
    public void GetName();
}

internal interface IStudentService
{
    public void Add(Student student);
    public void GetAll();
}

internal class StudentService : Student, IStudentService, IPersonService
{

    public void GetAll()
    {
        throw new NotImplementedException();
    }

    public void GetName()
    {
        throw new NotImplementedException();
    }

    void IStudentService.Add(Student student)
    {
        throw new NotImplementedException();
    }
}
