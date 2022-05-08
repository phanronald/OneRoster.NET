using OneRoster.Models;
using OneRoster.Models.Shared;
using OneRoster.Services.Interfaces;

namespace OneRoster.Services.Management
{
	public class EnrollmentsManagement
    {
        private readonly IOneRosterService _oneRosterApi;
        private readonly string _baseEndpoint = "/enrollments";

        public EnrollmentsManagement(IOneRosterService oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Enrollments?> GetAllEnrollmentsAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(_baseEndpoint);
        }
        public async Task<string> GetAllEnrollmentsRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(_baseEndpoint);
        }

        public async Task<Enrollment?> GetEnrollmentAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Enrollment>(finalEndpoint);
        }
        public async Task<string> GetEnrollmentRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetRawResponse(finalEndpoint);
        }
    }
}