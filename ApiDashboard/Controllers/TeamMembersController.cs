using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using DataAccess.Models;
using Services;

public class TeamMembersController : Controller
{
    private readonly UserService _userService;

    public TeamMembersController(UserService userService)
    {
        _userService = userService;
    }

    public async Task<IActionResult> Index()
    {
        var teamMembers = await _userService.GetUsersAsync();
        return View(teamMembers);
    }
}
