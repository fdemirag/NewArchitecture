using System;
using Business.Messages;
using Core.CrossCuttingConcerns.Exceptions.Types;
using DataAccess.Abstracts;

namespace Business.Rules
{
	public class CustomerBusinessRules
	{
		private readonly ICustomerDal _customerDal;

        public CustomerBusinessRules(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public async Task CityMax10(string city)
        {
            var result = await _customerDal.GetListAsync(predicate: p => p.City == city, size: 15);
            if (result.Count >= 10)
            {
                throw new BusinessException(BusinessMessages.CategoryProductLimit);
            }
        }
    }
}

