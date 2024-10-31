using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using ApiDashboard.Models;

namespace ApiDashboard.Pages
{
    public class IndexModel : PageModel
    {
        public MeowFact MeowFact { get; set; }

        public async Task OnGet()
        {
            using (var client = new HttpClient())
            {
                MeowFact = await client.GetFromJsonAsync<MeowFact>("https://meowfacts.herokuapp.com/?lang=ger");
            }
        }
    }
}
