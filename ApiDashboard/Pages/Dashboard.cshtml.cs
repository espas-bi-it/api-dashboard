using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using System.Collections.Generic;
using DataAccess.Models;

namespace ApiDashboard.Pages
{
    public class DashboardModel : PageModel
    {
        public List<UserModel> Users { get; set; }

        public async Task OnGet()
        {
            using (var client = new HttpClient())
            {
                Users = await client.GetFromJsonAsync<List<UserModel>>("https://localhost:7279/Users");
            }
        }
    }
}
