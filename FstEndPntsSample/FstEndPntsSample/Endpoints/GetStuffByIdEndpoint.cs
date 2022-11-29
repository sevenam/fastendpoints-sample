using FstEndPntsSample.Dtos;
using FstEndPntsSample.Requests;
using FstEndPntsSample.Services;
using Microsoft.AspNetCore.Authorization;

namespace FstEndPntsSample.Endpoints
{
  [HttpGet("api/stuff/{id}"), AllowAnonymous]
  public class GetStuffByIdEndpoint : Endpoint<ByGuidRequest, Stuff>
  {
    private readonly IStuffService stuffService;

    public GetStuffByIdEndpoint(IStuffService stuffService)
    {
      this.stuffService = stuffService;
    }

    public override async Task HandleAsync(ByGuidRequest request, CancellationToken ct)
    {
      var result = stuffService.GetStuffById(request.Id);
      await SendOkAsync(result, ct);
    }

  }
}
