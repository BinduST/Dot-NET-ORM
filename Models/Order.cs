using System;
using System.ComponentModel.DataAnnotations;

namespace dot_net_orm.Models
{
    public class Order
    {
        [Key]
        public System.Guid ord_num { get; set; }
        public int ord_amount { get; set; }
        public int advance_amount { get; set; }
        public DateTime ord_date { get; set; }
        public System.Guid cust_code { get; set; }
        public System.Guid agent_code { get; set; }
        public string ord_description { get; set; }
    }
}