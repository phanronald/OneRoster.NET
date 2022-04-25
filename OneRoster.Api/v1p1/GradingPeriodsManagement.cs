﻿using OneRoster.Api.SharedDtos;

namespace OneRoster.Api.v1p1
{
	public class GradingPeriodsManagement
    {
        private readonly V1p1Api _oneRosterApi;
        private readonly string _baseEndpoint = "/gradingPeriods";

        public GradingPeriodsManagement(V1p1Api oneRosterApi)
        {
            _oneRosterApi = oneRosterApi;
        }

        public async Task<AcademicSessions?> GetAllGradingPeriodsAsync(ApiParameters? p = null)
        {
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSessions>(_baseEndpoint, p);
        }
        public async Task<HttpResponseMessage> GetAllGradingPeriodsRaw(ApiParameters? p = null)
        {
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(_baseEndpoint, p);
        }

        public async Task<AcademicSession?> GetGradingPeriodAsync(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.ExecuteAsync<AcademicSession>(finalEndpoint, p);
        }
        public async Task<HttpResponseMessage> GetGradingPeriodRaw(string sourcedId, ApiParameters? p = null)
        {
            var finalEndpoint = $"{_baseEndpoint}/{sourcedId}";
            //_oneRosterApi.AddRequestParameters(_request, p);
            return await _oneRosterApi.GetResponse(finalEndpoint, p);
        }
    }
}