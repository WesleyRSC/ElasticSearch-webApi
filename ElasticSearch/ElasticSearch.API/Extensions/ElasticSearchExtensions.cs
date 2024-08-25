using Elastic.Clients.Elasticsearch;
using Elastic.Transport;
using ElasticSearch.API.Models;

namespace ElasticSearch.API.Extensions;

public static class ElasticSearchExtensions
{
    public static void AddElasticSearch(this IServiceCollection services, IConfiguration configuration)
    {
        var url = configuration["ELKConfiguration:Uri"];
        var defaultIndex = configuration["ELKConfiguration:Index"];
        var username = configuration["ELKConfiguration:User"];
        var password = configuration["ELKConfiguration:Password"];

        var settings = new ElasticsearchClientSettings(new Uri(url))
            .CertificateFingerprint("83f04590fa4ac7dc1de13a5ead052836cee39312cd753d0704144c3abe6faa15")
            .Authentication(new BasicAuthentication(username, password))
                .PrettyJson();

        AddDefaultMappings(settings);

        var client = new ElasticsearchClient(settings);

        services.AddSingleton(client);

        //CreateIndex(client, defaultIndex);
    }

    private static void AddDefaultMappings(ElasticsearchClientSettings settings)
    {
        settings.DefaultMappingFor<Product>(p => p.IndexName("my-products"));
    }

    private static async void CreateIndex(ElasticsearchClient client, string indexName)
    {
        Product product = new Product
        {
            Id = 1,
            Title = "Blue-Notebook",
            Description = "caderno azul de linhas pautadas",
            Quantity = 25,
            Price = 10
        };

        var response = await client.IndexAsync(product);
    }
}
