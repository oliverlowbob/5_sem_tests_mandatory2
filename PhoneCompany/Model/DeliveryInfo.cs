namespace PhoneCompany.Model
{
    public class DeliveryInfo
    {
        public string DeliveryId { get; set; }
        public Customer Customer { get; set; }
        public string Adress { get; set; }
        public Delivery Delivery { get; set; }
        public OrderInfo OrderInfo { get; set; }
    }

}
