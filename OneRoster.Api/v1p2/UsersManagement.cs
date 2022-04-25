using OneRoster.Api.SharedDtos;
using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of information about users (including students and teachers).
	/// </summary>
	public class UsersManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public UsersManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of users i.e. all user for the current school year. 
        /// Properties that are not supported: userProfiles, userIds, identifier, username is not valid for login. 
        /// Filtering by grades of students is not supported.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Users> GetAllUsers(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/users/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }
        public async Task<RestResponse> GetAllUsersRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/users/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetAllUsersAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/users/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, one user by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<User> GetUser(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/users/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<User>(_request);
        }
        public async Task<RestResponse> GetUserRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/users/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<User> GetUserAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/users/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<User>(_request);
        }

        /// <summary>
        /// To read, get, a collection of classes i.e. all classes for the current school year for a student or teacher. 
        /// Properties that are not supported: resources, grades. Status is always active, classCode is section teacher display name.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Classes> GetClassesForUser(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/users/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.Execute<Classes>(_request);
        }
        public async Task<RestResponse> GetClassesForUserRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/users/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetClassesForUserAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/users/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }


    }
}