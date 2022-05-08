
using System.Text.Json.Serialization;

namespace OneRoster.Models.Shared
{
    public class UserRole
    {
        [JsonConverter(typeof(JsonStringEnumConverter))]
        public RoleType? Role { get; set; }

        public GuidRef? Org { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public UserRoleRoleType? RoleType { get; set; }
    }

   
}