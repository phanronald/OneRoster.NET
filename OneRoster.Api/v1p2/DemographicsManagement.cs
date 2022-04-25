using OneRoster.Api.SharedDtos;
using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of demographics information (each assigned to a specific user).
	/// </summary>
	public class DemographicsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public DemographicsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of demographic data. Demographics information is taken from the Common Educational Data Standards (CEDS) 
        /// from the US government. sourcedId refers to person GUID. publicSchoolResidenceStatus is not supported.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Demographic> GetAllDemographics(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/demographics/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Demographic>(_request);
        }
        public async Task<RestResponse> GetAllDemographicsRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/demographics/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Demographic> GetAllDemographicsAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/demographics/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Demographic>(_request);
        }

        /// <summary>
        /// To read, get, one demographic by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Demographic> GetDemographics(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/demographics/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Demographic>(_request);
        }
        public async Task<RestResponse> GetDemographicsRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/demographics/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Demographic> GetDemographicsAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/demographics/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Demographic>(_request);
        }


    }
}