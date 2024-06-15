using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetAll;

public class GetAllPetsUseCase
{
    public AllPetsResponse Execute()
    {
        return new AllPetsResponse
        {
            Pets = new List<PetShortResponse>
            {
                new PetShortResponse
                {
                    Id = 1,
                    Name = "Rex",
                    Type = Communication.Enums.PetType.Dog
                },
                new PetShortResponse
                {
                    Id = 2,
                    Name = "Mittens",
                    Type = Communication.Enums.PetType.Cat
                }
            }
        };
    }
}
