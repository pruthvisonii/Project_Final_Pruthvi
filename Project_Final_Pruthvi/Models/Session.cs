using System;
using System.Collections.Generic;

namespace Project_Final_Pruthvi.Models
{
    /// <summary>
    /// Represents a session of a course in the student attendance tracking system.
    /// </summary>
    public class Session
    {
        /// <summary>
        /// Gets or sets the unique identifier for the session.
        /// </summary>
        public int SessionID { get; set; }

        /// <summary>
        /// Gets or sets the course associated with the session.
        /// </summary>
        public Course Course { get; set; }

        /// <summary>
        /// Gets or sets the date of the session.
        /// </summary>
        public DateTime Date { get; set; }

        /// <summary>
        /// Gets or sets the start time of the session.
        /// </summary>
        public TimeSpan StartTime { get; set; }

        /// <summary>
        /// Gets or sets the end time of the session.
        /// </summary>
        public TimeSpan EndTime { get; set; }

        /// <summary>
        /// Gets or sets the attendance record for the session.
        /// </summary>
        public Attendance Attendance { get; set; }
    }
}

