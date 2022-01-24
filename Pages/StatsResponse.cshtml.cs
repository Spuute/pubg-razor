using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pubgstats.PubgClient;
using System;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Http;
using System.Linq;
using System.Collections.Generic;
namespace pubgstats.Pages
{
    public class StatsResponseModel : PageModel
    {
        private readonly IPubgClient _pubgClient;
        public StatsResponseModel(IPubgClient pubgClient) {
            _pubgClient = pubgClient;
        }
     
        public async Task<IActionResult> OnGetAsync()
        {
            var hej =  await _pubgClient.GetSeasonStats();

            return Page();
        }
    }
}
