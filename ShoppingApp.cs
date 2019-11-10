using System;
using System.Linq;
using System.Windows.Forms;

namespace EntityFrameworkForms
{
    static class ShoppingApp
    {
        [STAThread]
        static void Main()
        {
            ShowConsoleInformation();

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AuthorizationForm());
        }

        static void ShowConsoleInformation()
        {
            ShowCategories();
            ShowProducts_Joins();
            ShowProducts_Reference();
            ShowProducts_NavigationProperties();
            // AddNewCategory_Console();
        }

        static void ShowCategories()
        {
            using (var ctx = new ProdContext())
            {
                Console.WriteLine("Available categories:");
                foreach (Category c in ctx.Categories.OrderByDescending(x => x.Name))
                {
                    Console.WriteLine("- " + c.Name);
                }
            }
        }

        static void ShowProducts_Joins()
        {
            using (ProdContext ctx = new ProdContext())
            {
                // Eagerly

                //var products = ctx.Categories
                //    .Join(
                //    ctx.Products,
                //    c => c.CategoryId,
                //    p => p.CategoryId,
                //    (c, p) => new
                //    {
                //        CategoryName = c.Name,
                //        ProductName = p.Name,
                //        CategorySize = c.Products.Count()
                //    })
                //    .OrderBy(cp => cp.CategoryName)
                //    .ToList();

                var products = (from c in ctx.Categories
                                join p in ctx.Products on c.CategoryId equals p.CategoryId
                                orderby c.Name descending
                                select new
                                {
                                    CategoryName = c.Name,
                                    ProductName = p.Name,
                                    CategorySize = c.Products.Count()
                                })
                                .ToList();
                foreach (var p in products)
                {
                    Console.WriteLine("Product {0} belongs to category {1} with size {2}.", p.ProductName, p.CategoryName, p.CategorySize);
                }
            }
        }

        static void ShowProducts_Reference()
        {
            using (var ctx = new ProdContext())
            {
                // Lazy (by default dla pól 'virtual')

                //var products = ctx.Categories.Select(
                //    c => new
                //    {
                //        categoryName = c.Name,
                //        listOfProducts = c.Products,
                //    });

                var products = from c in ctx.Categories
                               select new
                               {
                                   categoryName = c.Name,
                                   listOfProducts = c.Products,
                               };

                foreach (var pc in products)
                {
                    Console.WriteLine("Category: {0} with {1} members:", pc.categoryName, pc.listOfProducts.Count());
                    foreach (var p in pc.listOfProducts)
                    {
                        Console.WriteLine("-- {0}", p.Name);
                    }
                }
            }
        }

        static void ShowProducts_NavigationProperties()
        {
            using (var ctx = new ProdContext())
            {
                Console.WriteLine("Available products:");
                foreach (Product p in ctx.Products)
                {
                    ctx.Entry(p).Reference(pr => pr.Category).Load();
                    if (null != p.Category)
                    {
                        Console.WriteLine("{0} {1} belongs to category {2}", p.ProductID, p.Name, p.Category.Name);
                    }
                    else
                    {
                        Console.WriteLine("{0} {1} does not belong to any category", p.ProductID, p.Name, p.Category.Name);
                    }
                }
            }
        }

        static void AddNewCategory_Console()
        {
            using (var ctx = new ProdContext())
            {
                Console.WriteLine("Provide new category name:");
                Category category = new Category
                {
                    Name = Console.ReadLine()
                };
                ctx.Categories.Add(category);
                ctx.SaveChanges();
            }
        }
    }
}