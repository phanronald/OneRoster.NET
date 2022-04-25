using OneRoster.Api.Shared;
using RestSharp;
using System;
using System.Net;
using System.Threading.Tasks;

namespace OneRoster.Api.v1p1
{
    public class V1p1Api
    {
        private string _baseOneRosterV1Url;
        private Token _token;
        private HttpClient _httpClient;

        public V1p1Api(string baseUrl, string clientId, string clientSecret)
        {
            _token = new Oauth2(baseUrl, clientId, clientSecret).GetToken().Result;
            _baseOneRosterV1Url = baseUrl + "/ims/oneroster/v1p1";
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token.access_token);
        }

        /// <summary>
        /// This enables the management of academic sessions i.e. periods of academic activity.
        /// </summary>
        public AcademicSessionsManagement AcademicSessionsManagement => new(this);

        /// <summary>
        /// This enables the management of Classes i.e. scheduled learning of courses.
        /// </summary>
        public ClassesManagement ClassesManagement => new(this);

        /// <summary>
        /// This enables the management of Courses i.e. programme of study.
        /// </summary>
        public CoursesManagement CoursesManagement => new(this);

        /// <summary>
        /// This enables the management of demographics information (each assigned to a specific user).
        /// </summary>
        public DemographicsManagement DemographicsManagement => new(this);

        /// <summary>
        /// This enables the management of the enrollments of users (teachers, students, etc.) on classes supplied by schools.
        /// </summary>
        public EnrollmentsManagement EnrollmentsManagement => new(this);

        /// <summary>
        /// This enables the management of grading periods i.e. specific academic sessions.
        /// </summary>
        public GradingPeriodsManagement GradingPeriodsManagement => new(this);

        /// <summary>
        /// This enables the management of Orgs i.e. an organization involved in the learning in some form or other.
        /// </summary>
        public OrgsManagement OrgsManagement => new(this);

        /// <summary>
        /// This enables the management of information about schools. A school is a type of 'org'.
        /// </summary>
        public SchoolsManagement SchoolsManagement => new(this);

        /// <summary>
        /// This enables the management of information about students (a student is a type of 'user').
        /// </summary>
        public StudentsManagement StudentsManagement => new(this);

        /// <summary>
        /// This enables the management of information about teachers (a teacher is a type of 'user').
        /// </summary>
        public TeachersManagement TeachersManagement => new(this);

        /// <summary>
        /// This enables the management of information about terms (a term is a type of 'academicSession').
        /// </summary>
        public TermsManagement TermsManagement => new(this);

        /// <summary>
        /// This enables the management of information about users (including students and teachers).
        /// </summary>
        public UsersManagement UsersManagement => new(this);

        internal async Task<T?> ExecuteAsync<T>(string endpoint, ApiParameters? p) where T : new()
        {
            var finalEndpoint = _baseOneRosterV1Url + endpoint;
            var response = await GetResponse(endpoint, p);
            if (response != null)
            {
                if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    return default;
                }
                else if (response.IsSuccessStatusCode)
                {
                    return await _httpClient.GetFromJsonAsync<T>(finalEndpoint);
                }
            }

            const string message = "Error retrieving response.  Check inner details for more info.";
            var exception = new Exception(message);
            throw exception;
        }

        internal async Task<HttpResponseMessage> GetResponse(string endpoint, ApiParameters? p)
        {
            var finalEndpoint = _baseOneRosterV1Url + endpoint;
            return await _httpClient.GetAsync(finalEndpoint);
        }

        internal RestRequest AddRequestParameters(RestRequest r, ApiParameters? p)
        {
            if (p == null) return r;

            if (p.Filter != null)
            {
                r.AddParameter("filter", p.Filter);
            }
            if (p.Sort != null)
            {
                r.AddParameter("sort", p.Sort);
            }
            if (p.OrderBy != null)
            {
                r.AddParameter("orderBy", p.OrderBy);
            }
            if (p.Limit.HasValue)
            {
                r.AddParameter("limit", p.Limit.Value);
            }
            if (p.Offset.HasValue)
            {
                r.AddParameter("offset", p.Offset.Value);
            }
            if (p.Fields != null)
            {
                r.AddParameter("fields", p.Fields);
            }
            if (p.ExtBasic.HasValue)
            {
                r.AddParameter("ext_basic", p.ExtBasic.Value);
            }

            return r;
        }
    }
}