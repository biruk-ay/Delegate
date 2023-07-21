using Microsoft.AspNetCore.Mvc;
using delegateBack.Controllers;
using delegateBack.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

[ApiController]
[Route("/api/TestController")]
public class TestController: ControllerBase {
    [HttpGet(Name ="TestController")]
    public String test() {
        Users user = new Users("Asf;sjd","lsfjlf","ldoi","lkfdj","orusd");
        String jsonstring = JsonSerializer.Serialize(user);
        return jsonstring;
    }
}