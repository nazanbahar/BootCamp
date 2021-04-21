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
    public class CountryManager : ICountryService
    {

        ICountryDal _countryDal;

        public CountryManager(ICountryDal countryDal)
        {
            _countryDal = countryDal;
        }

        public IResult Add(Country country)
        {
            _countryDal.Add(country);
            return new SuccessResult(Messages.RegistrationAdded);
        }

        public IDataResult<List<Country>> GetAll()
        {
            return new SuccessDataResult<List<Country>>(_countryDal.GetAll(), Messages.RecordListed);
        }
    }
}
