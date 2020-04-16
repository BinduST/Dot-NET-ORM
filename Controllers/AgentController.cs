using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using dot_net_orm.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace dot_net_orm.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AgentController : ControllerBase
    {
        private readonly Context _context;
        private readonly ILogger<AgentController> _logger;

        public AgentController(Context context, ILogger<AgentController> logger)
        {
            _context = context;
            _logger = logger;
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
