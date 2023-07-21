using Microsoft.AspNetCore.Mvc;
namespace delegateBack.Models;

public class DelegateForm {
    public String Id {set; get;}
    public String Status{set; get;}
    public String Acceptor{set; get;}
    public String Delegator{set; get;}
    public DateOnly StartDate{set; get;}
    public DateOnly EndDate{set; get;}
    public List<String> References{set; get;}
}