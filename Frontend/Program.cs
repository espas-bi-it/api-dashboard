using DataAccess.Services;
using Frontend.Components;
using Frontend.Data;
using Syncfusion.Blazor;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddSignalR(o => { o.MaximumReceiveMessageSize = 102400000; });
builder.Services.AddSyncfusionBlazor();
builder.Services.AddSingleton<PdfService>();
builder.Services.AddMemoryCache();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add connection string
var connectionString = builder.Configuration.GetConnectionString("Default");

// Register UserService and CollaboratorService with connection string
builder.Services.AddTransient<UserService>(provider => new UserService(connectionString));
builder.Services.AddTransient<CollaboratorService>(provider => new CollaboratorService(connectionString));

var app = builder.Build();

// Register Syncfusion license
// Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
