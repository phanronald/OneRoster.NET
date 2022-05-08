using OneRoster.Models;
using OneRoster.Models.Shared;
using OneRoster.Services.Interfaces;

namespace OneRoster.Services.Management
{
	public class DemographicsManagement
    {
        private readonly IOneRosterService _oneRosterApi;
        private readonly string _baseEndpoint = "/demographics";

        public DemographicsManagement(IOneRosterService oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Demographics?> GetAllDemographicsAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Demographics>(_baseEndpoint);
        }

        public async Task<string> GetAllDemographicsRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(_baseEndpoint);
        }

        public async Task<Demographic?> GetDemographicsAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Demographic>(finalEndpoint);
        }
        public async Task<string> GetDemographicsRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }
    }
}