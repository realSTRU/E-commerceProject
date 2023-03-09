namespace _3Ecommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {

        private readonly Contexto _contexto;

        public ProductService(Contexto contexto)
        {
            _contexto = contexto;   
        }

        public async Task<ServiceResponse<Product>> GetProductAsync(int productId)
        {
           var response = new ServiceResponse<Product>();
           var product = await  _contexto.Product.FindAsync(productId); 
           if(product == null)
           {
               response.Success = false;
               response.Message = "Sorry this car does not exist.";

           }
           else
           {
               response.Data = product;
           }
           return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsAsync()
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _contexto.Product.ToListAsync()
            };

            return response;
        }

        public async Task<ServiceResponse<List<Product>>> GetProductsByCategory(string categoryUrl)
        {
            var response = new ServiceResponse<List<Product>>
            {
                Data = await _contexto.Product
                .Where(p => p.Category.url.ToLower().Equals(categoryUrl.ToLower())).ToListAsync()
                
            };
            return response;
        }
    }
}
