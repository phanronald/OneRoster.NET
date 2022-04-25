using OneRoster.Api.SharedDtos;
using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of information about students (a student is a type of 'user').
	/// </summary>
	public class StudentsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public StudentsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of students i.e. all students enrolled for the current school year. 
        /// Properties that are not supported: userProfiles, userIds, identifier, username is not valid for login. 
        /// Filtering by grades is not supported.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Users> GetAllStudents(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/students/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }
        public async Task<RestResponse> GetAllStudentsRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/students/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetAllStudentsAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/students/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, one student by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<User> GetStudent(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/students/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<User>(_request);
        }
        public async Task<RestResponse> GetStudentRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/students/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<User> GetStudentAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/students/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<User>(_request);
        }

        /// <summary>
        /// To read, get, a collection of classes i.e. all classes for the current school year for a student. 
        /// Properties that are not supported: resources, grades. Status is always active, classCode is section teacher display name.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Classes> GetClassesForStudent(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/students/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }
        public async Task<RestResponse> GetClassesForStudentRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/students/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetClassesForStudentAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/students/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }


    }
}