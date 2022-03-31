namespace buyer_homework6
{
    class BuyerCreditCard : Buyer
    {
        string paymentType = "Credit Card paymnets";
        public override void Pay()
        {
            Console.WriteLine(paymentType);
        }
    }
}
