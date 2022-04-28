using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace Semester2Project
{
    public class Orders
    {
        public int OrdersID { get; set; }
        public string OrdersName { get; set; }
        public virtual List<OrdersCost> OrdersCost { get; set; }
        public List<OrdersDetails> OrdersDetails { get; set; }
    }
    public class OrdersCost
    {
        public int OrdersCostID { get; set; }
        public int Stone { get; set; }
        public int Wood { get; set; }
        public int Thatch { get; set; }
        public int Metal { get; set; }
        public int CementingPaste { get; set; }
        public int Cryatal { get; set; }
        public int Polymer { get; set; }
        public int OrdersID { get; set; }
        public Orders Orders { get; set; }

    }
    public class OrdersDetails
    {
        public int OrdersDetailsID { get; set; }
        public string Item { get; set; }
        public int OrdersID { get; set; }
        public virtual Orders Orders { get; set; }
    }
    public class OrdersData : DbContext
    {
        public OrdersData() : base("OrdersData") { }

        public DbSet<Orders> Orders { get; set; }
        public DbSet<OrdersCost> OrdersCost { get; set; }
        public DbSet<OrdersDetails> OrdersDetails { get; set; }
    }
}
