﻿namespace buyer_homework6
{
    class BuyerCash : Buyer
    {
        string paymentType = "Cash paymnets";

        public override void pay()
        {
            
        Console.WriteLine(paymentType);
        }
    }
}
