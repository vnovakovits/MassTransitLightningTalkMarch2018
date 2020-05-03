using System.Collections.Generic;

namespace Messages
{
    public class OrderRequested
    {
        public IList<IProduct> Products { get; set; }
        public string Name { get; set; }
    }
}
