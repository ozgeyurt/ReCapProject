using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
   public interface ICustomerService
    {
        IResult Add(Customer customer);
        IResult Delete(Customer customer);
        IResult Update(Customer customer);
       List<Customer>GetAll();
       IDataResult <List<CustomerDetailDto>> GetCustomerDetails();
       IDataResult<List< Customer>> GetById(int customerId);
    }
}
