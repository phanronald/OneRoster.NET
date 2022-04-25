using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.v1p1
{
	public class ClassesManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly string _baseEndpoint = "/classes";

        public ClassesManagement(V1p1Api oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Classes?> GetAllClassesAsync(ApiParameters? p = null)
        {
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_baseEndpoint, p);
        }

        public async Task<HttpResponseMessage> GetAllClassesRaw(ApiParameters? p = null)
        {
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_baseEndpoint, p);
        }

        public async Task<Class?> GetClassAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Class>(finalEndpoint, p);
        }

        public async Task<HttpResponseMessage> GetClassRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(finalEndpoint, p);
        }

        public async Task<Users?> GetStudentsForClassAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/students";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(finalEndpoint, p);
        }
        public async Task<HttpResponseMessage> GetStudentsForClassRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/students";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(finalEndpoint, p);
        }

        public async Task<Users?> GetTeachersForClassAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/teachers";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(finalEndpoint, p);
        }
        public async Task<HttpResponseMessage> GetTeachersForClassRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/teachers";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(finalEndpoint, p);
        }
    }
}