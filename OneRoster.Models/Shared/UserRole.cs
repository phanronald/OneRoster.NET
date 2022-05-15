
using OneRoster.Models.Enum;
using System.Text.Json.Serialization;

namespace OneRoster.Models.Shared
{
    public class UserRole
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UserRoleRoleType? RoleType { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RoleType? Role { get; set; }

        public GuidRef? Org { get; set; }

        public UserProfile? UserProfile { get; set; }

        public DateTimeOffset? BeginDate { get; set; }

        public DateTimeOffset? EndDate { get; set; }
    }
}