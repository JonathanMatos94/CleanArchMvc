﻿using AutoMapper;
using CleanArchMvc.Application.DTOs;
using CleanArchMvc.Application.Interfaces;
using CleanArchMvc.Application.Products.Commands;
using CleanArchMvc.Application.Products.Queries;
using MediatR;

namespace CleanArchMvc.Application.Services;

public class ProductService : IProductService
{
    private readonly IMediator _mediator;
    private readonly IMapper _mapper;
    public ProductService(IMapper mapper, IMediator mediator)
    {
        _mapper = mapper;
        _mediator = mediator;
    }
    public async Task<IEnumerable<ProductDTO>> GetProducts()
    {
        var productQuery = new GetProductsQuery();

        if (productQuery == null)
        {
            throw new ApplicationException($"Entity could not be loaded");
        }
        else
        {
            var result = await _mediator.Send(productQuery);
            return _mapper.Map<IEnumerable<ProductDTO>>(result);
        }
    }
    public async Task<ProductDTO> GetById(int? id)
    {
        var productByIdQuery = new GetProductByIdQuery(id.Value);

        if (productByIdQuery == null)
        {
            throw new ApplicationException($"Entity could not be loaded");
        }
        var result = await _mediator.Send(productByIdQuery);

        return _mapper.Map<ProductDTO>(result);
    }

    public async Task Add(ProductDTO productDTO)
    {
        var productCreateCommand = _mapper.Map<ProductCreateCommand>(productDTO);
        await _mediator.Send(productCreateCommand);
    }
    public async Task Update(ProductDTO productDTO)
    {
        var productCreateCommand = _mapper.Map<ProductUpdateCommand>(productDTO);
        await _mediator.Send(productCreateCommand);
    }

    public async Task Delete(int? id)
    {
        var productRemoveCommand = new ProductRemoveCommand(id.Value);

        if (productRemoveCommand == null) throw new ApplicationException($"Entity could not be loaded");

        await _mediator.Send(productRemoveCommand);
    }

}
