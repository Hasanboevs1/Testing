namespace IntegrationTesting;
public class ProductService 
{
        private readonly IProductRepository _productRepository;
        public readonly List<Product> _products = new List<Product>();
        public ProductService(IProductRepository productRepository) => _productRepository = productRepository;

        public async Task<Product> GetProduct(int id) => await _productRepository.GetByIdAsync(id);
        
}