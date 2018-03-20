using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Codefirst.Domain.DomainModel
{
    public class Order
    {
        public int ID { get; set; }

        public ICollection<OrderItem> Items { get; set; }

        public int UserID { get; set; }

        public User Buyer { get; set; }
    }
}
