using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dot_net_orm.Models;
using Microsoft.AspNetCore.Mvc;

namespace dot_net_orm.Controllers
{
    [Route("api/[controller]")]
    public class AgentController : Controller
    {
        private readonly Context _context;

        public AgentController(Context context)
        {
            _context = context;
        }
        // GET api/agent
        [HttpGet]
        public List<Agent> Get()
        {
            return _context.Agent.ToList();
        }

        // GET api/agent/1
        [HttpGet("{id}")]
        public Agent Get(Guid id) => _context.Agent.Find(id);

        // POST api/agent
        [HttpPost]
        public void Post([FromBody]string value)
        {
            _context.Agent.Add(new Agent());
            _context.SaveChanges();
        }
    }
}
