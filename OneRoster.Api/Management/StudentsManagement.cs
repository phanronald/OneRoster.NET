using OneRoster.Api.Model;
using OneRoster.Api.Shared;
using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.Management
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
        public async Task<HttpResponseMessage> GetAllStudentsRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(_baseEndpoint);
        }

        public async Task<User?> GetStudentAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<User>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetStudentRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<Classes?> GetClassesForStudentAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Classes>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetClassesForStudentRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }
    }
}