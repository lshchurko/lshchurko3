namespace buyer_homework6
{
    class BuyerDebitCard : Buyer
    {
        string paymentType = "Debit Card paymnets";
        public override void Pay()
        {
            Console.WriteLine(paymentType);
        }
    }
}
