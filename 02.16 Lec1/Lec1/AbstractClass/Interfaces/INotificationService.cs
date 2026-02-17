namespace AbstractClass.Interfaces;

internal interface INotificationService
{
    void Send();
}

public class EmailNotificationService : INotificationService
{
    public void Send()
    {
        Console.WriteLine("Email notification sent.");
    }
}

public class SmsNotificationService : INotificationService
{
    public void Send()
    {
        Console.WriteLine("SMS notification sent.");
    }
}