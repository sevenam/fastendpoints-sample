using FstEndPntsSample.Dtos;
using FstEndPntsSample.Services;
using Microsoft.AspNetCore.Authorization;

namespace FstEndPntsSample.Endpoints
{
  [HttpGet("api/stuff"), AllowAnonymous]
  public class GetAllTheStuffEndpoint : EndpointWithoutRequest<List<Stuff>>
  {
    private readonly IStuffService stuffService;

    public GetAllTheStuffEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public override async Task HandleAsync(CancellationToken ct)
    {
      var allofthestuff = stuffService.GetAllTheStuff();
      await SendOkAsync(allofthestuff, ct);
    }

  }
}
