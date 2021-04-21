using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// #1: Developer gold-plating.  
/// gold plating: takip edilemeyen, yönetilemeyen code.
/// bkz. https://blog.codinghorror.com/gold-plating/
/// </summary>
namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();  //data version
        IDataResult<Product> GetById(int id);
        IDataResult<List<Product>> GetAllByCategory(int categoryId);
        IDataResult<List<Product>> GetAllByBrand(int brandId);
        IResult Add(Product product);  //without data
        IResult Update(Product product);  
        IResult Delete(Product product);
        //microServices
        int CheckStock(int productId);
    }
}
