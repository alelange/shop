using MediatR;
using Shop.Domain.Comands.Requests;
using Shop.Domain.Comands.Responses;

namespace Shop.Domain.Handlers {
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            var result = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Alexandre Lange",
                Email = "alhala@gmail.com",
                Date = DateTime.Now
            };

            return Task.FromResult(result);
        }
    }
}