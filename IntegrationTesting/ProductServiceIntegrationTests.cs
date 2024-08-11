using Xunit;
using Moq;

public class ProductServiceIntegrationTests
{
    [Fact]
    public void GetProduct_ShouldReturnProduct_WhenProductExists()
    {
        // Arrange
        var mockRepository = new Mock<IProductRepository>();
        var productId = 1;
        var expectedProduct = new Product
        {
            Id = productId,
            Name = "Sample Product",
            Price = 9.99m
        };

        mockRepository.Setup(repo => repo.GetProductByIdAsync(productId))
                      .Returns(expectedProduct);

        var productService = new ProductService(mockRepository.Object);

        // Act
        var product = productService.GetProduct(productId);

        // Assert
        Assert.NotNull(product);
        Assert.Equal(expectedProduct.Id, product.Id);
        Assert.Equal(expectedProduct.Name, product.Name);
        Assert.Equal(expectedProduct.Price, product.Price);
    }
}
