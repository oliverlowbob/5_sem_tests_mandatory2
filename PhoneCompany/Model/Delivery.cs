namespace PhoneCompany.Model
{
    public class Delivery
    {
        public string Type { get; set; }
        public int Price { get; set; }
        public Company company { get; set; }
    }
}
