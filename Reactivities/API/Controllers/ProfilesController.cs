using System.Threading.Tasks;
using Application.Profiles;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class ProfilesController : BaseAPIController
    {
        [HttpGet("{usernamePrm}")]
        public async Task<IActionResult> GetProfile(string usernamePrm)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Username = usernamePrm }));
        }
    }
}