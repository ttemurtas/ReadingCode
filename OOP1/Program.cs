﻿using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.ProductId = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitsInStock = 3;

            Product product = new Product { ProductId=2, CategoryId=5, UnitsInStock=5, ProductName="Kalem", UnitPrice=35 };

            ProductManager.Add(product);
        }
    }
}
