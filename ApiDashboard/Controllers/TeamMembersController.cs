using DataAccess.Data;
using DataAccess.Models;

namespace ApiDashboard;

public static class TeamMemberController
{
    public static void ConfigureApi(this WebApplication app)
    {
        // All of my API endpoint mapping
        app.MapGet(pattern: "/TeamMembers", GetUsers);
        app.MapGet(pattern: "/TeamMembers/{id}", GetUser);
        app.MapPost(pattern: "/TeamMembers", InsertUser);
        app.MapPut(pattern: "/TeamMembers", UpdateUser);
        app.MapDelete(pattern: "/TeamMembers", DeleteUser);
    }

    private static async Task<IResult> GetUsers(IUserData data)
    {
        try
        {
            return Results.Ok(await data.GetUsers());
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }

    }

    private static async Task<IResult> GetUser(int id, IUserData data)
    {
        try
        {
            var results = await data.GetUser(id);
            if (results == null) return Results.NotFound();
            return Results.Ok(results);
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

    private static async Task<IResult> InsertUser(TeamMembers user, IUserData data)
    {
        try
        {
            await data.InsertUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }


    private static async Task<IResult> UpdateUser(TeamMembers user, IUserData data)
    {

        try
        {
            await data.UpdateUser(user);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }

    }

    private static async Task<IResult> DeleteUser(int id, IUserData data)
    {
        try
        {
            await data.DeleteUser(id);
            return Results.Ok();
        }
        catch (Exception ex)
        {
            return Results.Problem(ex.Message);
        }
    }

}
