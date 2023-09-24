using Microsoft.EntityFrameworkCore;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var context = new EFContext();
            #region Include
            var query = context.Products.Include(c => c.Category)
                .ThenInclude(c => c.MainCategory)
                .AsQueryable();
            Console.WriteLine(query.ToQueryString());
            var data = query.ToList();
            foreach (var item in data)
            {
                Console.WriteLine(item.Category.MainCategory.Name);
            }
            #endregion

            #region Load
            //var category = context.Categories.First(p => p.Id == 1);
            //context.Products.Where(p => p.CategoryId == category.Id).Load();
            //foreach(var product in category.Products)
            //{
            //    Console.WriteLine(product.Name);
            //}
            #endregion

            #region LazyLoading
            //var products = context.Products.ToList();
            //foreach(var item in products)
            //{

            //    Console.WriteLine(item.Category.Name);
            //}
            #endregion

        }
    }
}