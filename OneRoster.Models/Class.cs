using OneRoster.Models.Enum;
using OneRoster.Models.Shared;
using System.Text.Json.Serialization;

namespace OneRoster.Models
{
	/// <summary>
	/// A class is an instance of a course, onto which students and teachers are enrolled. A class is typically held within a term.
	/// </summary>
	public class ClassDetail : BaseOneRoster
    {
        public string? Title { get; set; }

        public string? ClassCode { get; set; }

        [JsonConverter(typeof(JsonStringEnumConverter))]
        public ClassType? ClassType { get; set; }

        public string? Location { get; set; }

        public List<string>? Grades { get; set; }

        public List<string>? Subjects { get; set; }

        public GuidRef? Course { get; set; }

        public GuidRef? School { get; set; }

        public List<GuidRef>? Terms { get; set; }

        public List<string>? SubjectCodes { get; set; }

        public List<string>? Periods { get; set; }

        public List<GuidRef>? Resources { get; set; }
    }

    public class Classes
    {
        public List<ClassDetail>? classes { get; set; }
    }

    public class Class
    {
        public ClassDetail? @class { get; set; }
    }
}