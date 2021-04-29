using System.Collections.Generic;

namespace PhoneCompany.Model
{
    public class OrderInfo
    {
        public Customer Customer { get; set; }
        public string Adress { get; set; }
        public List<Item> Items { get; set; }
    }
}
