using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.v1p1
{
	public class StudentsManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly string _baseEndpoint = "/students";

        public StudentsManagement(V1p1Api oneRosterApi)
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