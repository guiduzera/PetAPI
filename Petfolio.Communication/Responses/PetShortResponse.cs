﻿using Petfolio.Communication.Enums;

namespace Petfolio.Communication.Responses;
public class PetShortResponse
{
    public int Id { get; set; }
    public string Name { get; set; } = String.Empty;
    public PetType Type { get; set; }
}
