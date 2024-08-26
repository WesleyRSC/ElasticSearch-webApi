using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using ElasticSearch.API.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace ElasticSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsTreeController : ControllerBase
    {
        private readonly ElasticsearchClient _elasticClient;

        private readonly ILogger<ProductsTreeController> _logger;
        public ProductsTreeController(ElasticsearchClient client, ILogger<ProductsTreeController> logger)
        {
            _elasticClient = client;
            _logger = logger;
        }

        // GET: api/<ProductsTreeController>
        [HttpGet]
        public async Task<IActionResult> GetAllProducts()
        {
            var body = """
            {
              "query": {
                "match": {
                  "Materials": "Polyester"
                }
              }
            }
            """;

            var result = await _elasticClient.Transport.RequestAsync<StringResponse>(Elastic.Transport.HttpMethod.GET, "product-tree/_search", PostData.String(body));

            return Ok(result.Body);
        }

        // GET api/<ProductsTreeController>/5
        [HttpGet("FilterByKeyword")]
        public async Task<IActionResult> GetProducts(string? keyword)
        {
            var result = await _elasticClient.SearchAsync<ProductTree>(
                s => s.Query(q =>
                    q.QueryString(
                        d => d.Query('*' + keyword + '*').Fields(fields: "description")
                    )
                ).Size(1000).Index("product-tree")
             );

            return Ok(result.Documents.ToList());
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
