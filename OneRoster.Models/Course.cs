﻿using OneRoster.Models.Shared;

namespace OneRoster.Models
{
    /// <summary>
    /// A Course is a course of study that, typically, has a shared curriculum although it may be taught to different students by different 
    /// teachers. It is likely that several classes of a single course may be taught in a term. For example, a school runs Grade 9 English 
    /// in the spring term. There are four classes, each with a different 30 students, taught by 4 different teachers. However the curriculum 
    /// for each of those four classes is the same - the course curriculum.
    /// </summary>
    public class CourseDetail : BaseOneRoster
    {
        public string? Title { get; set; }
        public GuidRef? SchoolYear { get; set; }

        public string? CourseCode { get; set; }

        public List<string>? Grades { get; set; }

        public List<string>? Subjects { get; set; }

        public GuidRef? Org { get; set; }

        public List<string>? SubjectCodes { get; set; }

        public List<GuidRef>? Resources { get; set; }
    }

    public class Courses
    {
        public List<CourseDetail>? courses { get; set; }
    }

    public class Course
    {
        public CourseDetail? course { get; set; }
    }
}