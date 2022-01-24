using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RestSharp;
using RestSharp.Authenticators;

namespace pubgstats.Pages;

public class IndexModel : PageModel
{
    private readonly ILogger<IndexModel> _logger;

    public IndexModel(ILogger<IndexModel> logger)
    {
        _logger = logger;
    }

    public void OnGet()
    {
        var client = new RestClient("https://api.pubg.com/shards/");
        client.Authenticator = new JwtAuthenticator("eyJ0eXAiOiJKV1QiLCJhbGciOiJIUzI1NiJ9.eyJqdGkiOiJiMWU2ODk0MC00OTU0LTAxMzktOWI4My0wMTVjZDc2MmZiYTciLCJpc3MiOiJnYW1lbG9ja2VyIiwiaWF0IjoxNjEyNDcwMTc4LCJwdWIiOiJibHVlaG9sZSIsInRpdGxlIjoicHViZyIsImFwcCI6InB1Ymctc3RhdHMtZmluIn0.gCOOQtprWoYa__2RIU3mHMIf4qplt9jojZjQJjdtgjM");

        var request = new RestRequest("pc-eu/matches/fc536da9-1fdd-4125-a037-6bf5db2af6fb");
        
    }
}
