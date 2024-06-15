namespace Petfolio.Communication.Responses;
public class PetRegisterResponse
{
    public int Id { get; set; }

    public string Name { get; set; }

    public PetRegisterResponse(int id, string name)
    {
        Id = id;
        Name = name;
    }
}
