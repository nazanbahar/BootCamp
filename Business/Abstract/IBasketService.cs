using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IBasketService
    {
        IDataResult<List<Basket>> GetAll();
        IDataResult<Basket> GetById(int id);
        IResult Add(Basket basket);
        IResult Delete(Basket basket);
        IResult Update(Basket basket);
   
    }
}
