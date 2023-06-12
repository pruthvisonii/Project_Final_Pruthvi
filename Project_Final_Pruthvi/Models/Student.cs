using System;
using System.Collections.Generic;

namespace Project_Final_Pruthvi.Models
{
    /// <summary>
    /// Represents a student in the student attendance tracking system.
    /// </summary>
    public class Student
    {
        /// <summary>
        /// Gets or sets the unique identifier for the student.
        /// </summary>
        public int StudentID { get; set; }

        /// <summary>
        /// Gets or sets the name of the student.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the email of the student.
        /// </summary>
        public string Email { get; set; }

        /// <summary>
        /// Gets or sets the course associated with the student.
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Gets or sets the attendance records of the student.
        /// </summary>
        public List<Attendance> Attendance { get; set; }

        /// <summary>
        /// Gets or sets the grade of the student.
        /// </summary>
        public float Grade { get; set; }
    }
}
