namespace _3Ecommerce.Client.ProductServices
{
    public class ProductService : IProductService
    {

        private readonly HttpClient _http;
        public ProductService(HttpClient http)
        {
            _http = http;
        }


        public List<Product> Products { get; set; } = new List<Product>();

        public event Action ProductChanged;

        public async Task<ServiceResponse<Product>> GetProduct(int productId)
        {
            var result = await _http.GetFromJsonAsync<ServiceResponse<Product>>($"api/Product/{productId}");
            return result;
        }

        public async Task GetProducts (string? categoryUrl = null)
        {
            var result = categoryUrl == null ?
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product") :
                await _http.GetFromJsonAsync<ServiceResponse<List<Product>>>($"api/Product/category/{categoryUrl}");
            if (result != null && result.Data!= null)
            {
                Products = result.Data;
            }

            ProductChanged.Invoke();
        }

       
    }
}
