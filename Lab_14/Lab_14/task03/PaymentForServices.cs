namespace Task_3
{
    // Клас PaymentForServices
    public class PaymentForServices
    {
        public int ID { get; set; }
        public string TelephoneNumber { get; set; }
        public string ATSNumber { get; set; }
        public decimal Cost { get; set; }
        public bool IsPaid { get; set; }
    }
}
