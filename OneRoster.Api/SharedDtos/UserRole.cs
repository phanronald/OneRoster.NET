
using OneRoster.Api.Shared;
using System.Text.Json.Serialization;

namespace OneRoster.Api.SharedDtos
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