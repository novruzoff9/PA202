namespace Lab3.Models;

internal class Student : Person
{
    public string StudentNumber
    {
        get
        {
            return field;
        }
        set
        {
            if (!string.IsNullOrWhiteSpace(value))
                field = value;
            else
                Console.WriteLine("Bos ola bilmez");
        }
    }

    public int GPA
    {
        get
        {
            return field;
        }
        set
        {
            if (value <= 100 && value > 0)
                field = value;
            else
                Console.WriteLine("bal 0 ve 100 arasinda olmalidir");
        }
    }

    public bool IsHonorStudent
    {
        get
        {
            return GPA > 90 ? true : false;
        }
    }
    public Student(string studentNumber, int gpa, int id, string fullName, DateTime birthDate) : base(id, fullName, birthDate)
    {
        StudentNumber = studentNumber;
        GPA = gpa;
    }

    public override string GetRole()
    {
        return "Student";
    }

    public override string GetInfo()
    {
        return $"Id: {Id}, FullName: {FullName}, BirthDate: {BirthDate.ToShortDateString()}, Age: {Age}, RegistrationDate: {RegistrationDate.ToShortDateString()}, StudentNumber: {StudentNumber}, GPA: {GPA}, IsHonorStudent: {IsHonorStudent}";
    }

    public void CalculateYearsUntilGraduation()
    {
        if(Age < 18)
            Console.WriteLine("Universitete baslamayib");
        else if(Age > 22)
            Console.WriteLine("Universiteden mezun olub");
        else
            Console.WriteLine($"Mezun olmaq ucun {22 - Age} il qalib");
    }

    public bool IsGraduated()
    {
        return Age > 22;
    }
}