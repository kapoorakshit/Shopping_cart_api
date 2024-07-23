using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreAssingment_Api_BAL_DAL.Repository_Pattern
{
    public interface IMyCrud<T> where T : class
    {
        Task<List<T>> GetAll();
        Task<List<string>> GetImagesByProductId(int id);
        Task<T> GetById(int id);
        Task<List<T>> GetByIdd(string id);
        void Delete(int id);
        void Insert(T obj);
        void Update(T obj);
        void Save();
        int GetImagesCountForProduct(int productId);
        Task UpdateUrl(string id, string newUrl);
    }
}
