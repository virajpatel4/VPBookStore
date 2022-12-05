using System;
using System.Collections.Generic;
using System.Text;
using VPBook.Models;

namespace VPBook.DataAccess.Repository.IRepository
{
    public interface ICategoryRepository : IRepository<Category>
    {
        void Update(Category category);
    }
}
