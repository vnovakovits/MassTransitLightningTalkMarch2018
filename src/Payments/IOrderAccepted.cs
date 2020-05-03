using System.Collections.Generic;

namespace Messages
{
    public interface IOrderAccepted
    {
        IList<Product> Products { get; }
    }
}