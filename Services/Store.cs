using System;
using System.Collections.Generic;
using StoreSystem.Abstract;

namespace StoreSystem.Services
{
    public delegate void PurchaseHandler(string message);

    public class Store
    {
        public event PurchaseHandler OnPurchase;

        public List<Product> Products = new List<Product>();

        public static int TotalProducts = 0;

        public void AddProduct(Product product)
        {
            Products.Add(product);
            TotalProducts++;
        }

        public void ShowProducts()
        {
            for (int i = 0; i < Products.Count; i++)
            {
                Console.WriteLine($"{i} - {Products[i].Name} - {Products[i].GetPrice()}");
            }
        }

        public void BuyProduct(int index)
        {
            if (index >= 0 && index < Products.Count)
            {
                var product = Products[index];
                OnPurchase?.Invoke($"Purchased {product.Name} At a price {product.GetPrice()}");
            }
        }
    }
}