using FstEndPntsSample.Dtos;
using FstEndPntsSample.Services;
using Microsoft.AspNetCore.Authorization;
using System.Net;

namespace FstEndPntsSample.Endpoints
{
  [HttpDelete("api/stuff/{id}"), AllowAnonymous]
  public class DeleteStuffEndpoint : Endpoint<Guid, bool> //probably want cleaner request/response objects here...
  {
    private readonly IStuffService stuffService;

    public DeleteStuffEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public override async Task HandleAsync(Guid id, CancellationToken ct)
    {
      var result = stuffService.RemoveStuff(id);
      await SendOkAsync(result, ct);
    }
  }
}
