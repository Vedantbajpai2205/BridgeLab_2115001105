using System;
using System.Collections.Generic;
using System.Linq;

    class Shopping
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> productPrices = new Dictionary<string, double>();
            List<KeyValuePair<string, double>> productOrder = new List<KeyValuePair<string, double>>();
            SortedDictionary<string, double> sortedProducts = new SortedDictionary<string, double>();

            AddProduct("Laptop", 1200.00, productPrices, productOrder, sortedProducts);
            AddProduct("Mobile", 800.00, productPrices, productOrder, sortedProducts);
            AddProduct("Headphones", 150.00, productPrices, productOrder, sortedProducts);
            AddProduct("Watch", 300.00, productPrices, productOrder, sortedProducts);
            AddProduct("Keyboard", 20.00, productPrices, productOrder, sortedProducts);

            Console.WriteLine("Shopping Cart (Order in which products were added):");
            DisplayCartOrder(productOrder);

            Console.WriteLine("Shopping Cart (Sorted by Price):");
            DisplaySortedProducts(sortedProducts);

            Console.WriteLine("Shopping Cart (All Products with Prices):");
            DisplayAllProducts(productPrices);

            double totalPrice = CalculateTotalPrice(productPrices);
            Console.WriteLine("Total Price: " + totalPrice);
        }

        static void AddProduct(string productName, double price, Dictionary<string, double> productPrices,
                               List<KeyValuePair<string, double>> productOrder, SortedDictionary<string, double> sortedProducts)
        {
            productPrices[productName] = price;
            productOrder.Add(new KeyValuePair<string, double>(productName, price));
            sortedProducts[productName] = price;
        }

        static void DisplayCartOrder(List<KeyValuePair<string, double>> productOrder)
        {
            foreach (var product in productOrder)
            {
                Console.WriteLine(product.Key + ": " + product.Value);
            }
        }

        static void DisplaySortedProducts(SortedDictionary<string, double> sortedProducts)
        {
            foreach (var product in sortedProducts)
            {
                Console.WriteLine(product.Key + ": " + product.Value);
            }
        }

        static void DisplayAllProducts(Dictionary<string, double> productPrices)
        {
            foreach (var product in productPrices)
            {
                Console.WriteLine(product.Key + ": " + product.Value);
            }
        }

        static double CalculateTotalPrice(Dictionary<string, double> productPrices)
        {
            double total = 0;
            foreach (var product in productPrices)
            {
                total += product.Value;
            }
            return total;
        }
    }
