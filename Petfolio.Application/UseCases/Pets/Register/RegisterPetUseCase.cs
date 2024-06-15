using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.Register;
public class RegisterPetUseCase
{
    public PetRegisterResponse Execute(RegisterPetRequest request)
    {
        return new PetRegisterResponse(
            id: 1,
            name: request.Name
        );
    }
}
