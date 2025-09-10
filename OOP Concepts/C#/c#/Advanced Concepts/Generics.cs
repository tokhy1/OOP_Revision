using System;
using System.Collections.Generic;

/*
* Generics in C#
*
* Definition:
*     A way to define classes, methods, interfaces, or data structures
*     with a placeholder type parameter (e.g., T).
*
* Purpose:
*     - Type safety (no boxing/unboxing, no invalid casts).
*     - Reusability (same logic works with different types).
*     - Performance (avoids unnecessary conversions).
*     - Cleaner, more maintainable code.
*
* Syntax:
*     class ClassName<T> { ... }
*     void MethodName<T>(T param) { ... }
*     interface IInterface<T> { ... }
*
* Constraints:
*     where T : class           // must be a reference type
*     where T : struct          // must be a value type
*     where T : new()           // must have a parameterless constructor
*     where T : BaseClass       // must inherit from a base class
*     where T : IInterface      // must implement an interface
*/


namespace c_.Advanced_Concepts
{

    // think of it like a template for the other classes
    class Repository<T> where T : class
    {
        private readonly List<T> _items = new List<T>();

        public void Add(T item) => _items.Add(item);
        
        public IEnumerable<T> GetAll() => _items;
    }

    // Example entities
    class Product
    {
        public string Name { get; set; }
    }

    class Customer
    {
        public string FullName { get; set; }
    }

    class GenericsClass
    {
        public static void DemoGenerics()
        {
            // Product repository
            var productRepo = new Repository<Product>();
            productRepo.Add(new Product { Name = "Laptop" });
            productRepo.Add(new Product { Name = "Phone" });

            Console.WriteLine("Products:");
            foreach (var product in productRepo.GetAll())
                Console.WriteLine($"- {product.Name}");

            // Customer repository
            var customerRepo = new Repository<Customer>();
            customerRepo.Add(new Customer { FullName = "Tokhy" });
            customerRepo.Add(new Customer { FullName = "Jane Doe" });

            Console.WriteLine("\nCustomers:");
            foreach (var customer in customerRepo.GetAll())
                Console.WriteLine($"- {customer.FullName}");
        }
    }

}

