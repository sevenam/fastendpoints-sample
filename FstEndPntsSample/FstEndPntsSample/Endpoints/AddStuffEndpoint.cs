using FstEndPntsSample.Dtos;
using FstEndPntsSample.Services;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace FstEndPntsSample.Endpoints
{
  [HttpPost("api/stuff"), AllowAnonymous]
  public class AddStuffEndpoint : Endpoint<Stuff, bool> //probably want cleaner request/response objects here...
  {
    private readonly IStuffService stuffService;

    public AddStuffEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public override async Task HandleAsync(Stuff newStuff, CancellationToken ct)
    {
      var result = stuffService.AddStuff(newStuff);
      await SendAsync(result, (int)HttpStatusCode.Created, ct);
    }

  }
}
