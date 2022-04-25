using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.v1p1
{
	public class UsersManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly string _baseEndpoint = "/users";

        public UsersManagement(V1p1Api oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Users?> GetAllUsersAsync(ApiParameters? p = null)
        {
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_baseEndpoint, p);
        }
        public async Task<HttpResponseMessage> GetAllUsersRaw(ApiParameters? p = null)
        {
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_baseEndpoint, p);
        }

        public async Task<User?> GetUserAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<User>(finalEndpoint, p);
        }
        public async Task<HttpResponseMessage> GetUserRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(finalEndpoint, p);
        }

        public async Task<Classes?> GetClassesForUserAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(finalEndpoint, p);
        }
        public async Task<HttpResponseMessage> GetClassesForUserRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(finalEndpoint, p);
        }
    }
}