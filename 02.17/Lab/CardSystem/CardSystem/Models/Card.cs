using CardSystem.Enums;

namespace CardSystem.Models;

internal abstract class Card
{
    public int Id { get; set; }
    public double Balance { get; set; }
    public double Bonus { get; set; }
    private string _cardNumber;
    public string CardNumber
    {
        get
        {
            return _cardNumber;
        }
        set
        {
            if (value.Length == 16)
                _cardNumber = value;
            else
                Console.WriteLine("Duzgun daxil edin");
        }
    }
    public Bank Bank { get; set; }
    public abstract bool WithDraw(double amount);
}
