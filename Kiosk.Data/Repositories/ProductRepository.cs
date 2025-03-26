using Kiosk.Core.Repositories.IRepositories;
using Kiosk.Data.Models;

namespace Kiosk.Core.Repositories
{
    internal class ProductRepository : IBaseRepository<Product>
    {
        public Task<Product> AddAsync(Product entity)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Product>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<Product> GetByIdAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Product> UpdateAsync(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
