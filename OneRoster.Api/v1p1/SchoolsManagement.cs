﻿using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.v1p1
{
	public class SchoolsManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly string _baseEndpoint = "/schools";

        public SchoolsManagement(V1p1Api oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Orgs?> GetAllSchoolsAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Orgs>(_baseEndpoint);
        }

        public async Task<HttpResponseMessage> GetAllSchoolsRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(_baseEndpoint);
        }

        public async Task<Org?> GetSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Org>(finalEndpoint);
        }

        public async Task<HttpResponseMessage> GetSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<Classes?> GetClassesForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Classes>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetClassesForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }


        public async Task<Enrollments?> GetEnrollmentsForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(finalEndpoint);
        }

        public async Task<HttpResponseMessage> GetEnrollmentsForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<Users?> GetStudentsForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Users>(finalEndpoint);
        }

        public async Task<HttpResponseMessage> GetStudentsForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }


        public async Task<Users?> GetTeachersForClassInSchoolAsync(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Users>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetTeachersForClassInSchoolRaw(string schoolSourcedId, string classSourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{schoolSourcedId}/classes/{classSourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<Courses?> GetCoursesForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Courses>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetCoursesForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/courses";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<Enrollments?> GetEnrollmentsForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Enrollments>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetEnrollmentsForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/enrollments";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<List<User>?> GetStudentsForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetStudentsForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/students";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<List<User>?> GetTeachersForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<List<User>>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetTeachersForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/teachers";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<AcademicSessions?> GetTermsForSchoolAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetTermsForSchoolRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/terms";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }
    }
}