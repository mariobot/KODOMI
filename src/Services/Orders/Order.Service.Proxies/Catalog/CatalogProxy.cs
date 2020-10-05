using Microsoft.Extensions.Options;
using Order.Service.Proxies.Catalog.Commands;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Order.Service.Proxies.Catalog
{
    public interface ICatalogProxy
    {
        Task UpdateStockAsync(ProductInStockUpdateStockCommand command);
    }

    public class CatalogProxy : ICatalogProxy
    {
        private readonly ApiUrl _apiUrl;
        private readonly HttpClient _httpClient;

        public CatalogProxy(
            HttpClient httpClient,
            IOptions<ApiUrl> apiUrl)
            //IHttpContextAccessor httpContextAccessor)
        {
            //httpClient.AddBearerToken(httpContextAccessor);
            _httpClient = httpClient;
            _apiUrl = apiUrl.Value;
        }

        public async Task UpdateStockAsync(ProductInStockUpdateStockCommand command)
        {
            var content = new StringContent(
                JsonSerializer.Serialize(command),
                Encoding.UTF8,
                "application/json"
            );

            var request = await _httpClient.PutAsync(_apiUrl.CatalogURL + "v1/stocks", content);

            request.EnsureSuccessStatusCode();
        }
    }
}
