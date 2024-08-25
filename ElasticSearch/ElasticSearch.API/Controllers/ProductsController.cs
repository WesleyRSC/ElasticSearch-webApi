using Elastic.Clients.Elasticsearch;
using ElasticSearch.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace ElasticSearch.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly ElasticsearchClient _elasticClient;

        private readonly ILogger<ProductsController> _logger;

        private readonly string _indexName = "my-products";

        public ProductsController(ElasticsearchClient client, ILogger<ProductsController> logger)
        {
            _elasticClient = client;
            _logger = logger;
        }

        [HttpGet]
        public async Task<IActionResult> GetProducts(string? keyword)
        {
            var result = await _elasticClient.SearchAsync<Product>(
                s => s.Query(q =>
                    q.QueryString(
                        d => d.Query('*' + keyword + '*')
                    )
                ).Size(1000).Index(_indexName)
             );

            return Ok(result.Documents.ToList());
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(Product product)
        {
            var response = await _elasticClient.CreateAsync(product, index: _indexName);

            return Ok(response);
        }
    }
}
