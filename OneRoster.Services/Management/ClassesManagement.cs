using OneRoster.Models;
using OneRoster.Models.Shared;
using OneRoster.Services.Interfaces;

namespace OneRoster.Services.Management
{
	public class ClassesManagement
    {
        private readonly IOneRosterService _oneRosterApi;
        private readonly string _baseEndpoint = "/classes";

        public ClassesManagement(IOneRosterService oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Classes?> GetAllClassesAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_baseEndpoint);
        }

        public async Task<string> GetAllClassesRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(_baseEndpoint);
        }

        public async Task<Class?> GetClassAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Class>(finalEndpoint);
        }

        public async Task<string> GetClassRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<Users?> GetStudentsForClassAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Users>(finalEndpoint);
        }
        public async Task<string> GetStudentsForClassRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }

        public async Task<Users?> GetTeachersForClassAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Users>(finalEndpoint);
        }
        public async Task<string> GetTeachersForClassRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }
    }
}