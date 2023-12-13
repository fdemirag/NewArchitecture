using System;
using AutoMapper;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using Entities.Concretes;

namespace Business.AutoMapper.Profiles
{
	public class ProductProfile:Profile
    {
        public ProductProfile()
        {
            CreateMap<Product, GetListProductResponse>().ForMember(destinationMember: p => p.CategoryName, memberOptions: opt => opt.MapFrom(p => p.Category.Name)).ReverseMap();
          
            CreateMap<Product, CreatedProductResponse>();
            CreateMap<Paginate<Product>, Paginate<GetListProductResponse>>();

            CreateMap<Paginate<Product>, Paginate<GetListProductResponse>>().ReverseMap();
            CreateMap<Product, CreateProductRequest>().ReverseMap();

        }
    }
}

