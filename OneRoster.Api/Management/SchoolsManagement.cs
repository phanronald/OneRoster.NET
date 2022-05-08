using OneRoster.Api.Model;
using OneRoster.Models;
using OneRoster.Models.Shared;

namespace OneRoster.Api.Management
{
	public class SchoolsManagement
    {
        private readonly IOneRosterService _oneRosterApi;
        private readonly string _baseEndpoint = "/schools";

        public SchoolsManagement(IOneRosterService oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Orgs?> GetAllSchoolsAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Orgs>(_baseEndpoint);
        }

        public async Task<string> GetAllSchoolsRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(_baseEndpoint);
        }

        public async Task<Org?> GetSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Org>(finalEndpoint);
        }

        public async Task<string> GetSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<Classes?> GetClassesForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Classes>(finalEndpoint);
        }
        public async Task<string> GetClassesForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }


        public async Task<Enrollments?> GetEnrollmentsForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(finalEndpoint);
        }

        public async Task<string> GetEnrollmentsForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<Users?> GetStudentsForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Users>(finalEndpoint);
        }

        public async Task<string> GetStudentsForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }


        public async Task<Users?> GetTeachersForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Users>(finalEndpoint);
        }
        public async Task<string> GetTeachersForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<Courses?> GetCoursesForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Courses>(finalEndpoint);
        }
        public async Task<string> GetCoursesForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<Enrollments?> GetEnrollmentsForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(finalEndpoint);
        }
        public async Task<string> GetEnrollmentsForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<List<User>?> GetStudentsForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(finalEndpoint);
        }
        public async Task<string> GetStudentsForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<List<User>?> GetTeachersForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(finalEndpoint);
        }
        public async Task<string> GetTeachersForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<AcademicSessions?> GetTermsForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(finalEndpoint);
        }
        public async Task<string> GetTermsForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }
    }
}