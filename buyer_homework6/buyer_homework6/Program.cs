using buyer_homework6;

public class Program
{
    static void Main(string[] args)
    {

        Buyer buyer1 = new BuyerCash();
        Buyer buyer2 = new BuyerCreditCard();
        Buyer buyer3 = new BuyerCreditCard();
        Buyer buyer4 = new BuyerCash();
        Buyer buyer5 = new BuyerDebitCard();

        Buyer[] buyers = { buyer1, buyer2, buyer3, buyer4, buyer5 };

        foreach (Buyer item in buyers)
        {
            item.pay();
        }
    }
}
