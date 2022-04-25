﻿using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.v1p1
{
	public class CoursesManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly string _baseEndpoint = "/courses";

        public CoursesManagement(V1p1Api oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<Courses?> GetAllCoursesAsync(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Courses>(_baseEndpoint);
        }

        public async Task<HttpResponseMessage> GetAllCoursesRaw(ApiParameters? p = null)
        {
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(_baseEndpoint);
        }

        public async Task<Course?> GetCourseAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Course>(finalEndpoint);
        }
        public async Task<HttpResponseMessage> GetCourseRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

        public async Task<Classes?> GetClassesForCourseAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.ExecuteAsync<Classes>(finalEndpoint);
        }

        public async Task<HttpResponseMessage> GetClassesForCourseRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}/classes";
            _oneRosterApi.AddRequestParameters(p);
            return await _oneRosterApi.GetResponse(finalEndpoint);
        }

    }
}