using System.Threading.Tasks;
using Application.Photos;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    public class PhotosController : BaseAPIController
    {
        [HttpPost]
        public async Task<IActionResult> Add([FromForm] Add.Command command)
        {
            return HandleResult(await Mediator.Send(command));
        }
        
        [HttpDelete("{idPrm}")]
        public async Task<IActionResult> Delete(string idPrm)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = idPrm }));
        }

        [HttpPost("{idPrm}/setMain")]
        public async Task<IActionResult> SetMain(string idPrm)
        {
            return HandleResult(await Mediator.Send(new SetMain.Command { Id = idPrm }));
        }

    }
}