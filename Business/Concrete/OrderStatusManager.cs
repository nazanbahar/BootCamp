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
    public class OrderStatusManager : IOrderStatusService
    {

        IOrderStatusDal _orderStatusDal;

        public OrderStatusManager(IOrderStatusDal orderStatusDal)
        {
            _orderStatusDal = orderStatusDal;
        }


        public IResult Add(OrderStatus orderStatus)
        {
            _orderStatusDal.Add(orderStatus);
            return new SuccessResult(Messages.RegistrationAdded);
        }

        public IDataResult<List<OrderStatus>> GetAll()
        {
            return new SuccessDataResult<List<OrderStatus>>(_orderStatusDal.GetAll(), Messages.RecordListed);
        }
    }
}
