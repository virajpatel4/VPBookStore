using System;
using System.Collections.Generic;
using System.Text;
using VPBook.Models;

namespace VPBook.DataAccess.Repository.IRepository
{
    public interface ICoverTypeRepository : IRepository<CoverType>
    {
        void Update(CoverType coverType);
    }
}
