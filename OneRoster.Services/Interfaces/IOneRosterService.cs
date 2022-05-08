using OneRoster.Models.Shared;
using OneRoster.Services.Management;

namespace OneRoster.Services.Interfaces
{
	public interface IOneRosterService
	{
		Task<T?> ExecuteAsync<T>(string endpoint) where T : new();
		Task<string> GetRawResponse(string endpoint);
		void AddRequestParameters(ApiParameters? p);

		AcademicSessionsManagement AcademicSessionsManagement { get; }
		ClassesManagement ClassesManagement { get; }
		CoursesManagement CoursesManagement { get; }
		DemographicsManagement DemographicsManagement { get; }
		EnrollmentsManagement EnrollmentsManagement { get; }
		GradingPeriodsManagement GradingPeriodsManagement { get; }
		OrgsManagement OrgsManagement { get; }
		SchoolsManagement SchoolsManagement { get; }
		StudentsManagement StudentsManagement { get; }
		TeachersManagement TeachersManagement { get; }
		TermsManagement TermsManagement { get; }
		UsersManagement UsersManagement { get; }
	}
}