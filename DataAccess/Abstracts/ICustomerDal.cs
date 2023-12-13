
using System;
using Core.DataAccess.Repositories;
using Entities;
using Entities.Concretes;

namespace DataAccess.Abstracts
{
	public interface ICustomerDal : IRepository<Customer, string>, IAsyncRepository<Customer, string>
    {
	}
}

