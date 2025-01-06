﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MultiShop.Order.Application.Features.CQRS.Queries.AddressQueries;
using MultiShop.Order.Application.Features.CQRS.Results.AddressResults;
using MultiShop.Order.Application.Interfaces;
using MultiShop.Order.Domain.Entities;

namespace MultiShop.Order.Application.Features.CQRS.Handlers.AddressHandlers
{
    public class GetAddressByIdQueryHandler
    {
        private readonly IRepository<Address> _repository;

        public GetAddressByIdQueryHandler(IRepository<Address> repository)
        {
            _repository = repository;
        }

        public async Task<GetAddressByIdQueryResult> Handle(GetAddressByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAddressByIdQueryResult
            {
                AddresId = values.AddressId,
                City = values.City,
                Detail1 = values.Detail1,
                Detail2 = values.Detail2,
                District = values.District,
                UserId = values.UserId,
                Country = values.Country,
                Description = values.Description,
                Email = values.Email,
                Name = values.Name,
                Surname = values.Surname,
                Phone = values.Phone,
                ZipCode = values.ZipCode
            };
        }
    }
}
