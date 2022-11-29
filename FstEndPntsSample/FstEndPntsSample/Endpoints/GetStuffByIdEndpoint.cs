using FstEndPntsSample.Dtos;
using FstEndPntsSample.Services;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace FstEndPntsSample.Endpoints
{
  [HttpGet("api/stuff/{id:guid}"), AllowAnonymous]
  public class GetStuffByIdEndpoint : Endpoint<Guid, Stuff> //probably want cleaner request/response objects here...
  {
    private readonly IStuffService stuffService;

    public GetStuffByIdEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public override async Task HandleAsync(Guid id, CancellationToken ct)
    {
      var result = stuffService.GetStuffById(id);
      await SendOkAsync(result, ct);
    }

  }
}
