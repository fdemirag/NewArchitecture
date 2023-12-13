using System;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities;
using Entities.Concretes;

namespace Business.Abstracts
{
	public interface ICustomerService
	{

        Task<IPaginate<GetListCustomerResponse>> GetListAsync(PageRequest pageRequest);
        Task<CreatedCustomerResponse> Add(CreateCustomerRequest createCustomerRequest);
        Task<DeletedCustomerResponse>Delete(DeleteCustomerRequest deleteCustomerRequest);
        Task<UpdatedCustomerResponse> Update(UpdateCustomerRequest updateCustomerRequest);

    }
}

