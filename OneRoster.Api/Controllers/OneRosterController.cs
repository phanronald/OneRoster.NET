using Microsoft.AspNetCore.Mvc;
using OneRoster.Api.Model;
using OneRoster.Api.v1p1;

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
			var oneRosterApiData = new V1p1Api(input.BaseUrl, input.ClientId, input.ClientSecret);
			//var model = await oneRosterApiData.ClassesManagement.GetAllClassesAsync();
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
