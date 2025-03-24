namespace Shopping.Web.Services
{
    public interface ICatalogService
    {
        Task<GetProductsResponse> GetProducts(int? PageNumber = 1, int? PageSize = 10);
        Task<GetProductByIdResponse> GetProductById(Guid id);
        Task<GetProductByCategoryResponse> GetProductByCategory(string category);
    }
}
