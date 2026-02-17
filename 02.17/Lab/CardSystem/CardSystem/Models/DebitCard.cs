namespace CardSystem.Models;

class DebitCard : Card
{
    public override bool WithDraw(double amount)
    {
        if(Balance >= amount)
        {
            Balance -= amount;
            return true;
        }
        return false;
    }
}
