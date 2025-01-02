using Application.Services.Repositories;
using Domain.Entities;
using MediatR;

namespace Application.Features.Brands.Commands.Create;

public class CreateBrandCommand :IRequest<CreatedBrandResponse>
{
    public string Name { get; set; }

    public class CreateBrandCommandHandler : IRequestHandler<CreateBrandCommand, CreatedBrandResponse>
    {
        private readonly IBrandRepository _brandRepository;
        public CreateBrandCommandHandler(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
        }
        public async Task<CreatedBrandResponse>? Handle(CreateBrandCommand request, CancellationToken cancellationToken)
        {
            Brand brand = new Brand();
            brand.Name = request.Name;
            
            var result =  await _brandRepository.AddAsync(brand);
            
            CreatedBrandResponse createdBrandResponse = new CreatedBrandResponse();
            createdBrandResponse.Id = result.Id;
            createdBrandResponse.Name = request.Name;
            return createdBrandResponse;
        }
    }
}