using OneRoster.Models.Enum;
using System.Text.Json.Serialization;

namespace OneRoster.Models.Shared
{
	public abstract class BaseOneRoster
	{
		public string? SourcedId { get; set; }

		[JsonConverter(typeof(JsonStringEnumConverter))]
		public BaseStatusType? Status { get; set; }

		public DateTimeOffset? DateLastModified { get; set; }

		public Dictionary<string, string>? Metadata { get; set; }
	}
}
