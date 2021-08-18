using System;
using System.Threading.Tasks;
using Application.Activities;
using Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace API.Controllers
{
    //Base (Polymorphism)

    public class ActivitiesController : BaseAPIController
    {

        [HttpGet]
        public async Task<IActionResult> GetActivities() ////CancellationToken ct
        {
            return HandleResult(await Mediator.Send(new List.Query()));
        }


        //No Protection
        [HttpGet("{idPrm}")]
        public async Task<IActionResult> GetActivity(Guid idPrm)
        {
            return HandleResult(await Mediator.Send(new Details.Query { Id = idPrm }));
        }

        [HttpPost]
        public async Task<IActionResult> CreateActivity(Activity activityPrm)
        {
            return HandleResult(await Mediator.Send(new Create.Command { Activity = activityPrm }));
        }

        [Authorize(Policy ="IsActivityHost")]
        [HttpPut("{idPrm}")]
        public async Task<IActionResult> EditActivity(Guid idPrm, Activity activity)
        {
            activity.Id = idPrm;
            return HandleResult(await Mediator.Send(new Edit.Command { Activity = activity }));
        }

        [Authorize(Policy ="IsActivityHost")]
        [HttpDelete("{idPrm}")]
        public async Task<IActionResult> DeleteActivity(Guid idPrm)
        {
            return HandleResult(await Mediator.Send(new Delete.Command { Id = idPrm }));
        }

        [HttpPost("{idPrm}/attend")]
        public async Task<IActionResult> Attend(Guid idPrm)
        {
            return HandleResult(await Mediator.Send(new UpdateAttendance.Command { Id = idPrm }));
        }
    }
}
