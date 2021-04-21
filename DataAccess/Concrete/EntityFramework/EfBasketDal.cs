using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
/// <summary>
/// filtreleme, listeleme tüm işlemler...
/// </summary>
namespace DataAccess.Concrete.EntityFramework
{
    public class EfBasketDal:EfEntityRepositoryBase<Basket,DatabaseContext>,IBasketDal
    {
    }
}
