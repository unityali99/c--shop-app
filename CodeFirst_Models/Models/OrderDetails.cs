using CodeFirst_Models.Abstract;

namespace CodeFirst_Models.Models
{
    public class OrderDetails : BaseEntityIdentity
    {
        public virtual Gun GunObj { get; set; }

        public int GunID { get; set; }

        public int Quantity { get; set; }

        public virtual Order OrderObj { get; set; }

        public int OrderID { get; set; }
    }
}
