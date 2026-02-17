namespace CardSystem.Models;

class CreditCard : Card
{
    public double Limit { get; set; }
    public override bool WithDraw(double amount)
    {
        if(Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        else if(Balance + Limit >= amount)
        {
            amount -= Balance;
            Balance = 0;
            Limit -= amount;
            return true;
        }
        return false;
    }
}
