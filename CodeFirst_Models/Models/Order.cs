using CodeFirst_Models.Abstract;
using System;
using System.Collections.Generic;

namespace CodeFirst_Models.Models
{
    public class Order : BaseEntityIdentity

    {
        public virtual Person PersonObj { get; set; }

        public int PersonID { get; set; }

        public ICollection<OrderDetails> orderDetailsObj { get; set; }

        public DateTime OrderDate { get; set; } = DateTime.Now;

        public bool IsPaid { get; set; }

        public Order()
        {
            orderDetailsObj = new List<OrderDetails>();
        }
    }
}
