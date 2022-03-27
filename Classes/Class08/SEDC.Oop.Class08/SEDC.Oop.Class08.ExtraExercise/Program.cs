using System;
using System.Linq;
using System.Collections.Generic;

namespace SEDC.Oop.Class08.ExtraExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>
            {
                        new Product() { Name =  "Keyboard", Price = 100, Category = Category.ItEquipment},
                        new Product() { Name =  "Mouse", Price = 150, Category = Category.ItEquipment},
                        new Product() { Name =  "Headphones", Price = 80, Category = Category.ItEquipment},
                        new Product() { Name =  "Microphone", Price = 220, Category = Category.ItEquipment},
                        new Product() { Name =  "Camera", Price = 1000, Category = Category.ItEquipment},
                        new Product() { Name =  "Hp-580", Price = 20000, Category = Category.LapTop},
                        new Product() { Name =  "Lenovo G200", Price = 18500, Category = Category.LapTop},
                        new Product() { Name =  "Hp ProBook", Price = 12000, Category = Category.LapTop},
                        new Product() { Name =  "Acer S1200", Price = 28000, Category = Category.LapTop},
                        new Product() { Name =  "Dell MS300", Price = 74000, Category = Category.LapTop},
                        new Product() { Name =  "Office 1", Price = 10200, Category = Category.PC},
                        new Product() { Name =  "Office 2", Price = 12400, Category = Category.PC},
                        new Product() { Name =  "Gaming", Price = 22000, Category = Category.PC},
                        new Product() { Name =  "Ultra Gaming", Price = 32200, Category = Category.PC},
                        new Product() { Name =  "Ultra Ultra Gaming", Price = 61600, Category = Category.PC},
                        new Product() { Name =  "Alienware", Price = 128000, Category = Category.PC},
                        new Product() { Name =  "Samsung Proview", Price = 56200, Category = Category.TV},
                        new Product() { Name =  "LG LG420MQ8", Price = 32000, Category = Category.TV},
                        new Product() { Name =  "SONY Plasma", Price = 18000, Category = Category.TV},
                        new Product() { Name =  "SONY RW78OS", Price = 179999, Category = Category.TV},
                        new Product() { Name =  "Samsung Oval", Price = 247999, Category = Category.TV}
            };


            List<Product> productsByCategory = SearchProductByCategory(products, Category.TV);
            PrintProducts(productsByCategory, "Products by category");
            Console.WriteLine();

            List<Product> productsByPrice = FilterProdyctsByPriceRange(products, 20000, 60000);
            PrintProducts(productsByPrice, "Products by price range");
            Console.WriteLine();

            List<Product> productsByName = FilterProductsByName(products, "s");
            PrintProducts(productsByName, "Products by name");
            Console.WriteLine();

            List<string> productsByNames = GetProductNames(products);
            Console.WriteLine(string.Join("\n", productsByNames));

            int productPriceByIndex = GetProductPrice(products, 3);
            PrintProduct(products[3], $"The name of the product on the selected index is {products[3].Name}");
            Console.WriteLine($"The price of the {products[3].Name} is {productPriceByIndex}");
            Console.WriteLine();

            Product cheapestProduct = GetCheapestProduct(products);
            PrintProduct(cheapestProduct, "The cheapest product is:");
            Console.WriteLine();

            Product mostExpensiveProduct = GetMostExpensiveProduct(products);
            PrintProduct(mostExpensiveProduct, "The most expensive product is: ");
            Console.WriteLine();

            AddProduct(products, "Dell Latitude 7490", 95000, Category.LapTop);
            PrintProducts(products, "List of products after adding the new product");
            Console.WriteLine();

            RemoveProduct(products, 50);
            PrintProducts(products, "List of products after removing a product: ");

            Console.ReadLine();
        }

        //Search products by category // return all products from given category
        public static List<Product> SearchProductByCategory(List<Product> products, Category category)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product prod in products)
            {
                if (prod.Category == category)
                {
                    filteredProducts.Add(prod);
                }
            }
            return filteredProducts;
        }

        //Filter products by price range (from min to max) // return all products that fall in the given price range
        public static List<Product> FilterProdyctsByPriceRange(List<Product> products, int from, int to)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach(Product prod in products)
            {

                if (prod.Price >= from && prod.Price <= to)
                {
                    filteredProducts.Add(prod);
                }
            }
            return filteredProducts;
        }

        //Find products by part of name // get all products that consist the part in their names
        public static List<Product> FilterProductsByName(List<Product> products, string substr)
        {
            List<Product> filteredProducts = new List<Product>();
            foreach (Product prod in products)
            {
                if (prod.Name.ToLower().Contains(substr.ToLower()))
                {
                    filteredProducts.Add(prod);
                }
            }
            return filteredProducts;
        }

        //Get only products ids // return only the ids of the products. We don't have product ids. Instead I returned product names
        public static List<string> GetProductNames(List<Product> products)
        {
            List<string> namesList = new List<string>();
            foreach (Product prod in products)
            {
                namesList.Add(prod.Name);
            }
            return namesList;
        }

        //Get product price // get the price of the product - give the id as parameter. We don't have id in the object. Instead I gave index as a parameter and returned the price of the product on that index
        public static int GetProductPrice(List<Product> products, int index)
        {
            if(index > products.Count - 1 || index < 0)
            {
                return 0;
            }
            return products[index].Price;
        }

        //Get cheapest product // return the cheapest product
        public static Product GetCheapestProduct(List<Product> products)
        {
            //Product cheapest = products.First(x => x.Price == products.Min(y => y.Price));
            //return cheapest;
            int minPrice = int.MaxValue;
            int index = 0;
            for (int i = 0; i < products.Count; i++)
            {
                if(products[i].Price < minPrice)
                {
                    minPrice = products[i].Price;
                    index = i;
                }
            }
            return products[index];
        }

        //Get most expensive product // return the most expensive one
        public static Product GetMostExpensiveProduct(List<Product> products)
        {
            int maxPrice = int.MinValue;
            int index = 0;
            for(int i = 0; i < products.Count; i++)
            {
                if(products[i].Price > maxPrice)
                {
                    maxPrice = products[i].Price;
                    index = i;
                }
            }
            return products[index];
        }

        //Add product // create method to add product to the list of products
        public static void AddProduct (List<Product> products, string name, int price, Category category)
        {
            Product newProduct = new Product(name, price, category);
            products.Add(newProduct);
        }

        //Remove product // and a method to remove it - use id as parameter
        public static void RemoveProduct(List<Product> products, int index) {
            if (index > products.Count - 1 || index < 0)
            {
                Console.WriteLine($"The maximum value of the index is {products.Count - 1}");
            }
            else { 
            products.RemoveAt(index);
            }
        }
        
        //Method for printing a list of products
        public static void PrintProducts(List<Product> products, string text)
        {
            Console.WriteLine(text);
            foreach (Product prod in products)
            {
                Console.WriteLine($"Name: {prod.Name}, price: {prod.Price}, category: {prod.Category}");
            }
        }

        //Method for printing a single product
        public static void PrintProduct(Product product, string text)
        {
            Console.WriteLine(text);
            Console.WriteLine($"Name: {product.Name}, price: {product.Price}, category: {product.Category}");
        }

    }

       
    
}
