using OneRoster.Api.SharedDtos;
using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of Courses i.e. programme of study.
	/// </summary>
	public class CoursesManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public CoursesManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of courses i.e. all courses for the current school year. Refers to campus courses. 
        /// Properties that are not supported: schoolYear, grades, resources. status is always active
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Courses> GetAllCourses(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/courses/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Courses>(_request);
        }
        public async Task<RestResponse> GetAllCoursesRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/courses/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Courses> GetAllCoursesAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/courses/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Courses>(_request);
        }

        /// <summary>
        /// To read, get, one course by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Course> GetCourse(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/courses/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Course>(_request);
        }
        public async Task<RestResponse> GetCourseRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/courses/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Course> GetCourseAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/courses/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Course>(_request);
        }

        /// <summary>
        /// To read, get, classes for a course by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Classes> GetClassesForCourse(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/courses/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }
        public async Task<RestResponse> GetClassesForCourseRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/courses/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetClassesForCourseAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/courses/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }


    }
}