﻿using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //ProductTest();
            //CategoryTest();

        }

        //private static void CategoryTest()
        //{
        //    CategoryManager categoryManager = new CategoryManager(new EfCategoryDal());
        //    foreach (var x in categoryManager.GetAll())
        //    {
        //        Console.WriteLine(x.CategoryName);
        //    }
        //}

        //private static void ProductTest()
        //{
        //    ProductManager productManager = new ProductManager(new EfProductDal());
        //    var result = productManager.GetProductDetails();
        //    if (result.Success == true)
        //    {
        //        foreach (var product in result.Data)
        //        {
        //            Console.WriteLine(product.ProductName + "/" + product.CategoryName);
        //        } 
        //    }
        //    else
        //    {
        //        Console.WriteLine(result.Message);
        //    }

            

        //    foreach (var x in productManager.GetProductDetails().Data)
        //    {
        //        Console.WriteLine("Ürün Adı : " + x.ProductName);
        //        Console.WriteLine("Kategori : " + x.CategoryName);
        //        Console.WriteLine("---------------------------");
        //    }
        //}
    }
}
