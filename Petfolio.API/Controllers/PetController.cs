using Microsoft.AspNetCore.Mvc;
using Petfolio.Application.UseCases.Pets.Delete;
using Petfolio.Application.UseCases.Pets.GetAll;
using Petfolio.Application.UseCases.Pets.GetById;
using Petfolio.Application.UseCases.Pets.Register;
using Petfolio.Application.UseCases.Pets.Update;
using Petfolio.Communication.Requests;
using Petfolio.Communication.Responses;

namespace Petfolio.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PetController : ControllerBase
{
    [HttpPost]
    [ProducesResponseType(typeof(PetRegisterResponse), StatusCodes.Status201Created)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
    public IActionResult Register([FromBody] RegisterPetRequest pet) 
    {
        PetRegisterResponse response = new RegisterPetUseCase().Execute(pet);

        return Created(String.Empty, response);
    }

    [HttpPut]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status400BadRequest)]
    public IActionResult Update([FromRoute] string id, [FromBody] RegisterPetRequest pet) 
    {
        new UpdatePetUseCase().Execute(id, pet);
        
        return NoContent();
    }

    [HttpGet]
    [ProducesResponseType(typeof(AllPetsResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    public IActionResult GetAll() 
    {
        AllPetsResponse response = new GetAllPetsUseCase().Execute();

        if (response.Pets.Count == 0)
        {
            return NoContent();
        }

        return Ok(response);
    }

    [HttpGet]
    [Route("{id}")]
    [ProducesResponseType(typeof(PetResponse), StatusCodes.Status200OK)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status404NotFound)]
    public IActionResult GetById([FromRoute] int id)
    {
        PetResponse response = new GetPetById().Execute(id);

        if (response == null)
        {
            return NotFound();
        }

        return Ok(response);
    }

    [HttpDelete]
    [Route("{id}")]
    [ProducesResponseType(StatusCodes.Status204NoContent)]
    [ProducesResponseType(typeof(ResponseError), StatusCodes.Status404NotFound)]
    public IActionResult Delete([FromRoute] int id)
    {
        new DeletePetUseCase().Execute(id);

        return NoContent();
    }
}
