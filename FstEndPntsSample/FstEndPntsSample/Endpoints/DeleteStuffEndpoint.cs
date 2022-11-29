using FstEndPntsSample.Requests;
using FstEndPntsSample.Services;
using Microsoft.AspNetCore.Authorization;

namespace FstEndPntsSample.Endpoints
{
  [HttpDelete("api/stuff/{id}"), AllowAnonymous]
  public class DeleteStuffEndpoint : Endpoint<ByGuidRequest, bool> //probably want better response object here...
  {
    private readonly IStuffService stuffService;

    public DeleteStuffEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public override async Task HandleAsync(ByGuidRequest request, CancellationToken ct)
    {
      var result = stuffService.RemoveStuff(request.Id);
      await SendOkAsync(result, ct);
    }
  }
}
