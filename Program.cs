using System;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //creat a list of product using generics
            List<Product<object>> inventory = new List<Product<object>>
            {
                new Product<object>("Laptop" , ProductCategory.Electronic , new ElectronicDetails("Dell" , 899.99) ),
                new Product<object>("T-shirt" , ProductCategory.Clothing , new ClothingDetail("Medium" , "Cotton") ),
                new Product<object>("Book" , ProductCategory.Book ,"Introduction to c# programming" ),
                new Product<object>("Food" , ProductCategory.Food, "Red Delicious" ),

            };
            
            //Display information adout all the products in the inventory
            foreach (var product  in inventory)
            {
               Console.WriteLine("------------------"); 
               product.DisplayInfo();
               Console.WriteLine("------------------"); 

            }

        }
    }
}