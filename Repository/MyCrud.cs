
using Core_Assingment_Api.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Shopping_cart_api.Data;

namespace CoreAssingment_Api_BAL_DAL.Repository_Pattern
{

    public class MyCrud<T> : IMyCrud<T> where T : class
    {
        private ApplicationDbContext _context = null;
        private DbSet<T> table = null;

        public MyCrud(ApplicationDbContext _context)
        {
            this._context = _context;
            table = _context.Set<T>();
        }
        public async Task<List<T>> GetAll()
        {
            return table.ToList();
        }
        public async Task<T> GetById(int id)
        {
            return table.Find(id);
        }
        public async Task<List<string>> GetImagesByProductId(int id)
        {
            try
            {
                var productsWithMatchingProductId = await table
                    .Where(x => EF.Property<int>(x, "ProductId") == id)
                    .ToListAsync();
                // Assuming each product has a URL property
                var imageUrls = productsWithMatchingProductId
                          .Select(product => product.GetType().GetProperty("URL")?.GetValue(product)?.ToString())
                          .Where(url => url != null)
                          .ToList();

                return imageUrls;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                Console.WriteLine(ex.Message);
                return new List<string>(); // or return an appropriate default value
            }
        }
        public async Task<List<T>> GetByIdd(string id)
        {
            var users = await table.ToListAsync();

            var matchingUsers = users.Where(x =>
            {
                var userIdProperty = x.GetType().GetProperty("UserId");
                var userIdValue = userIdProperty?.GetValue(x);
                return userIdValue != null && userIdValue.ToString() == id;
            }).ToList();

            return matchingUsers;
        }
        public void Insert(T obj)
        {
            table.Add(obj);
        }
        public void Delete(int id)
        {
            try
            {
                var t = table.Find(id);
                if (t != null)
                {
                    table.Remove(t);
                }
                else
                {
                    Console.WriteLine("enter the correct id please");
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public void Update(T obj)
        {
            try
            {
                if (obj == null)
                {
                    Console.WriteLine("bad request");
                }
                else
                {
                    table.Update(obj);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        public void Save()
        {
            _context.SaveChanges();
        }
        public int GetImagesCountForProduct(int productId)
        {
            try
            {
                var count = table.Count(x => EF.Property<int>(x, "ProductId") == productId);
                return count;
            }
            catch (Exception ex)
            {
                // Log the exception or handle it appropriately
                Console.WriteLine(ex.Message);
                return 0; // or return an appropriate default value
            }
        }
        public async Task UpdateUrl(string id, string newUrl)
        {
            var products = await table.ToListAsync();

            var productToUpdate = products.FirstOrDefault(p =>
            {
                var urlProperty = p.GetType().GetProperty("URL");
                var urlValue = urlProperty?.GetValue(p);
                return urlValue != null && urlValue.ToString() == id;
            });

            if (productToUpdate != null)
            {
                // Update the 'URL' property with the new value
                var urlProperty = productToUpdate.GetType().GetProperty("URL");
                urlProperty?.SetValue(productToUpdate, newUrl);

                // Save changes to the database
           
            }
        }



    }
}

