using Application.Features.Brands.Commands.Create;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[Route("api/Brands")]
[ApiController]
public class BrandsControllers:BaseController
{
    [HttpPost]
    public async Task<IActionResult> Add([FromBody] CreateBrandCommand createBrandCommand)
    {
        CreatedBrandResponse response =  await Mediator.Send(createBrandCommand);
        return Ok(response);
    }
}