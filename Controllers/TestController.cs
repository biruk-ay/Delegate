using Microsoft.AspNetCore.Mvc;
using delegateBack.Controllers;
using delegateBack.Models;
using System.Text.Json;
using System.Text.Json.Serialization;

[ApiController]
[Route("/api/TestController")]
public class TestController: ControllerBase {
    private readonly UsersDbContext _context;
    public TestController (UsersDbContext context) {
        _context = context;
    }
    [HttpGet(Name ="TestController")]
    public List<Users> testAction() {
        var result = _context.User.ToList();
        return result;
    }
    // public String test() {
    //     Users user = new Users("Asf;sjd","lsfjlf","ldoi","lkfdj","orusd");
    //     // String jsonstring = JsonSerializer.Serialize(user);
    //     return JsonSerializer.Serialize(user);
    // }

    // [HttpGet(Name ="TestController")]
    // public String Deserialize1 () {
    //     String jsonstring = @"{
    //         ""Id"": ""trying"",
    //         ""Name"": ""trying"",
    //         ""Role"": ""trying"",
    //         ""Email"": ""trying"",
    //         ""Password"": ""trying""
    //     }";
    //     Users? testDeserialize = JsonSerializer.Deserialize<Users>(jsonstring);
    //     return testDeserialize.Email;
    // }
}