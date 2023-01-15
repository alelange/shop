using Shop.Domain.Comands.Requests;
using Shop.Domain.Comands.Responses;

namespace Shop.Domain.Handlers {
    public class CreateCustomerHandler : ICreateCustomerHandler
    {
        public CreateCustomerResponse Handle(CreateCustomerRequest request)
        {
            // Verifica se o cliente já está cadastrado
            // Valida os dados
            // Insere o cliente
            // Envia e-mail de boas vindas

            return new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = "Alexandre Lange",
                Email = "alhala@gmail.com",
                Date = DateTime.Now
            };
        }
    }
}