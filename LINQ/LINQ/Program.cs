using System;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;

namespace LINQ
{
    class Program
    {
        /* Practice your LINQ!
         * You can use the methods in Data Loader to load products, customers, and some sample numbers
         * 
         * NumbersA, NumbersB, and NumbersC contain some ints
         * 
         * The product data is flat, with just product information
         * 
         * The customer data is hierarchical as customers have zero to many orders
         */
        static void Main()
        {
            //PrintOutOfStock();
            //InStockMoreThan3();
            //InWashington();
            // NamesOfProducts();
            //NamesOfProductsToUpper();
            //EvenNumberInStock();
            //UnitPriceIncreasedByTwentyFivePercent();
            //NameCategoryAndPrice();
            //BIsLessThanC();
            //AllProductsInCategoryInStock();
            //TotalUnderFiveHund();
            //FirstThreeElemInA();
            //FirstTheeOrdersInWash();
            //SkipFirstThreeInA();
            //AllCustInWashOrdersExceptFirstTwo();
            //GetAllInNumCNotBiggerThanSix();
            //ReturnDivisibleByThree();
            //18.
            // ProductsByNameAlaphabetically();
            //19.
            //UnitsInStockDescending();
            //ListByCategoryPriceHighToLow();
            //20 
            //ReverseNumbersC();
            GroupNumCByRemainderDividedByFive();


            Console.ReadLine();
        }
        //1. Find all products that are out of stock
        private static void PrintOutOfStock()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock == 0);
            var results = from p in products
                          where p.UnitsInStock == 0
                          select p;

            foreach (var product in results)
            {
                Console.WriteLine(product.ProductName);
            }
        }

        //2. Find all products that are in stock and cost more than 3.00 per unit.
        private static void InStockMoreThan3()
        {
            var products = DataLoader.LoadProducts();

            //var results = products.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3);
            var results = from p in products
                          where p.UnitsInStock > 0 && p.UnitPrice > 3
                          select p;

            foreach (var product in results)
            {
                Console.WriteLine("{0} has {1} in stock with unit price {2}", product.ProductName,
                    product.UnitsInStock, product.UnitPrice);
            }
        }

        //3. Find all customers in Washington, print their name then their orders. (Region == "WA")?????
        private static void InWashington()
        {
            var customer = DataLoader.LoadCustomers();

            var results = from c in customer
                where c.Region == "WA"
                select new {c.CompanyName, c.Orders};

            foreach (var cust in results)
            {
                //prints out Company Name but only the :Linq.order[]
                Console.WriteLine("\nCustomer Name: {0}, \nOrders: {1}", cust.CompanyName, cust.Orders);
            }
        }
        //4. Create a new sequence with just the names of the products.
        private static void NamesOfProducts()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          where p.UnitsInStock != 0
                          select p;
            Console.WriteLine("Products: ");
            foreach (var prod in results)
            {
                Console.WriteLine("{0}", prod.ProductName);
            }

        }

        // 5. Create a new sequence of products and unit prices where the unit prices are increased by 25%.
        public static void UnitPriceIncreasedByTwentyFivePercent()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          where p.ProductID > 0
                          select p;

            foreach (var prod in results)
            {
                Console.WriteLine(" Product {0} " +
                                  "\n The price increase of 25% is : {1}  from: {2}", prod.ProductName,
                    (int)prod.UnitPrice * .25 + (int)prod.UnitPrice, prod.UnitPrice);
            }
        }

        //6. Create a new sequence of just product names in all upper case.
        private static void NamesOfProductsToUpper()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          where p.UnitsInStock != 0
                          select p;
            foreach (var prod in results)
            {
                Console.WriteLine("Product: \n {0}", prod.ProductName.ToUpper());
            }

        }
        //7. Create a new sequence with products with even numbers of units in stock.
        public static void EvenNumberInStock()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                          where p.UnitsInStock % 2 == 0
                          select p;

            foreach (var prod in results)
            {
                Console.WriteLine("Product {0} has an even number in stock of {1}", prod.ProductName, prod.UnitsInStock);
            }
        }

        //8. Create a new sequence of products with ProductName, Category, and rename UnitPrice to Price.???
        public static void NameCategoryAndPrice()
        {
            var products = DataLoader.LoadProducts();
            var results = from p in products
                          select new { p.ProductName, p.Category, Price = p.UnitPrice };
            foreach (var prod in results)
            {
                Console.WriteLine("Product {0} \n Category: {1} \n Price: {2}", prod.ProductName, prod.Category, prod.Price);
            }
        }
        //9. Make a query that returns all pairs of numbers from both arrays 
        //such that the number from numbersB is less than the number from numbersC.
        public static void BIsLessThanC()
        {
            var products = DataLoader.LoadProducts();
            var results = from b in DataLoader.NumbersB
                          from c in DataLoader.NumbersC
                          where b < c
                          select new { b, c };
            foreach (var prod in results)
            {
                Console.Write("\n Numbersb < NumbersC {0},{1},  ", prod.b, prod.c);
            }
        }

        //10. Select CustomerID, OrderID, and Total where the order total is less than 500.00.
        public static void TotalUnderFiveHund()
        {
            var cust = DataLoader.LoadCustomers();
            var results = from c in cust
                          from o in c.Orders
                          where o.Total < 500
                          select new
                          {
                              o.OrderID,
                              c.CustomerID,
                              o.Total
                          };

            foreach (var c in results)
            {
                Console.WriteLine("CustomerId {0} \n OrderId: {1} \n Total: {2}", c.CustomerID, c.OrderID, c.Total);
            }
        }

        //11. Write a query to take only the first 3 elements from NumbersA.

        private static void FirstThreeElemInA()
        {
            var numA = DataLoader.NumbersA;
            var results = numA.Take(3);

            foreach (var a in results)
            {
                Console.Write("\n Numbersb {0},  ", a);
            }
        }

        //12. Get only the first 3 orders from customers in Washington.
        private static void FirstTheeOrdersInWash()
        {
            var cust = DataLoader.LoadCustomers();
            var results = (from c in cust
                           from o in c.Orders
                           where c.Region == "WA"
                           select new { c.CustomerID, o.OrderID, o.OrderDate }).Take(3);

            Console.WriteLine("First 3 orders in WA:");
            foreach (var c in results)
            {
                Console.WriteLine(c);
            }
        }

        //13. Skip the first 3 elements of NumbersA.
        private static void SkipFirstThreeInA()
        {
            var numA = DataLoader.NumbersA;
            var results = numA.Skip(3);

            foreach (var a in results)
            {
                Console.Write("\n NumbersA {0}  ", a);
            }
        }

        //14. Get all except the first two orders from customers in Washington.
        private static void AllCustInWashOrdersExceptFirstTwo()
        {
            var cust = DataLoader.LoadCustomers();
            var results = (from c in cust
                           from o in c.Orders
                           where c.Region == "WA"
                           select new { c.CustomerID, o.OrderID, o.OrderDate }).Skip(2);

            Console.WriteLine("orders in WA except first 2:");
            foreach (var c in results)
            {
                Console.WriteLine(c);
            }
        }
        //??????????????????????????????????????????????????????????????????/
        //15. Get all the elements in NumbersC from the beginning 
        //until an element is greater or equal to 6. ???????????????????????
        private static void GetAllInNumCNotBiggerThanSix()//not working yet
        {
            var numC = DataLoader.NumbersC;
            //var results = numC.TakeWhile(n => n < 6);
            var results = from c in numC
                          where c < 6
                          select c;
            Console.WriteLine("Elements befor the first 6:");
            foreach (var c in results)
            {
                Console.WriteLine(c);
            }
        }
        //?????????????16.....???????????????????????????????????????????????????????????
        //16. Return elements starting from the beginning of NumbersC  ???????????????
        //until a number is hit that is less than its position in the array.
        private static void ReturnNumsUntilNumIsLessThanPositionInArray()
        {
            int[] numC = DataLoader.NumbersC;
            var results = from c in numC
                         // orderby c.[0], c[0].Length
                          select c;

        }

        //17. Return elements from NumbersC starting from the first element divisible by 3.
        private static void ReturnDivisibleByThree()
        {
            var numC = DataLoader.NumbersC;
            var results = from c in numC
                          where c % 3 == 0
                          select c;
            foreach (var c in results)
            {
                Console.WriteLine(c);
            }
        }

        //18. Order products alphabetically by name.
        private static void ProductsByNameAlaphabetically()
        {
            var product = DataLoader.LoadProducts();

            var results = from p in product
                orderby p.ProductName
                select p.ProductName;
            Console.WriteLine("products by name alphabetically:");
            foreach (var prod in results)
            {
                Console.WriteLine(prod);
            }
        }

        //19. Order products by UnitsInStock descending.
        private static void UnitsInStockDescending()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          orderby p.UnitsInStock descending 
                select new
                {
                    Units = p.UnitsInStock,
                    Name = p.ProductName
                };
            Console.WriteLine("Units in stock by descending order");
            foreach (var u in results)
            {
                Console.WriteLine("Name : {0} \n Units in Stock: {1}",u.Name,u.Units );
            }
        }
        //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.

        private static void ListByCategoryPriceHighToLow()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                orderby p.ProductName, p.Category ascending , p.UnitsInStock descending
                select new
                {
                    Category = p.Category,
                    Units = p.UnitsInStock
                };
            Console.WriteLine("Products Ordered by CATEGORY then UNIT PRICE DESCENDING: ");
            foreach (var p in results)
            {
                Console.WriteLine("Category: {0} \n Unit Price: {1}",p.Category, p.Units);
            }
        }

        //21. Reverse NumbersC
        private static void ReverseNumbersC()
        {
            //int[] NumbersC = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            var numC = DataLoader.NumbersC;
            var results = numC.Reverse();

            foreach (var c in results)
            {
                Console.Write(c);
            }
        }

 // 22. Display the elements of NumbersC grouped by their remainder when divided by 5.

        private static void GroupNumCByRemainderDividedByFive()
        {
            var numC = DataLoader.NumbersC;

            var results = from c in numC
                group c by c % 5;
            foreach (var r in results)
            {
                Console.WriteLine(r);
            }
        }
         
        //23. Display products by Category.
        //24. Group customer orders by year, then by month.
        //25. Create a list of unique product category names.
        //26. Get a list of unique values from NumbersA and NumbersB.
        //27. Get a list of the shared values from NumbersA and NumbersB.
        //28. Get a list of values in NumbersA that are not also in NumbersB.
        //29. Select only the first product with ProductID = 12(not a list).
        //30. Write code to check if ProductID 789 exists.



        //33.Get a grouped a list of products only for categories that have all of their products in stock.
        private static void AllProductsInCategoryInStock()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category
                           into pCats
                          where pCats.All(x => x.UnitsInStock > 0)
                          select new { pCats.Key, coll = pCats };
            //method syntax
            // var results = products.GroupBy(cat => cat.Category).Where(p => p.All(x => x.UnitsInStock > 0));
            foreach (var result in results)
            {
                Console.WriteLine("{0},", result.Key);
                foreach (var product in result.coll)
                {
                    Console.WriteLine("\t{0} - {1}", product.UnitsInStock, product.ProductName);
                }
            }




        }

    }
}
