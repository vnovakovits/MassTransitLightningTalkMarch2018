using System.Collections.Generic;

namespace Messages
{
    using System;

    public class OrderRequested
    {
        public List<Product> Products { get; set; }
        public string Name { get; set; }
        public DateTime DeliveryDate { get; set; }
    }
}
