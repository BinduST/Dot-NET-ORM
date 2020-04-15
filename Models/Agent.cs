using System;
using System.ComponentModel.DataAnnotations;

namespace dot_net_orm.Models
{
    public class Agent
    {
        [Key]
        public System.Guid agent_code { get; set; }
        public string agent_name { get; set; }
        public string working_area { get; set; }
        public int commission { get; set; }
        public string phone_no { get; set; }
        public string country { get; set; }
    }
}