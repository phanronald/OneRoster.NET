using OneRoster.Api.Shared;

namespace OneRoster.Api.Model
{
	public interface IOneRosterService
	{
        Task<T?> ExecuteAsync<T>(string endpoint) where T : new();
        Task<string> GetRawResponse(string endpoint);
        void AddRequestParameters(ApiParameters? p);
    }
}
