﻿using System;
using AutoMapper;
using Business.Abstracts;
using Business.Dtos.Requests;
using Business.Dtos.Responses;
using Core.DataAccess.Paging;
using DataAccess.Abstracts;
using Entities.Concretes;
using Microsoft.EntityFrameworkCore;

namespace Business.Concretes
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        IMapper _mapper;

        public ProductManager(IProductDal productDal,IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

       

        public async Task<CreatedProductResponse> Add(CreateProductRequest createProductRequest)
        {
            //Product product = new Product();
            //product.Id = Guid.NewGuid();
            //product.ProductName = createProductRequest.ProductName;
            //product.UnitPrice = createProductRequest.UnitPrice;
            //product.QuantityPerUnit = createProductRequest.QuantityPerUnit;
            //product.UnitsInStock = createProductRequest.UnitsInStock;

            //Product createdProduct = await _productDal.AddAsync(product);

            //CreatedProductResponse createdProductResponse = new CreatedProductResponse();
            //createdProductResponse.Id = createdProduct.Id;
            //createdProductResponse.ProductName = createdProduct.ProductName;
            //createdProductResponse.UnitPrice = createdProduct.UnitPrice;
            //createdProductResponse.QuantityPerUnit = createdProduct.QuantityPerUnit;
            //createdProductResponse.UnitsInStock = createdProduct.UnitsInStock;

            //return createdProductResponse;
            var product = _mapper.Map<Product>(createProductRequest);
            var addedProduct = await _productDal.AddAsync(product);
            var responseProduct = _mapper.Map<CreatedProductResponse>(addedProduct);
            return responseProduct;

        }

        public async Task<IPaginate<GetListProductResponse>> GetListAsync()
        {
            var data = await _productDal.GetListAsync(
                include: p => p.Include(p => p.Category),
                index: pageRequest.PageIndex,
                size: pageRequest.PageSize

            );

            var result = _mapper.Map<Paginate<GetListProductResponse>>(data);
            return result;

        }
     }
}

