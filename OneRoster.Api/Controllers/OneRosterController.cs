using Microsoft.AspNetCore.Mvc;
using OneRoster.Api.Model;
using OneRoster.Api.Shared;

namespace OneRoster.Api.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class OneRosterController : ControllerBase
	{
		public OneRosterController()
		{
		}

		[HttpGet]
		[Route("get-classes")]
		public async Task<IActionResult> GetV1p1Classes([FromQuery] vmOneRosterInput input)
		{
			var oneRosterApiData = new OneRosterService(OneRosterVersionType.V1P1,
				input.BaseUrl, input.ClientId, input.ClientSecret);

			var model = await oneRosterApiData.ClassesManagement.GetAllClassesAsync(
				new ApiParameters() { Limit = 2 }
			);
			if (model != null)
			{
				return new ObjectResult(model.classes);
			}

			return new ObjectResult(null);
		}
	}
}
