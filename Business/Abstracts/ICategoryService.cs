using System;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface ICategoryService
	{
        Task<IPaginate<Category>> GetListAsync();
        Task Add(Category category);
    }
}

