using System;
using Business.Abstracts;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;

namespace Business.Concretes
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task Add(Category category)
        {
            await _categoryDal.AddAsync(category);
        }

        public async Task<IPaginate<Category>> GetListAsync()
        {
            return await _categoryDal.GetListAsync();
        }
    }
}

