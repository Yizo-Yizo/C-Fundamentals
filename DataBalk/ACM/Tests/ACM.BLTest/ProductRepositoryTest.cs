using ACM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ACM.BLTest
{
    [TestClass]
    public class ProductRepositoryTest
    {
        [TestMethod]
        public void RetrieveTest()
        {
            // Arrange
            var productRepository = new ProductRepository();

            var expected = new Product(2)
            {

                CurrentPrice = 15.96M,
                ProductDescription = "Assorted Size set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers"
            };

            // Act 
            var actual = productRepository.Retrieve(2);

            Assert.AreEqual(expected.CurrentPrice, actual.CurrentPrice);
            Assert.AreEqual(expected.ProductDescription, actual.ProductDescription);
            Assert.AreEqual(expected.ProductName, actual.ProductName);
        }

        [TestMethod]
        public void SateTestValid()
        {
            // Arrange
            var productReposritory = new ProductRepository();
            var updatedProduct = new Product(2)
            {
                CurrentPrice = 18M,
                ProductDescription = "Assorted Size set of 4 Bright Yellow Mini Sunflowers",
                ProductName = "Sunflowers",
                HasChanges = true
            };

            // Act
            var actual = productReposritory.Save(updatedProduct);

            // Assert
            Assert.AreEqual(true, actual);
        }
    }
}
