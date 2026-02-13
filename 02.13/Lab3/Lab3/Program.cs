using Lab3.Models;


Person person = new Person(1, "John Doe", new DateTime(2022, 2, 2));


Console.WriteLine(person.BirthDate.ToString("dd MMMM yyyy"));