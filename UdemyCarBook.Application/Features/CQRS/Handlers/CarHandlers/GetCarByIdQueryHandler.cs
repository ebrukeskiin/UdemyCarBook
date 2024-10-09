using UdemyCarBook.Application.Features.CQRS.Queries.CarQueries;
using UdemyCarBook.Application.Features.CQRS.Results.CarResults;
using UdemyCarBook.Application.Interfaces;
using UdemyCarBook.Domain.Entities;

namespace UdemyCarBook.Application.Features.CQRS.Handlers.CarHandlers
{
    public class GetCarByIdQueryHandler
    {
            private readonly IRepository<Car> _repository;

            public GetCarByIdQueryHandler(IRepository<Car> repository)
            {
                _repository = repository;
            }
            public async Task<GetCarByIdQueryResult> Handle(GetCarByIdQuery query)
            {
                var values = await _repository.GetByIdAsync(query.Id);
                return new GetCarByIdQueryResult
                {
                    BrandID = values.BrandID,
                   BigImageUrl = values.BigImageUrl,
                   CarID = values.CarID,
                   Seat = values.Seat,
                   Transmission = values.Transmission, 
                   CoverImageUrl = values.CoverImageUrl,
                   Fuel=values.Fuel,
                   Model=values.Model,
                   Km=values.Km,
                   Luggage=values.Luggage
                };
            }
        }
    }
