using System;
using System.Collections.Generic;
using System.Text;
using VPBook.Models;

namespace VPBook.DataAccess.Repository.IRepository
{
    public interface IProductRepository : IRepository<Product>
    {
        void Update(Product product);
    }
}
