namespace _3Ecommerce.Server.Services.CategoriesServices
{
    public class CategoryService : ICategoryService
    {
        private readonly Contexto _contexto;
        public CategoryService(Contexto contexto)
        {
            _contexto = contexto;
        }
        public async Task<ServiceResponse<List<Category>>> GetCategories()
        {
            var categories = await _contexto.Category.ToListAsync();
            return new ServiceResponse<List<Category>>
            {
                Data = categories
            };
        }
    }
}
