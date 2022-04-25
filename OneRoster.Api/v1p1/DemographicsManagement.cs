using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.v1p1
{
	public class DemographicsManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly string _baseEndpoint = "/demographics";

        public DemographicsManagement(V1p1Api oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Demographics?> GetAllDemographicsAsync(ApiParameters? p = null)
        {
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Demographics>(_baseEndpoint, p);
        }

        public async Task<HttpResponseMessage> GetAllDemographicsRaw(ApiParameters? p = null)
        {
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_baseEndpoint, p);
        }

        public async Task<Demographic?> GetDemographicsAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Demographic>(finalEndpoint, p);
        }
        public async Task<HttpResponseMessage> GetDemographicsRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(finalEndpoint, p);
        }
    }
}