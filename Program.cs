using System;
using StoreSystem.Models;
using StoreSystem.Services;

namespace StoreSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Store store = new Store();

            store.OnPurchase += (msg) =>
            {
                Console.WriteLine(msg);
            };

            store.AddProduct(new Food(1, "Shawarma"));
            store.AddProduct(new Electronics(2, "Phone"));
            store.AddProduct(new Clothes(3, "Shirt"));

            while (true)
            {
                Console.WriteLine("\n1- Show products");
                Console.WriteLine("2- Buy a product");
                Console.WriteLine("3- Exit");

                string option = Console.ReadLine();

                if (option == "1")
                {
                    store.ShowProducts();
                }
                else if (option == "2")
                {
                    int choice;

                    while (true)
                    {
                        Console.WriteLine("Select the product number:");
                        string input = Console.ReadLine();

                        if (int.TryParse(input, out choice) &&
                            choice >= 0 && choice < store.Products.Count)
                        {
                            break;
                        }

                        Console.WriteLine(" Invalid entry❌");
                    }

                    store.BuyProduct(choice);
                }
                else if (option == "3")
                {
                    break;
                }
                else
                {
                    Console.WriteLine(" Invalid option❌");
                }
            }

            Console.WriteLine($"Number of products: {Store.TotalProducts}");
        }
    }
}