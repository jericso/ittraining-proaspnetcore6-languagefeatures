using System.Collections;
using System.Net.NetworkInformation;

namespace LanguageFeatures.Models
{

    //public IEnumerable<Product?>? Products { get; set; }
    // Applying Extension Methods to an Interface
    //public class ShoppingCart : IEnumerable<Product?>
    //{
    //    //public IEnumerable<Product?>? Products { get; set; }
    //    public IEnumerable<Product?>? Products { get; set; }

    //    public IEnumerator<Product?> GetEnumerator() => Products?.GetEnumerator() ?? Enumerable.Empty<Product?>().GetEnumerator();
    //    IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
    //}

    // Using Default Implementations in Interfaces
    public class ShoppingCart : IProductSelection
    {
        private List<Product> products = new();
        public ShoppingCart(params Product[] prods)
        {
            products.AddRange(prods);
        }
        public IEnumerable<Product>? Products { get => products; }
    }
}
