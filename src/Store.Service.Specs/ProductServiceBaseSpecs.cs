﻿using System.Collections.Generic;
using Machine.Specifications;
using NSubstitute;

namespace StoreService.Specs
{
  public class ProductServiceBaseSpecs
  {
    protected static IProductRepository _repository;
    protected static ProductService _productService;
    protected static IEnumerable<Product> _products;

    Establish context = () =>
    {
      _repository = Substitute.For<IProductRepository>();
      _productService = new ProductService(_repository);
    };

    protected static IEnumerable<Product> GetDummyProducts()
    {
      return new List<Product>()
      {
        new Product {Id=1,Name = "Product 1", Price = 10.00M},
        new Product {Id=2,Name = "Product 2", Price = 15.00M},
        new Product {Id=3,Name = "Product 3", Price = 18.00M},
        new Product {Id=4,Name = "Product 4", Price = 2.00M},
        new Product {Id=5,Name = "Product 5", Price = 3.00M},
        new Product {Id=6,Name = "Product 6", Price = 6.00M},
        new Product {Id=7,Name = "Product 7", Price = 9.00M},
        new Product {Id=8,Name = "Product 8", Price = 12.00M},
        new Product {Id=9,Name = "Product 9", Price = 50.00M},
        new Product {Id=10,Name = "Product 10", Price = 100.00M},
      };
    }
  }
}
