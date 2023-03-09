namespace _3Ecommerce.Client.CategoryServices
{
    public interface ICategoryService
    {
        List<Category> Categories { get; set; }

        Task GetCategories();
    }
}
