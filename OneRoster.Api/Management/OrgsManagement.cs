using OneRoster.Api.Model;
using OneRoster.Models;
using OneRoster.Models.Shared;

namespace OneRoster.Api.Management
{
	public class OrgsManagement
    {
        private readonly IOneRosterService _oneRosterApi;
        private readonly string _baseEndpoint = "/orgs";

        public OrgsManagement(IOneRosterService oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Orgs?> GetAllOrgsAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Orgs>(_baseEndpoint);
        }

        public async Task<string> GetAllOrgsRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(_baseEndpoint);
        }

        public async Task<Org?> GetOrgAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Org>(finalEndpoint);
        }

        public async Task<string> GetOrgRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }
    }
}