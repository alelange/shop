using Shop.Domain.Comands.Requests;
using Shop.Domain.Comands.Responses;

namespace Shop.Domain.Handlers {
    public interface ICreateCustomerHandler
    {
        CreateCustomerResponse Handle(CreateCustomerRequest request);
    }
}