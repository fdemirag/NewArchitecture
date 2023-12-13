using System;
using Core.DataAccess.Repositories;
using DataAccess.Abstracts;
using DataAccess.Contexts;
using Entities;
using Entities.Concretes;

namespace DataAccess.Concretes
{
    public class EfCustomerDal : EfRepositoryBase<Customer, string, NorthwindContext>, ICustomerDal
    {
        public EfCustomerDal(NorthwindContext context) : base(context)
        {
        }
    }
}

