using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;
public class PetResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;

    public DateTime BirthDay { get; set; }

    public PetType Type { get; set; }
}
