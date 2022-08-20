using Microsoft.AspNetCore.Mvc;


[ApiController]
[Route("api/[controller]")]
public class HelloWorldController: ControllerBase {
    IHelloWorldService helloWorldService;
    public HelloWorldController(IHelloWorldService helloWorldService) {
        this.helloWorldService = helloWorldService;
    }

    public IActionResult Get() {
        return Ok(helloWorldService.GetHelloWorld());
    } 
}