using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IAddressService
    {
        IDataResult<List<Address>> GetAll();
        IResult Add(Address address);
    }
}
