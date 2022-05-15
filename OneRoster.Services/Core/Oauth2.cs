using Newtonsoft.Json;
using OneRoster.Models.Enum;
using OneRoster.Models.Shared;
using System.Net;

namespace OneRoster.Services.Core
{
	internal class Oauth2
    {
        private readonly string _baseUrl = string.Empty;
        private readonly string _clientId = string.Empty;
        private readonly string _clientSecret = string.Empty;

        internal Oauth2(string baseUrl, string clientId, string clientSecret)
        {
            _baseUrl = baseUrl;
            _clientId = clientId;
            _clientSecret = clientSecret;
        }

        internal async Task<Token> GenerateToken(OneRosterVersionType oneRosterVersionType)
        {
            var scopeUrl = string.Empty;
            switch(oneRosterVersionType)
            {
                case OneRosterVersionType.V1P2:
                {
                        scopeUrl = "http://purl.imsglobal.org/spec/or/v1p2/scope/roster.readonly http://purl.imsglobal.org/spec/or/v1p2/scope/roster-core.readonly http://purl.imsglobal.org/spec/or/v1p2/scope/roster-demographics.readonly";
                        break;
				}
                case OneRosterVersionType.V1P1:
                default:
                {
                        scopeUrl = "https://purl.imsglobal.org/spec/or/v1p1/scope/roster-core.readonly";
                        break;
				}
			}

            return await GetToken(scopeUrl);
		}

        private async Task<Token> GetToken(string scopeUrl)
        {
            var parameters = new[] {
                new KeyValuePair<string, string>("grant_type", "client_credentials"),
                new KeyValuePair<string, string>("client_id", _clientId),
                new KeyValuePair<string, string>("client_secret", _clientSecret),
                new KeyValuePair<string, string>("scope", scopeUrl),
            };

            using var httpClient = new HttpClient();
            var response = await httpClient.PostAsync(_baseUrl + "/token", new FormUrlEncodedContent(parameters));

            if (response == null)
            {
                return new Token() { error = "Could Not Complete Token Request.The Response was empty." };
            }

            if (response.Content != null)
            {
                var responseAsString = await response.Content.ReadAsStringAsync();
                var token = JsonConvert.DeserializeObject<Token>(responseAsString);

                if (token != null)
                {
                    switch (response.StatusCode)
                    {
                        case HttpStatusCode.OK:
                            break;
                        case HttpStatusCode.NotFound:
                        case 0:
                            token.error = "Could Not Contact Token URL";
                            break;
                        case HttpStatusCode.BadRequest:
                            token.error = "Bad Request";
                            token.error_description = responseAsString;
                            break;
                        default:
                            token.error_description = "Unknown Error Obtaining Token";
                            break;
                    }

                    return token;
                }
            }

            return new Token();
        }
    }
}