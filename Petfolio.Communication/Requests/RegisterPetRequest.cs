using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Requests;
public class RegisterPetRequest
{
    public string Name { get; set; }

    public DateTime BirthDay { get; set; }

    public PetType Type { get; set; }

    public RegisterPetRequest(string name, DateTime birthDay, PetType type)
    {
        Name = name;
        BirthDay = birthDay;
        Type = type;
    }
}
