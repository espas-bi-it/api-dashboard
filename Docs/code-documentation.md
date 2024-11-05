# **Code-Documentation**

## 1. Installation

### Nuget Packages
This project requires the following NuGet packages:
```sh
dotnet add package Dapper --version 2.1.35
dotnet add package Microsoft.AspNetCore.OpenApi --version 8.0.10
dotnet add package Newtonsoft.Json --version 13.0.3
dotnet add package Swashbuckle.AspNetCore --version 6.9.0
dotnet add package System.Data.SqlClient --version 4.8.6
```

## 2. Map Razor Pages and MVC Controllers

### Adjust Project Structure

Create a new folder named Pages in the root directory of your project.
```c#
// Map Razor Pages and MVC Controllers
app.MapRazorPages();
app.MapControllers();
```

### Configurate Views with Razor Pages

1. **Add Razor Pages:** Add a new Razor Page by creating a .cshtml file in the Pages folder, e.g., `index.cshtml`
2. **Create a new Folder named** `Shared` inside the `Pages` directory
3. **Add your shared views** e.g., _Layout.cshtml, _PartialView.cshtml to this Shared folder.
4. In `Program.cs`: Ensure that Razor Pages are configured in your project.

The code in `_Layout_` is from an example bootstrap dashboard:
https://getbootstrap.com/docs/5.1/examples/dashboard/#

## 3. Using the wwwroot folder in ASP.NET Core

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

# Database

[![](https://www.youtube.com/watch?v=dwMFg6uxQ0I/{dwMFg6uxQ0I})](https://youtu.be/{dwMFg6uxQ0I})


## Publish Database

**Instruction** Right Click on the `UserDB` Folder

- **Target database connection**: your localdb  -> Copy the string, you'll need that later!
- **Datbase name**: ApiDashboardDB
- **Publish Script name**: UserDB.Sql

![alt text](image-1.png)


## Connection String

In `appsettings.json` : Replace the Connection String

Example:

```c#
 "ConnectionStrings": {
   "Default": "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ApiDashboard;Integrated Security=True;Connect Timeout=60;"
 }
```

### Data Access with Dapper

still in progress