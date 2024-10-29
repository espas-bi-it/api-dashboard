# **Code-Documentation**

### Create Razor Pages

1. **Adjust Project Structure**: Create a new folder named Pages in the root directory of your project.
2. **Add Razor Pages:** Add a new Razor Page by creating a .cshtml file in the Pages folder, e.g., `index.cshtml` and `dashboard.cshtml`.
3. **Configuration** in `Program.cs`: Ensure that Razor Pages are configured in your project. The code should look like this:
```c#
using DashboardProject;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add Razor Pages and MVC services
builder.Services.AddRazorPages();
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.ConfigureApi(); 

// Map Razor Pages and MVC Controllers
app.MapRazorPages();
app.MapControllers();

app.Run();
```

4. **Create Razor Page**: Create a new Razor Page in the `Pages` folder. For example:
`Index.cshtml`:
     ```html
     @page
     @model IndexModel
     @{
         ViewData["Title"] = "Home page";
     }

     <h1>Welcome</h1>
     <p>This is a Razor Page in the Pages folder.</p>
     ```

     `Index.cshtml.cs`:
     ```csharp
     using Microsoft.AspNetCore.Mvc.RazorPages;

     public class IndexModel : PageModel
     {
         public void OnGet()
         {
         }
     }
     ```

### Layout

1. **Create** the `wwwroot` Folder in the root directory of your project.
2. **Add Static Files**: Inside the `wwwroot` folder, you can create subfolders for organizing your static files, such as css, js, images, etc.

Example:

```plaintext
wwwroot            
├── css/     
│   ├── site.css   
├── js/          
│   ├── site.js
├── images/ 
│   ├── logo.png            

```

3. **Add Shared Razor Pages** 

in progress

### Call simple API

in progress

### Create DB

in progress

### Data Access with Dapper

in progress