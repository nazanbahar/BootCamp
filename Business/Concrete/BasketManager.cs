using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;
/// <summary>
/// YILDIZLI NOT: 
/// Kural: Bir Sınıf, sadece kendi Dal'ını enjekte edebilir.
/// Farklı bir Dal 'ı enjekte edemez. Fakat Başka Service'i enjekte edebilir.
/// MicroService tabanlı mimarilerde önemlidir.
/// Product'a ihtiyacımız varsa Servis'i enjekte etmeiyiz!.
/// 
/// Baska servisi enjekte edebiliriz.
/// Bir servis sadece kendi Dal'ını enjekte edebilir.
/// SOLID Preonsipleri gereği, servis backend ve frontend de aynı operasyonları kullanmaktadır.
/// </summary>
namespace Business.Concrete
{
    public class BasketManager : IBasketService
    {
        IBasketDal _basketDal;
        IProductService _productService;

        //sepete eklerken ürün değişikliği
        public BasketManager(IBasketDal basketDal, IProductService productService)
        {
            _basketDal = basketDal;
            _productService = productService;
        }

        public IResult Add(Basket basket)
        {
            //Business Rules - MicroServices Mimari
            if (_productService.CheckStock(basket.ProductId) > 0)
            {
                return new ErrorResult(Messages.ProductNotFound);
            }
            _basketDal.Add(basket);
            return new SuccessResult(Messages.AddedCart);

        }


        public IResult Update(Basket basket)
        {
            _basketDal.Update(basket);
            return new SuccessResult(Messages.ProductUpdated);
        }


        public IResult Delete(Basket basket)
        {
            _basketDal.Update(basket);
            return new SuccessResult(Messages.ProductDeleted);
        }


        public IDataResult<List<Basket>> GetAll()
        {
            return new SuccessDataResult<List<Basket>>(_basketDal.GetAll(), Messages.ProductsListed);

        }

        public IDataResult<Basket> GetById(int id)
        {
            return new SuccessDataResult<Basket>(_basketDal.Get(b => b.Id == id), Messages.RecordListed);
        }
    }
}
