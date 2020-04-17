using System;
using System.ComponentModel.DataAnnotations;

namespace dot_net_orm.EntityFramWork.Models
{
    public class Customer
    {
        public string cust_name { get; set; }
        public string cust_city { get; set; }
        public int working_area { get; set; }
        public string cust_country { get; set; }
        public int grade { get; set; }
        public int opening_amt { get; set; }
        public int receive_amt { get; set; }
        public int payment_amt { get; set; }
        public int outstanding_amt { get; set; }
        public string phone_no { get; set; }
        public System.Guid agent_code { get; set; }
        [Key]
        public System.Guid cust_code { get; set; }
    }
}