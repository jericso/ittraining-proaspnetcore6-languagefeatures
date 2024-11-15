// Understanding Global using Statements
//using Microsoft.AspNetCore.Mvc;
//using LanguageFeatures.Models;

namespace LanguageFeatures.Controllers
{
    public class HomeController : Controller
    {
        //bool FilterByPrice(Product? p)
        //{
        //    return (p?.Price ?? 0) >= 20;
        //}

        //public ViewResult Index()
        //{
        //    //Product?[] products = Product.GetProducts();

        //    // Understanding Null State Analysis
        //    //return View(new string[] { products[0]?.Name ?? "No Value" });
        //    //return View(new string[] { products[0]!.Name });

        //    // Using String Interpolation
        //    //return View(new string[] {
        //    //    $"Name: {products[0]?.Name}, Price: { products[0]?.Price }"
        //    //});

        //    // Using Object and Collection Initializers
        //    //return View("Index", new string[] { "Bob", "Joe", "Alice" });

        //    // Using Index Initializer
        //    //Dictionary<string, Product> products = new Dictionary<string, Product> {
        //    //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //    //    ["Lifejacket"] = new Product{ Name = "Lifejacket", Price = 48.95M }
        //    // };
        //    //return View("Index", products.Keys);

        //    // Using Target-Typed New Expressions
        //    //Dictionary<string, Product> products = new()
        //    //{
        //    //    ["Kayak"] = new Product { Name = "Kayak", Price = 275M },
        //    //    ["Lifejacket"] = new Product { Name = "Lifejacket", Price = 48.95M }
        //    //};
        //    //return View("Index", products.Keys);


        //    //object[] data = new object[] { 275M, 29.95M,
        //    //    "apple", "orange", 100, 10 };
        //    //decimal total = 0;

        //    // Pattern Matching
        //    //for (int i = 0; i < data.Length; i++)
        //    //{
        //    //    if (data[i] is decimal d)
        //    //    {
        //    //        total += d;
        //    //    }
        //    //}

        //    // Pattern Matching in switch Statements
        //    //for (int i = 0; i < data.Length; i++)
        //    //{
        //    //    switch (data[i])
        //    //    {
        //    //        case decimal decimalValue:
        //    //            total += decimalValue;
        //    //            break;
        //    //        case int intValue when intValue > 50:
        //    //            total += intValue;
        //    //            break;
        //    //    }
        //    //}

        //    //return View("Index", new string[] { $"Total: {total:C2}" });

        //    // Using Extension Methods
        //    //ShoppingCart cart = new ShoppingCart { Products = Product.GetProducts() };
        //    //decimal cartTotal = cart.TotalPrices();

        //    // Applying Extension Methods to an Interface
        //    //Product[] productArray = {
        //    //    new Product {Name = "Kayak", Price = 275M},
        //    //    new Product {Name = "Lifejacket", Price = 48.95M}
        //    //    };
        //    //decimal arrayTotal = productArray.TotalPrices();

        //    //return View("Index", new string[] {
        //    //    $"Cart Total: {cartTotal:C2}",
        //    //    $"Array Total: {arrayTotal:C2}" });

        //    // Creating Filtering Extension Methods
        //    //Product[] productArray = {
        //    //    new Product {Name = "Kayak", Price = 275M},
        //    //    new Product {Name = "Lifejacket", Price = 48.95M},
        //    //    new Product {Name = "Soccer ball", Price = 19.50M},
        //    //    new Product {Name = "Corner flag", Price = 34.95M}
        //    //    };

        //    //decimal arrayTotal = productArray.FilterByPrice(20).TotalPrices();
        //    //return View("Index", new string[] { $"Array Total: {arrayTotal:C2}" });

        //    // Using Lambda Expressions
        //    //Func<Product?, bool> nameFilter = delegate (Product? prod) {
        //    //    return prod?.Name?[0] == 'S';
        //    //};

        //    //decimal priceFilterTotal = productArray
        //    //    .Filter(FilterByPrice)
        //    //    .TotalPrices();
        //    //decimal nameFilterTotal = productArray
        //    //    .Filter(nameFilter)
        //    //    .TotalPrices();

        //    //decimal priceFilterTotal = productArray
        //    //    .Filter(p => (p?.Price ?? 0) >= 20)
        //    //    .TotalPrices();
        //    //decimal nameFilterTotal = productArray
        //    //    .Filter(p => p?.Name?[0] == 'S')
        //    //    .TotalPrices();

        //    //return View("Index", new string[] {
        //    //    $"Price Total: {priceFilterTotal:C2}",
        //    //    $"Name Total: {nameFilterTotal:C2}" });

        //    return View(Product.GetProducts().Select(p => p?.Name));
        //}

        //public ViewResult Index() => View(Product.GetProducts().Select(p => p?.Name));

        // Using Type Inference and Anonymous Types
        //public ViewResult Index()
        //{
        //    //var names = new[] { "Kayak", "Lifejacket", "Soccer ball" };
        //    //return View(names);

        //    var products = new[] {
        //        new { Name = "Kayak", Price = 275M },
        //        new { Name = "Lifejacket", Price = 48.95M },
        //        new { Name = "Soccer ball", Price = 19.50M },
        //        new { Name = "Corner flag", Price = 34.95M }
        //    };

        //    //return View(products.Select(p => p.Name));
        //    return View(products.Select(p => p.GetType().Name));
        //}

        // Using Default Implementations in Interfaces
        //public ViewResult Index()
        //{
        //    IProductSelection cart = new ShoppingCart(
        //        new Product { Name = "Kayak", Price = 275M },
        //        new Product { Name = "Lifejacket", Price = 48.95M },
        //        new Product { Name = "Soccer ball", Price = 19.50M },
        //        new Product { Name = "Corner flag", Price = 34.95M }
        //     );

        //    //return View(cart.Products?.Select(p => p.Name));
        //    return View(cart.Names);
        //}

        // Using Asynchronous Methods
        //public async Task<ViewResult> Index()
        //{
        //    long? length = await MyAsyncMethods.GetPageLength();
        //    return View(new string[] { $"Length: {length}" });
        //}

        // Using an Asynchronous Enumerable
        //public async Task<ViewResult> Index()
        //{
        //    List<string> output = new List<string>();
        //    await foreach (long? len in MyAsyncMethods.GetPageLengths(output,
        //        "apress.com", "microsoft.com", "amazon.com"))
        //    {
        //        output.Add($"Page length: {len}");
        //    }
        //    return View(output);
        //}

        public ViewResult Index()
        {
            var products = new[]
            {
                new { Name = "Kayak", Price = 275M },
                new { Name = "Lifejacket", Price = 48.95M },
                new { Name = "Soccer ball", Price = 19.50M },
                new { Name = "Corner flag", Price = 34.95M },
            };
            return View(
                products.Select(p => $"{nameof(p.Name)}: {p.Name}, {nameof(p.Price)}: {p.Price}")
            );
        }
    }
}
