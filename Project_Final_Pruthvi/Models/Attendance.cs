using System;
using System.Collections.Generic;

namespace Project_Final_Pruthvi.Models
{
    /// <summary>
    /// Represents the attendance information for a specific course on a particular date.
    /// </summary>
    public class Attendance
    {
        /// <summary>
        /// Gets or sets the unique identifier for the attendance record.
        /// </summary>
        public int AttendanceID { get; set; }

        /// <summary>
        /// Gets or sets the date for which the attendance is recorded.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the course associated with the attendance.
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Gets or sets the list of students present for the attendance.
        /// </summary>
        public List<Student> StudentsPresent { get; set; }

        /// <summary>
        /// Gets or sets the list of students absent for the attendance.
        /// </summary>
        public List<Student> StudentsAbsent { get; set; }

        /// <summary>
        /// Gets or sets the total number of students in the course.
        /// </summary>
        public int TotalStudents { get; set; }
    }
}
