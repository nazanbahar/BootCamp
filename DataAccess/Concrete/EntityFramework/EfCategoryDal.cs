using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal:EfEntityRepositoryBase<Category, DatabaseContext>, ICategoryDal
    {
    }
}
