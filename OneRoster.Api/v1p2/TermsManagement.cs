using OneRoster.Api.SharedDtos;
using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of information about terms (a term is a type of 'academicSession').
	/// </summary>
	public class TermsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public TermsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of terms i.e. all terms for the current school year. Refers to campus terms by term ID. status is always active.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<AcademicSessions> GetAllTerms(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }
        public async Task<RestResponse> GetAllTermsRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<AcademicSessions> GetAllTermsAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }

        /// <summary>
        /// To read, get, one term by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<AcademicSession> GetTerm(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSession>(_request);
        }
        public async Task<RestResponse> GetTermRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<AcademicSession> GetTermAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSession>(_request);
        }

        /// <summary>
        /// To read, get, classes for a term by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Classes> GetClassesForTerm(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }
        public async Task<RestResponse> GetClassesForRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetClassesForTermAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }

        /// <summary>
        /// To read, get, grading periods for a term by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<AcademicSessions> GetGradingPeriodsForTerm(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/{sourcedId}/gradingPeriods";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }
        public async Task<RestResponse> GetGradingPeriodsForTermRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/{sourcedId}/gradingPeriods";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<AcademicSessions> GetGradingPeriodsForTermAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/terms/{sourcedId}/gradingPeriods";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }

    }
}