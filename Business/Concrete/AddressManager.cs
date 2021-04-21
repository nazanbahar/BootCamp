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
    public class AddressManager : IAddressService
    {
        IAddressDal _addressDal;

        public AddressManager(IAddressDal addressDal)
        {
            _addressDal = addressDal;
        }

        public IResult Add(Address address)
        {
           
                _addressDal.Add(address);
                return new SuccessResult(Messages.RegistrationAdded);
        }


        public IDataResult<List<Address>> GetAll()
        {
            return new SuccessDataResult<List<Address>>(_addressDal.GetAll(), Messages.RecordListed);
        }
    }
}
