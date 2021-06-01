using System;
using System.Collections.Generic;
using System.Text;

namespace e_commerce.Aggregates.OrderAgg
{
    public enum OrderStatus
    {
        New = 0,
        Submitted = 1,
        OutForDelivered = 2,
        Delivered = 3
    }
}
