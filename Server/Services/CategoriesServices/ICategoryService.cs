namespace _3Ecommerce.Server.Services.CategoriesServices
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<Category>>> GetCategories();


    }
}
