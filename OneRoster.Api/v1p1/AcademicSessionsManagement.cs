
using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.v1p1
{
	public class AcademicSessionsManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly string _baseEndpoint = "/academicSessions";

        public AcademicSessionsManagement(V1p1Api oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<AcademicSessions?> GetAllAcademicSessionsAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_baseEndpoint);
        }
        public async Task<HttpResponseMessage> GetAllAcademicSessionsRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(_baseEndpoint);
        }

        public async Task<AcademicSession?> GetAcademicSessionAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<AcademicSession>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetAcademicSessionRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }
    }
}