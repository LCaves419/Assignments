using System;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Policy;

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
            //1
            //PrintOutOfStock();
            //2
            //InStockMoreThan3();
            //3
            //InWashington();
            //4
            //NamesOfProducts();
            //5
            //UnitPriceIncreasedByTwentyFivePercent();
            //6
            //NamesOfProductsToUpper();
            //7
            //EvenNumberInStock();

            //8
            //NameCategoryAndPrice();
            //9
            //BIsLessThanC();
            //10
            //TotalUnderFiveHund();

            //AllProductsInCategoryInStock();
            //11
            //FirstThreeElemInA();
            //12
            //FirstTheeOrdersInWash();
            //13
            //SkipFirstThreeInA();
            //14
            //AllCustInWashOrdersExceptFirstTwo();
            //15
            //GetAllInNumCNotBiggerThanSix();
            //16
            //ReturnNumsUntilNumIsLessThanPositionInArray();
            //17
            //ReturnDivisibleByThree();
            //18.
            //ProductsByNameAlaphabetically();
            //19.
            //UnitsInStockDescending();
            //20 
            //ListByCategoryPriceHighToLow();
            //21
            //ReverseNumbersC();
            //22
            //GroupNumCByRemainderDividedByFive();
            //23
            //ProductsByCategory();
            //24
            //OrdersByYearThenMonth();
            //25
            //UniqueProductCategoryNames();
            //26
            //UniqueValuesInAandB();
            //27
            //SharedValuesInAandB();
            //28
            //ValuesInANotInB();
            //29
            //FirstWithProdIdOfTwelve();
            //30
            //ProdId789();
            //31
            //CatWithOneProdOut();
            //32
            //IfNumBOnlyLessThanNine();
            //33
            AllProductsInCategoryInStock();
            //34
            //CountNumOfOddInNumA();
            //35
            //CustIdAndOrderCount();
            //36
            //CatAndNumOfProd();
            //37
            //TotalUnitsInStockByCat();
            //38
            //LowestPriceProdInCat();
            //39
            //HighestPriceInCat();
            //40
            //AveragePriceInCat();

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

        //3. Find all customers in Washington, print their name then their orders. (Region == "WA")
        private static void InWashington()
        {
            var customers = DataLoader.LoadCustomers();

            var results = from c in customers
                          where c.Region == "WA"
                          select c;
            foreach (var c in results)
            {
                Console.WriteLine("Customer {0}: ", c.CompanyName);
                foreach (var o in c.Orders)
                {
                    Console.WriteLine("  Order {0}: {1} , {2}", o.OrderID, o.OrderDate, o.Total);
                }
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

        //15. Get all the elements in NumbersC from the beginning 
        //until an element is greater or equal to 6.
        private static void GetAllInNumCNotBiggerThanSix()
        {
            var numC = DataLoader.NumbersC;
            
            var results = numC.TakeWhile(n => n < 6);
            Console.WriteLine("Elements before the first 6:");
            foreach (var num in results)
            {
                Console.WriteLine(num);
            }
        }

        //16. Return elements starting from the beginning of NumbersC 
        //until a number is hit that is less than its position in the array.
        private static void ReturnNumsUntilNumIsLessThanPositionInArray()
        {
            int[] numC = DataLoader.NumbersC;

            var results = numC.TakeWhile((n, index) => n > index);
            Console.WriteLine("Elements before the value of it's position inthe array:");
            foreach (var num in results)
            {
                Console.WriteLine(num);
            }

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
                Console.WriteLine("Name : {0} \n Units in Stock: {1}", u.Name, u.Units);
            }
        }

        //20. Sort the list of products, first by category, and then by unit price, from highest to lowest.
        private static void ListByCategoryPriceHighToLow()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          orderby p.ProductName, p.Category ascending, p.UnitsInStock descending
                          select new
                          {
                              Category = p.Category,
                              Units = p.UnitsInStock
                          };
            Console.WriteLine("Products Ordered by CATEGORY then UNIT PRICE DESCENDING: ");
            foreach (var p in results)
            {
                Console.WriteLine("Category: {0} \n Unit Price: {1}", p.Category, p.Units);
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

            var results =from n in numC
                        group n by n % 5 into g
                        select new
                        {
                            Remainder = g.Key,
                            Numbers = g
                        };
            foreach (var r in results)
            {
                Console.WriteLine("Remainders of: {0}",r.Remainder);
                foreach (var n in r.Numbers)
                {
                    Console.WriteLine(n);
                }
            }
        }

        //23. Display products by Category.
        private static void ProductsByCategory()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category;
                         
            foreach (var prod in results)
            {
                Console.WriteLine("\nCategory: {0}\n", prod.Key);//priints Category Name
                foreach (var c in prod)
                {
                    Console.WriteLine(c.ProductName);//prints product name
                }
            }
        }

        //24. Group customer orders by year, then by month. ???????PRINT
        private static void OrdersByYearThenMonth()
        {
            var customer = DataLoader.LoadCustomers();
            var results = from c in customer
                          select new
                          {
                              Company = c.CompanyName,
                              YearGroups = from o in c.Orders
                                           group o by o.OrderDate.Year
                                  into yg
                                           select new
                                           {
                                               Year = yg.Key,
                                               MonthGroups = from o in yg
                                                             group o by o.OrderDate.Month
                                                             into mg
                                                             select new
                                                             {
                                                                 Month = mg.Key,
                                                                 Orders = mg
                                                             }
                                           }
                          };
            foreach (var y in results)
            {
                Console.WriteLine("Orders by year: \n{0}", y.YearGroups);
            }

        }

        //25. Create a list of unique product category names.
        private static void UniqueProductCategoryNames()
        {
            var products = DataLoader.LoadProducts();

            var results = (from p in products select p.Category).Distinct();
            
            foreach (var n in results)
            {
                Console.WriteLine(n);
            }
        }

        //26. Get a list of unique values from NumbersA and NumbersB.
        private static void UniqueValuesInAandB()
        {
            var numA = DataLoader.NumbersA;
            var numB = DataLoader.NumbersB;

            var results = numA.Except(numB).ToList();

            foreach (int t in results)
                Console.Write(t);
        }

        //27. Get a list of the shared values from NumbersA and NumbersB.
        private static void SharedValuesInAandB()
        {
            var numA = DataLoader.NumbersA;
            var numB = DataLoader.NumbersB;

            var results = numA.Intersect(numB).ToList();

            foreach (int t in results)
                Console.Write(t);

        }

        //28. Get a list of values in NumbersA that are not also in NumbersB.
        private static void ValuesInANotInB()
        {
            var numA = DataLoader.NumbersA;
            var numB = DataLoader.NumbersB;

            var results = numA.Except(numB); ;

            foreach (int t in results)
                Console.Write(t);
        }

        //29. Select only the first product with ProductID = 12(not a list).
        private static void FirstWithProdIdOfTwelve()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          where p.ProductID == 12
                          select p;
            foreach (var i in results)
            {
                Console.WriteLine("Name : {0}, Product ID : {1} ", i.ProductName, i.ProductID);
            }
        }

        //30. Write code to check if ProductID 789 exists.?????
        private static void ProdId789()
        {
            var products = DataLoader.LoadProducts();
           
            var results = products.FirstOrDefault(p => p.ProductID == 789);
           
            Console.WriteLine("Does product 789 exist? {0}",results != null );
        }

        //31. Get a list of categories that have at least one product out of stock.
        private static void CatWithOneProdOut()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          where p.UnitsInStock == 0
                          group p by p.Category
                into pCats
                          select new
                          {
                              Category = pCats.Key,
                          };
            foreach (var p in results)
            {
                Console.WriteLine(p);
            }
        }

        //32. Determine if NumbersB contains only numbers less than 9.
        private static void IfNumBOnlyLessThanNine()
        {
            var numB = DataLoader.NumbersB;

            var results = numB.All(n => n < 9);

            Console.WriteLine("Array NumberB contains only numbers less than 9: {0}", results);
        }

        //33.Get a grouped a list of products only for categories that have all of their products in stock.
        private static void AllProductsInCategoryInStock()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category
                           into pCats
                          where pCats.All(x => x.UnitsInStock > 0)
                          select new {Category = pCats.Key, Products = pCats };
            //method syntax
            // var results = products.GroupBy(cat => cat.Category).Where(p => p.All(x => x.UnitsInStock > 0));
            foreach (var result in results)
            {
                Console.WriteLine("{0},", result.Category);
                foreach (var product in results)
                {
                    Console.WriteLine("\t{0}", product.Products);
                }
            }
        }

        //34. Count the number of odds in NumbersA.
        private static void CountNumOfOddInNumA()
        {
            var numA = DataLoader.NumbersA;

            var results = numA.Count(n => n % 2 != 0);

            Console.WriteLine("There are {0} number of odds in NumbersA.", results);

        }

        //35. Display a list of CustomerIDs and only the count of their orders.
        private static void CustIdAndOrderCount()
        {
            var customer = DataLoader.LoadCustomers();

            var results = from c in customer

                          select new
                          {
                              count = c.Orders.Count(),
                              Id = c.CustomerID
                          };
            foreach (var c in results)
            {
                Console.Write("\nCustomer ID : {0}  Number of Orders: {1}\n", c.Id, c.count);
            }
        }

        //36. Display a list of categories and the count of their products.
        private static void CatAndNumOfProd()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category into g

                          select new
                          {
                              Cat = g.Key,
                              Count = g.Count()
                          };
            foreach (var c in results)
            {
                Console.Write("\nCategory : {0}  Number of Prouducts: {1}\n", c.Cat, c.Count);
            }
        }

        //37. Display the total units in stock for each category.
        private static void TotalUnitsInStockByCat()
        {
            var products = DataLoader.LoadProducts();

            var results =
                from p in products
                group p by p.Category into g
                select new
                {
                    Category = g.Key,
                    TotalUnitsInStock = g.Sum(p => p.UnitsInStock)
                };
            foreach (var u in results)
            {
                Console.Write("\nCategory : {0}  Number of units in Stock: {1}\n", u.Category, u.TotalUnitsInStock);
            }
        }

        //38. Display the lowest priced product in each category.
        private static void LowestPriceProdInCat()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                group p by p.Category into g
                select new
                {
                    Category = g.Key,
                    LowPrice = g.Min(p => p.UnitPrice)
                };
            foreach (var p in results)
            {
                Console.Write("\nCategory : {0}  Lowest Price In Category: {1}\n", p.Category, p.LowPrice);
            }
        }

        //39. Display the highest priced product in each category.
        private static void HighestPriceInCat()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category into g
                          select new
                          {
                              Category = g.Key,
                              HighPrice = g.Max(p => p.UnitPrice)
                          };
            foreach (var p in results)
            {
                Console.Write("\nCategory : {0}  Highest Price in Category : {1}\n", p.Category, p.HighPrice);
            }
        }

        //40. Show the average price of product for each category.
        private static void AveragePriceInCat()
        {
            var products = DataLoader.LoadProducts();

            var results = from p in products
                          group p by p.Category into g
                          select new
                          {
                              Category = g.Key,
                              AvgPrice = g.Average(p => p.UnitPrice)
                          };
            foreach (var p in results)
            {
                Console.Write("\nCategory : {0}  Highest Price in Category : {1}\n", p.Category, p.AvgPrice);
            }
        }
        
    }
}
