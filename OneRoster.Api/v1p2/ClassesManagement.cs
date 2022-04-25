using OneRoster.Api.SharedDtos;
using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of Classes i.e. scheduled learning of courses.
	/// </summary>
	public class ClassesManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public ClassesManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of classes i.e. all classes for the current school year. 
        /// Properties that are not supported: resources, grades. Status is always active, classCode is section teacher display name.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Classes> GetAllClasses(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.Execute<Classes>(_request);
        }
        public async Task<RestResponse> GetAllClassesRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetAllClassesAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }

        /// <summary>
        /// To read, get, one class by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Class> GetClass(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.Execute<Class>(_request);
        }
        public async Task<RestResponse> GetClassRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Class> GetClassAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Class>(_request);
        }

        /// <summary>
        /// To read, get, a collection of students i.e. all students for the current school year for a class.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Users> GetStudentsForClass(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }
        public async Task<RestResponse> GetStudentsForClassRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetStudentsForClassAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, a collection of teachers i.e. all teachers for the current school year for a class.
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Users> GetTeachersForClass(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }
        public async Task<RestResponse> GetTeachersForClassRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetTeachersForClassAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/classes/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }


    }
}