using Radzen;
using Frontend.Components;
using DataAccess.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Dapper;
using MySql.Data.MySqlClient;
using System.Data;
using Google.Protobuf.WellKnownTypes;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
      .AddInteractiveServerComponents().AddHubOptions(options => options.MaximumReceiveMessageSize = 10 * 1024 * 1024);

builder.Services.AddControllers();
builder.Services.AddRadzenComponents();

builder.Services.AddRadzenCookieThemeService(options =>
{
    options.Name = "FrontendTheme";
    options.Duration = TimeSpan.FromDays(365);
});
builder.Services.AddHttpClient();

// Füge den UserService hinzu
builder.Services.AddSingleton<UserService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.MapControllers();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
   .AddInteractiveServerRenderMode();

app.Run();

// UserService Definition
public class UserService
{
    private readonly IConfiguration _configuration;

    public UserService(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    private IDbConnection CreateConnection()
    {
        return new MySqlConnection(_configuration.GetConnectionString("DefaultConnection"));
    }

    public async Task<IEnumerable<User>> GetUsersAsync()
    {
        using (var connection = CreateConnection())
        {
            string sql = "SELECT * FROM user";
            return await connection.QueryAsync<User>(sql);
        }
    }
}

// User Modell Definition
namespace DataAccess.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TeamRole { get; set; }
        public string Website { get; set; }
        public int SiteViews { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
