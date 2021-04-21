using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq.Expressions;

namespace DataAccess.Abstract
{
    public interface IBrandDal:IEntityRepository<Brand>
    {
    }
}
