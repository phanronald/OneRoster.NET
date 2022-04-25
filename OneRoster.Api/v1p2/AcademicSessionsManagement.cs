using OneRoster.Api.SharedDtos;
using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of academic sessions i.e. periods of academic activity.
	/// </summary>
	public class AcademicSessionsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public AcademicSessionsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of academic sessions i.e. all academic sessions for the current school year. Refers to campus terms.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<AcademicSessions> GetAllAcademicSessions(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/academicSessions/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }
        public async Task<RestResponse> GetAllAcademicSessionsRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/academicSessions/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<AcademicSessions> GetAllAcademicSessionsAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/academicSessions/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }

        /// <summary>
        /// To read, get, one academicSession by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<AcademicSession> GetAcademicSession(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/academicSessions/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSession>(_request);
        }
        public async Task<RestResponse> GetAcademicSessionRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/academicSessions/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<AcademicSession> GetAcademicSessionAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/academicSessions/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSession>(_request);
        }



    }
}