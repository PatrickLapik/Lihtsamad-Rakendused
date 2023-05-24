using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectToObjectMapper
{
    internal class OrderModel
    {
        public int Id { get; set; }
        public string CustomerName { get; set; }
        public string DeliveryAddress { get; set; }
        public DateTime EstimatedDeliveryDate { get; set; }
        public string OrderReference { get; set; }
    }
}
