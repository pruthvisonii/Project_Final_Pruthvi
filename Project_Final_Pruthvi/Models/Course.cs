using System;
using System.Collections.Generic;

namespace Project_Final_Pruthvi.Models
{
    /// <summary>
    /// Represents a course offered in the student attendance tracking system.
    /// </summary>
    public class Course
    {
        /// <summary>
        /// Gets or sets the unique identifier for the course.
        /// </summary>
        public int CourseID { get; set; }

        /// <summary>
        /// Gets or sets the title of the course.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the instructor of the course.
        /// </summary>
        public string Instructor { get; set; }

        /// <summary>
        /// Gets or sets the schedule of the course.
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// Gets or sets the list of students enrolled in the course.
        /// </summary>
        public List<Student> Students { get; set; }
    }
}

