using Microsoft.AspNetCore.Mvc;
namespace delegateBack.Models;

public class Users {
    public Users (string id, string name, string role, string email, string password) {
        this.Id = id;
        this.Name = name;
        this.Role = role;
        this.Email = email;
        this.Password = password;
    }
    public String Id {get; set;}
    public String Name {get; set;}
    public String Role {get; set;}
    public String Email{get; set;}
    public String Password{get; set;}

}