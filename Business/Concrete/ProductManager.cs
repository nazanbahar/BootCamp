using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {

        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;

        }



        public IResult Add(Product product)
        {
            //Business Rules
            if (product.CategoryId == 1)
            {
                return new ErrorResult(Messages.CannotBeAccepted);
            }
            else
            {
                _productDal.Add(product);

                return new SuccessResult(Messages.ProductAdded);
            }
        }


        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult(Messages.ProductUpdated);
        }


        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult(Messages.ProductDeleted);
        }


        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ProductsListed);
        }

        public IDataResult<List<Product>> GetAllByBrand(int brandId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.BrandId == brandId));

        }


        public IDataResult<List<Product>> GetAllByCategory(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == categoryId));
        }



        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.Id == id), Messages.RecordListed);
        }

        public int CheckStock(int productId)
        {
            throw new NotImplementedException();  
        }
    }  
}
