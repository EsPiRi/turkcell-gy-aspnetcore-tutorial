namespace TurkcellGyAspNetCoreApp.Web.Models
{
    public class ProductRepository
    {
        private static List<Product> _products = new List<Product>()
        {
            new () { Id = 1, Name = "Kalem", Price = 100, Stock = 200 },
            new () { Id = 2, Name = "Defter", Price = 200, Stock = 300 },
            new () { Id = 3, Name = "Silgi", Price = 300, Stock = 400 }
        };

        public List<Product> GetAll() => _products;
        public void AddProduct(Product newProduct) => _products.Add(newProduct);

        public void RemoveProduct(int id)
        {
            var product = _products.FirstOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new Exception($"Bu id({id}'ye sahip ürün bulunmamaktadır.");
            }

            _products.Remove(product);
        }
        public void UpdateProduct(Product updatedProduct)
        {
            var product = _products.FirstOrDefault(p => p.Id == updatedProduct.Id);
            if (product == null)
            {
                throw new Exception($"Bu id({updatedProduct.Id}'ye sahip ürün bulunmamaktadır.");
            }

            product.Name = updatedProduct.Name;
            product.Price = updatedProduct.Price;
            product.Stock = updatedProduct.Stock;
            var index = _products.FindIndex(x => x.Id == updatedProduct.Id);
            _products[index] = product;
        }


    }
}
