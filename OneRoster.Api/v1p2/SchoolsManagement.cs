using OneRoster.Api.SharedDtos;
using RestSharp;

namespace OneRoster.Api.v1p2
{
	/// <summary>
	/// This enables the management of information about schools. A school is a type of 'org'.
	/// </summary>
	public class SchoolsManagement
    {
        private readonly V1p2Api _oneRosterApi;
        private readonly RestRequest _request;

        public SchoolsManagement(V1p2Api oneRosterApi)
        {
            _request = new RestRequest();
            _oneRosterApi = oneRosterApi;
        }

        /// <summary>
        /// To read, get, a collection of schools. Refers to campus schools by school GUID. status is always active.
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Orgs> GetAllSchools(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Orgs>(_request);
        }
        public async Task<RestResponse> GetAllSchoolsRaw(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Orgs> GetAllSchoolsAsync(ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Orgs>(_request);
        }

        /// <summary>
        /// To read, get, one school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<SingleOrg> GetSchool(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleOrg>(_request);
        }
        public async Task<RestResponse> GetSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<SingleOrg> GetSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<SingleOrg>(_request);
        }

        /// <summary>
        /// To read, get, classes for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Classes> GetClassesForSchool(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }
        public async Task<RestResponse> GetClassesForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Classes> GetClassesForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Classes>(_request);
        }

        /// <summary>
        /// To read, get, enrollments for a class in a school by sourcedId
        /// </summary>
        /// <param name="schoolSourcedId"></param>
        /// <param name="classSourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Enrollments> GetEnrollmentsForClassInSchool(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(_request);
        }
        public async Task<RestResponse> GetEnrollmentsForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Enrollments> GetEnrollmentsForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(_request);
        }

        /// <summary>
        /// To read, get, students for a class in a school
        /// </summary>
        /// <param name="schoolSourcedId"></param>
        /// <param name="classSourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Users> GetStudentsForClassInSchool(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }
        public async Task<RestResponse> GetStudentsForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetStudentsForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, teachers for a class in a school
        /// </summary>
        /// <param name="schoolSourcedId"></param>
        /// <param name="classSourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Users> GetTeachersForClassInSchool(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }
        public async Task<RestResponse> GetTeachersForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Users> GetTeachersForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Users>(_request);
        }

        /// <summary>
        /// To read, get, courses for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Courses> GetCoursesForSchool(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Courses>(_request);
        }
        public async Task<RestResponse> GetCoursesForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Courses> GetCoursesForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Courses>(_request);
        }

        /// <summary>
        /// To read, get, enrollments for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<Enrollments> GetEnrollmentsForSchool(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(_request);
        }
        public async Task<RestResponse> GetEnrollmentsForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<Enrollments> GetEnrollmentsForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(_request);
        }

        /// <summary>
        /// To read, get, students for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        //Todo: This is returning a list of user instead of the Users class, could be a bug in Campus implementation or error in spec
        public async Task<List<User>> GetStudentsForSchool(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(_request);
        }
        public async Task<RestResponse> GetStudentsForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<List<User>> GetStudentsForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(_request);
        }


        /// <summary>
        /// To read, get, teachers for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        //Todo: This is returning a list of user instead of the Users class, could be a bug in Campus implementation or error in 1.2 spec
        public async Task<List<User>> GetTeachersForSchool(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(_request);
        }
        public async Task<RestResponse> GetTeachersForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<List<User>> GetTeachersForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(_request);
        }


        /// <summary>
        /// To read, get, terms for a school by sourcedId
        /// </summary>
        /// <param name="sourcedId"></param>
        /// <param name="p"></param>
        /// <returns></returns>
        public async Task<AcademicSessions> GetTermsForSchool(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }
        public async Task<RestResponse> GetTermsForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_request);
        }
        public async Task<AcademicSessions> GetTermsForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            _request.Method = Method.Get;
            _request.Resource = $"/schools/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_request);
        }

    }
}