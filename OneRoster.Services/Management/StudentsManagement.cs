using OneRoster.Models;
using OneRoster.Models.Shared;
using OneRoster.Services.Interfaces;

namespace OneRoster.Services.Management
{
	public class StudentsManagement
    {
        private readonly IOneRosterService _oneRosterApi;
        private readonly string _baseEndpoint = "/students";

        public StudentsManagement(IOneRosterService oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Users?> GetAllStudentsAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Users>(_baseEndpoint);
        }
        public async Task<string> GetAllStudentsRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(_baseEndpoint);
        }

        public async Task<User?> GetStudentAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<User>(finalEndpoint);
        }
        public async Task<string> GetStudentRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<Classes?> GetClassesForStudentAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Classes>(finalEndpoint);
        }
        public async Task<string> GetClassesForStudentRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }
    }
}