namespace ASSimentLinQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            #region G-ASP-NET-81-LINQ01
            #region Q1
            //        var result = Source.ProductList
            //.Where(p => p.Category == "Seafood");

            //        foreach (var product in result)
            //        {
            //            Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //        }
            #endregion
            #region Q2
            //var result = Source.ProductList
            //    .Select(p => p.ProductName);
            //foreach (var Product in result) {
            //    Console.WriteLine(Product);
            //}

            #endregion
            #region Q3
            //var result = Source.ProductList
            //    .OrderBy(p=>p.UnitPrice) .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}
            #endregion
            #region Q4

            //var result = Source.ProductList
            //    .Where(p => p.UnitPrice >= 10 && p.UnitPrice <= 30)
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}

            #endregion
            #region Q5

            //var result = Source.ProductList
            //    .Where(p => p.UnitsInStock > 0 &&
            //                p.Category == "Condiments")
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitsInStock}");
            //}

            #endregion
            #region Q6

            //var result = Source.ProductList
            //    .Select(p =>
            //    {
            //        string status;

            //        if (p.UnitsInStock > 0)
            //        {
            //            status = "Available";
            //        }
            //        else
            //        {
            //            status = "Out of Stock";
            //        }

            //        return new
            //        {
            //            Name = p.ProductName,
            //            Price = p.UnitPrice,
            //            StockStatus = status
            //        };
            //    })
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine(
            //        $"{product.Name} - {product.Price} - {product.StockStatus}");
            //}

            #endregion
            #region Q7

            //var result = Source.ProductList
            //    .Select((p, index) => new
            //    {
            //        Position = index + 1,
            //        Name = p.ProductName
            //    })
            //    .ToList();

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Position}. {item.Name}");
            //}

            #endregion
            #region Q8

            //var result = Source.ProductList
            //    .OrderBy(p => p.Category)
            //    .ThenByDescending(p => p.UnitPrice)
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.Category} - {product.ProductName} - {product.UnitPrice}");
            //}

            #endregion
            #region Q9

            //var result = Source.ProductList
            //    .Where(p => p.Category == "Beverages")
            //    .OrderByDescending(p => p.UnitsInStock)
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - Stock: {product.UnitsInStock}");
            //}

            #endregion
            #region Q10
            //var result =
            //    from customer in Source.CustomerList
            //    from order in customer.Orders
            //    where order.OrderDate >= new DateTime(1997, 1, 1)
            //    select new
            //    {
            //        customer.CustomerID,
            //        order.OrderDate
            //    };

            //foreach (var item in resullt)
            //{
            //    Console.WriteLine($"{item.CustomerID} - {item.OrderDate}");
            //}

            #endregion
            #region Q11
            //        var result = Source.ProductList
            //.Select((p, index) => new
            //{
            //    Position = index + 1,
            //    ProductName = p.ProductName
            //})
            //.ToList();

            //        foreach (var item in result)
            //        {
            //            Console.WriteLine($"{item.Position}. {item.ProductName}");
            //        }

            #endregion

            string[] Arr = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            #region Q12

            //var result = Arr
            //    .OrderBy(word => word.Length)
            //    .ThenBy(word => word, StringComparer.OrdinalIgnoreCase)
            //    .ToList();

            //foreach (var word in result)
            //{
            //    Console.WriteLine(word);
            //}
            #endregion
            #region Q13

            //var result1 = Arr
            //    .Where(word => word.Length > 1 && word[1] == 'i')
            //    .Reverse()
            //    .ToList();

            //foreach (var word in result1)
            //{
            //    Console.WriteLine(word);
            //}

            #endregion

            #endregion
            #region G-ASP-NET-81-LINQ02

            #region Q1

            //var result = Source.ProductList
            //    .OrderByDescending(p => p.UnitPrice)
            //    .Take(3)
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}

            #endregion
            #region Q2

            //var result = Source.ProductList
            //    .Skip(5)
            //    .Take(5)
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}

            #endregion
            #region Q3

            //var result = Source.ProductList
            //    .OrderBy(p => p.UnitPrice)
            //    .TakeWhile(p => p.UnitPrice < 25)
            //    .ToList();

            //foreach (var product in result)
            //{
            //    Console.WriteLine($"{product.ProductName} - {product.UnitPrice}");
            //}

            #endregion
            #region Q4
            //bool result = Source.ProductList
            //    .Where(p => p.Category == "Seafood")
            //    .All(p => p.UnitsInStock > 0);

            //Console.WriteLine(result);

            #endregion
            #region Q5

            //int[] ids = { 3, 9, 13, 18 };

            //bool result = ids.Contains(9);

            //Console.WriteLine(result);

            #endregion
            #region Q6

            //var result = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .ToList();

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Key}");
            //    Console.WriteLine($"Count: {group.Count()}");
            //}

            #endregion
            #region Q7

            //var result = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Select(g => new
            //    {
            //        Category = g.Key,
            //        ProductNames = g.Select(p => p.ProductName)
            //    });

            //foreach (var group in result)
            //{
            //    Console.WriteLine($"Category: {group.Category}");

            //    foreach (var name in group.ProductNames)
            //    {
            //        Console.WriteLine(name);
            //    }
            //}

            #endregion
            #region Q8

            //var result = Source.ProductList
            //    .GroupBy(p => p.Category)
            //    .Where(g => g.Count() > 3)
            //    .Select(g => g.Key);

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion
            #region Q9

            //var result =
            //    from customer in Source.CustomerList
            //    group customer by customer.Country into countryGroup
            //    select new
            //    {
            //        Country = countryGroup.Key,
            //        Count = countryGroup.Count(),
            //        TotalOrderValue = countryGroup
            //            .SelectMany(c => c.Orders)
            //            .Sum(o => o.Total)
            //    };

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"Country: {item.Country}");
            //    Console.WriteLine($"Customers Count: {item.Count}");
            //    Console.WriteLine($"Total Order Value: {item.TotalOrderValue}");
            //    Console.WriteLine("--------------------");
            //}

            #endregion
            #region Q10

            //var result = Source.ProductList
            //    .Sum(p => p.UnitsInStock);

            //Console.WriteLine($"Total Units In Stock: {result}");

            #endregion
            #region Q11

            //var cheapestPrice = Source.ProductList
            //    .Min(p => p.UnitPrice);

            //var mostExpensivePrice = Source.ProductList
            //    .Max(p => p.UnitPrice);

            //Console.WriteLine($"Cheapest Price: {cheapestPrice}");
            //Console.WriteLine($"Most Expensive Price: {mostExpensivePrice}");

            #endregion
            #region Q12

            //var result = Source.ProductList
            //    .Select(p => p.Category)
            //    .Distinct()
            //    .ToList();

            //foreach (var category in result)
            //{
            //    Console.WriteLine(category);
            //}

            #endregion
            #region Q13

            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA
            //    .Except(setB)
            //    .ToList();

            //foreach (var id in result)
            //{
            //    Console.WriteLine(id);
            //}

            #endregion
            #region Q14

            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1
            //    .Except(list2, StringComparer.OrdinalIgnoreCase)
            //    .ToList();

            //foreach (var country in result)
            //{
            //    Console.WriteLine(country);
            //}

            #endregion
            #region Q15

            //var productDictionary = Source.ProductList
            //    .ToDictionary(p => p.ProductID);

            //if (productDictionary.TryGetValue(18, out var product))
            //{
            //    Console.WriteLine($"Product ID: {product.ProductID}");
            //    Console.WriteLine($"Product Name: {product.ProductName}");
            //    Console.WriteLine($"Price: {product.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("Product not found.");
            //}

            #endregion
            #region Q16

            //var result = Source.ProductList
            //    .First(p => p.UnitPrice > 50);

            //Console.WriteLine($"Product Name: {result.ProductName}");
            //Console.WriteLine($"Price: {result.UnitPrice}");

            #endregion
            #region Q17

            //var result = Source.ProductList
            //    .FirstOrDefault(p => p.UnitPrice > 500);

            //if (result != null)
            //{
            //    Console.WriteLine($"Product Name: {result.ProductName}");
            //    Console.WriteLine($"Price: {result.UnitPrice}");
            //}
            //else
            //{
            //    Console.WriteLine("No product found.");
            //}

            #endregion
            #region Q18

            //var result = Enumerable.Range(1, 10)
            //    .Select(i => $"{7} x {i} = {7 * i}");

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
            #region Q19

            //var result = Enumerable.Range(1, 30)
            //    .Where(n => n % 2 == 0)
            //    .ToList();

            //foreach (var number in result)
            //{
            //    Console.WriteLine(number);
            //}

            #endregion
            #region Q20

            //var result = Source.ProductList
            //    .Take(3)
            //    .Select(p => p.ProductName)
            //    .Concat(
            //        Source.CustomerList
            //            .Take(3)
            //            .Select(c => c.CompanyName)
            //    );

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            #endregion
            #region Q21

            //var result = Source.ProductList
            //    .Zip(
            //        Source.CustomerList,
            //        (product, customer) =>
            //            $"{product.ProductName} sold to {customer.CompanyName}"
            //    );

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion





            #endregion


        }
    }
}
