using OneRoster.Api.SharedDtos;
using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of information about teachers (a teacher is a type of 'user').
	/// </summary>
	public class TeachersManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public TeachersManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of teachers i.e. all teachers registered to teach for the current school year. 
        /// Properties that are not supported: userProfiles, userIds, identifier, grades, username is not valid for login.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Users> GetAllTeachers(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/teachers/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }
        public async Task<RestResponse> GetAllTeachersRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/teachers/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetAllTeachersAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/teachers/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, one teacher by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<User> GetTeacher(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/teachers/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<User>(_request);
        }
        public async Task<RestResponse> GetTeacherRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/teachers/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<User> GetTeacherAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/teachers/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<User>(_request);
        }

        /// <summary>
        /// To read, get, a collection of classes i.e. all classes for the current school year for a teacher. 
        /// Properties that are not supported: resources, grades. Status is always active, classCode is section teacher display name.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Classes> GetClassesForTeacher(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/teachers/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }
        public async Task<RestResponse> GetClassesForTeacherRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/teachers/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetClassesForTeacherAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/teachers/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }

    }
}