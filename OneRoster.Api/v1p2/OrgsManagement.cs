using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of Orgs i.e. an organization involved in the learning in some form or other.
	/// </summary>
	public class OrgsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public OrgsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of orgs, district and schools. Refers to campus districts and schools. status is always active.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Orgs> GetAllOrgs(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/orgs/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Orgs>(_request);
        }
        public async Task<RestResponse> GetAllOrgsRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/orgs/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Orgs> GetAllOrgsAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/orgs/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Orgs>(_request);
        }

        /// <summary>
        /// To read, get, one organization, district or school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<SingleOrg> GetOrg(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/orgs/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleOrg>(_request);
        }
        public async Task<RestResponse> GetOrgRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/orgs/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<SingleOrg> GetOrgAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/orgs/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleOrg>(_request);
        }


    }
}