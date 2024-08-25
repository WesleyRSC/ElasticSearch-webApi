using Microsoft.AspNetCore.Mvc;
using Nest;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElasticSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsTreeController : ControllerBase
    {
        private readonly IElasticClient _elasticClient;

        private readonly ILogger<ProductsTreeController> _logger;
        public ProductsTreeController(IElasticClient client, ILogger<ProductsTreeController> logger)
        {
            _elasticClient = client;
            _logger = logger;
        }

        // GET: api/<ProductsTreeController>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/<ProductsTreeController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/<ProductsTreeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<ProductsTreeController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<ProductsTreeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
