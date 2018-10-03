namespace Entities
{
    public class PaymentInfo
    {
        public PaymentInfo(int pinCode, string cardNo)
        {
            this.PinCode = pinCode;
            this.CardNo = cardNo;
        }

        public int PinCode { get; }
        public string CardNo { get; }
    }
}