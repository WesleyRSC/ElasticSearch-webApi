using ElasticSearch.API.Models;
using Nest;

namespace ElasticSearch.API.Extensions;

public static class ElasticSearchExtensions
{
    public static void AddElasticSearch(this IServiceCollection services, IConfiguration configuration)
    {
        var url = configuration["ELKConfiguration:Uri"];
        var defaultIndex = configuration["ELKConfiguration:Index"];
        var username = configuration["ELKConfiguration:User"];
        var password = configuration["ELKConfiguration:Password"];

        var settings = new ConnectionSettings(new Uri(url))
            .CertificateFingerprint("83f04590fa4ac7dc1de13a5ead052836cee39312cd753d0704144c3abe6faa15")
            .BasicAuthentication(username, password)
            .PrettyJson();

        AddDefaultMappings(settings);

        var client = new ElasticClient(settings);

        services.AddSingleton<IElasticClient>(client);

        CreateIndex(client, defaultIndex);
    }

    private static void AddDefaultMappings(ConnectionSettings settings)
    {
        settings.DefaultMappingFor<Product>(p =>
            p.IndexName("my-products")
            .Ignore(p => p.Id));
    }

    private static async void CreateIndex(ElasticClient client, string indexName)
    {
        //Product product = new Product
        //{
        //    Id = 1,
        //    Title = "Blue-Notebook",
        //    Description = "caderno azul de linhas pautadas",
        //    Quantity = 25,
        //    Price = 10
        //};

        //var response = await client.IndexAsync(product);

        await client.Indices.CreateAsync(indexName, i => i.Map<Product>(x => x.AutoMap()));
    }
}
