
namespace IntegrationTesting;
public interface IProductRepository
{
        Task<Product> GetByIdAsync(int id);
}