namespace Messages
{
    using System.Collections.Generic;

    public class OrderRequested
    {
        public List<Product> Products { get; set; }
    }
}