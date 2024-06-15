using Petfolio.Communication.Responses;

namespace Petfolio.Application.UseCases.Pets.GetById;
public class GetPetById
{
    public PetResponse Execute(int id)
    {
        return new PetResponse
        {
            Id = id,
            Name = "Rex",
            BirthDay = new DateTime(year: 2003, month: 10, day: 17),
            Type = Communication.Enums.PetType.Dog
        };
    }
}
