using OneRoster.Api.Management;
using OneRoster.Api.Model;
using System.Net;
using System.Text;

namespace OneRoster.Api.Shared
{
	public class OneRosterService : IOneRosterService
    {
        private string _baseOneRosterUrl;
        private Token _token;
        private HttpClient _httpClient;
        private Dictionary<string, string> _filterRequestParameters;

        public OneRosterService(OneRosterVersionType versionType,
            string baseUrl, string clientId, string clientSecret)
        {
            _token = new Oauth2(baseUrl, clientId, clientSecret).GenerateToken(versionType).Result;
            _httpClient = new HttpClient();
            _httpClient.DefaultRequestHeaders.Add("Authorization", "Bearer " + _token.access_token);
            _filterRequestParameters = new Dictionary<string, string>();

            switch(versionType) 
            {
                case OneRosterVersionType.V1P2: 
                {
                        _baseOneRosterUrl = baseUrl + "/ims/oneroster/rostering/v1p2";
                        break;
				}
                case OneRosterVersionType.V1P1:
                default: 
                {
                        _baseOneRosterUrl = baseUrl + "/ims/oneroster/v1p1";
                        break;
                }
			}; 
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

        public async Task<T?> ExecuteAsync<T>(string endpoint) where T : new()
        {
            var finalEndpoint = _baseOneRosterUrl + endpoint + GenerateQueryString();
            var response = await GetResponse(endpoint);
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

        public async Task<string> GetRawResponse(string endpoint)
        {
            var finalEndpoint = _baseOneRosterUrl + endpoint + GenerateQueryString();
            var response = await GetResponse(endpoint);
            if (response != null)
            {
                if (response.StatusCode == HttpStatusCode.NoContent)
                {
                    return string.Empty;
                }
                else if (response.IsSuccessStatusCode)
                {
                    return await _httpClient.GetStringAsync(finalEndpoint);
                }
            }

            const string message = "Error retrieving response.  Check inner details for more info.";
            var exception = new Exception(message);
            throw exception;
        }

        public void AddRequestParameters(ApiParameters? p)
        {
            _filterRequestParameters.Clear();

            if (p == null) return;

            if (p.Filter != null)
            {
                _filterRequestParameters.Add("filter", p.Filter);
            }
            if (p.Sort != null)
            {
                _filterRequestParameters.Add("sort", p.Sort);
            }
            if (p.OrderBy != null)
            {
                _filterRequestParameters.Add("orderBy", p.OrderBy);
            }
            if (p.Limit.HasValue)
            {
                _filterRequestParameters.Add("limit", p.Limit.Value.ToString());
            }
            if (p.Offset.HasValue)
            {
                _filterRequestParameters.Add("offset", p.Offset.Value.ToString());
            }
            if (p.Fields != null)
            {
                _filterRequestParameters.Add("fields", p.Fields);
            }
            if (p.ExtBasic.HasValue)
            {
                _filterRequestParameters.Add("ext_basic", p.ExtBasic.Value.ToString());
            }
        }

        private async Task<HttpResponseMessage> GetResponse(string endpoint)
        {
            var finalEndpoint = _baseOneRosterUrl + endpoint + GenerateQueryString();
            return await _httpClient.GetAsync(finalEndpoint);
        }

        private string GenerateQueryString()
        {
            var isStartQuestionMark = false;
            var sb = new StringBuilder();
            foreach (var paramter in _filterRequestParameters)
            {
                if (paramter.Value == null) continue;

                sb.Append(isStartQuestionMark ? "&" : "?");
                sb.Append(paramter.Key);
                sb.Append("=");
                sb.Append(paramter.Value);

                isStartQuestionMark = true;
            }

            return sb.ToString();
        }
    }
}