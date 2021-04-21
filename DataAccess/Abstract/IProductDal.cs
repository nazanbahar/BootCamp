using Core.DataAccess;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// s1. Object Type
/// </summary>
namespace DataAccess.Abstract
{
    public interface IProductDal:IEntityRepository<Product>
    {
    }
}
