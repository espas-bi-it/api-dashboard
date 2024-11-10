﻿using Frontend.Data;
using Frontend;
using Frontend.Components;
using Syncfusion.Blazor;
using DataAccess.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents();
builder.Services.AddSignalR(o => { o.MaximumReceiveMessageSize = 102400000; });
builder.Services.AddSyncfusionBlazor();
            builder.Services.AddSingleton<PdfService>();
builder.Services.AddMemoryCache();
builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

// Add Dapper service
builder.Services.AddTransient<UserService>();  // Registriere den UserService


// Füge die Verbindungszeichenfolge hinzu
var connectionString = builder.Configuration.GetConnectionString("Default");
builder.Services.AddSingleton(new CollaboratorService(connectionString));

var app = builder.Build();
//Register Syncfusion license https://help.syncfusion.com/common/essential-studio/licensing/how-to-generate
//Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("YOUR LICENSE KEY");

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
