namespace Lab3.Models;

internal class Person
{
    public int Id { get; }
    private string _fullName;
    public string FullName
    {
        get
        {
            return _fullName;
        }
        set
        {
            if(!string.IsNullOrWhiteSpace(value))
            {
                _fullName = value;
            }
            else
            {
                Console.WriteLine("Boş dəyər verilə bilməz");
            }
        }
    }

    public DateTime BirthDate
    {
        get
        {
            return field;
        }
        set
        {
            if(value > DateTime.Now)
                Console.WriteLine("Gelecek Tarix ola bilmez");
            else
                field = value;
        }
    }

    public int Age
    {
        get
        {
            TimeSpan diff = DateTime.Now - BirthDate;
            return diff.Days / 365;
        }
    }

    public DateTime RegistrationDate { get; }

    public Person(int id, string fullName, DateTime birthDate)
    {
        Id = id;
        FullName = fullName;
        BirthDate = birthDate;
        RegistrationDate = DateTime.Now;
    }

    public virtual string GetInfo()
    {
        return $"Id: {Id}, FullName: {FullName}, BirthDate: {BirthDate}, Age: {Age}, RegistrationDate: {RegistrationDate}";
    }

    public virtual string GetRole()
    {
        return "Person";
    }
}
