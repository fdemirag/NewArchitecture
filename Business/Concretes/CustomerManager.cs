using System;
using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Business.Rules;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using DataAccess.Concretes;
using Entities;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class CustomerManager : ICustomerService
    {
        ICustomerDal _customerDal;
        IMapper _mapper;
        CustomerBusinessRules _customerBusinessRules;

        public CustomerManager(ICustomerDal customerDal, IMapper mapper, CustomerBusinessRules customerBusinessRules)
        {
            _customerDal = customerDal;
            _mapper = mapper;
            _customerBusinessRules = customerBusinessRules;
        }

        public async Task<CreatedCustomerResponse> Add(CreateCustomerRequest createCustomerRequest)
        {
            var customer = _mapper.Map<Customer>(createCustomerRequest);
            var addedCustomer = await _customerDal.AddAsync(customer);
            var responseCustomer = _mapper.Map<CreatedCustomerResponse>(addedCustomer);
            return responseCustomer;
        }

        public async Task<DeletedCustomerResponse> Delete(DeleteCustomerRequest deleteCustomerRequest)
        {
            var customer = _mapper.Map<Customer>(deleteCustomerRequest);
            var deletedCustomer = await _customerDal.DeleteAsync(customer);
            var responseCustomer = _mapper.Map<DeletedCustomerResponse>(deletedCustomer);
            return responseCustomer;
        }

        public async Task<IPaginate<GetListCustomerResponse>> GetListAsync(PageRequest pageRequest)
        {
            var data = await _customerDal.GetListAsync(
               index: pageRequest.PageIndex,
               size: pageRequest.PageSize
           );
            var result = _mapper.Map<Paginate<GetListCustomerResponse>>(data);
            return result;
        }

        public async Task<UpdatedCustomerResponse> Update(UpdateCustomerRequest updateCustomerRequest)
        {
            var customer = _mapper.Map<Customer>(updateCustomerRequest);
            var updatedCustomer = await _customerDal.UpdateAsync(customer);
            var responseCustomer = _mapper.Map<UpdatedCustomerResponse>(updatedCustomer);
            return responseCustomer;
        }
    }

}


