using FastEndpointsSample.Dtos;
using FastEndpointsSample.Services;
using Microsoft.AspNetCore.Authorization;

namespace FastEndpointsSample.Endpoints
{
  //[HttpPost("stuff"), AllowAnonymous]
  //probably want cleaner request/response objects here...
  public class AddStuffEndpoint : Endpoint<Stuff, bool> 
  {
    //  private IStuffService stuffService;

    //  public AddStuffEndpoint(IStuffService stuffService)
    //  {
    //    this.stuffService = stuffService;
    //  }

    public override void Configure()
    {
      Post("/stuff");
      AllowAnonymous();
    }

    public override async Task HandleAsync(Stuff newStuff, CancellationToken ct)
    {
      //var result = stuffService.AddStuff(newStuff);
      
      //await SendAsync(result);
      await SendAsync(false);
    }

  }
}
