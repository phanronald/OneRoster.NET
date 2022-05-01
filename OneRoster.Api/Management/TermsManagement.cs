using OneRoster.Api.Model;
using OneRoster.Api.Shared;
using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.Management
{
	public class TermsManagement
    {
        private readonly IOneRosterService _oneRosterApi;
        private readonly string _baseEndpoint = "/terms";

        public TermsManagement(IOneRosterService oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<AcademicSessions?> GetAllTermsAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_baseEndpoint);
        }
        public async Task<HttpResponseMessage> GetAllTermsRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(_baseEndpoint);
        }

        public async Task<AcademicSession?> GetTermAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<AcademicSession>(finalEndpoint);
        }

        public async Task<HttpResponseMessage> GetTermRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<Classes?> GetClassesForTermAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Classes>(finalEndpoint);
        }

        public async Task<HttpResponseMessage> GetClassesForRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }
        
        public async Task<AcademicSessions?> GetGradingPeriodsForTermAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/gradingPeriods";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetGradingPeriodsForTermRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/gradingPeriods";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

    }
}