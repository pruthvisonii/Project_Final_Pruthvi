using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project_Final_Pruthvi.Models;

namespace Project_Final_Pruthvi.Services
{
    public class StudentService
    {

        public List<Student> GetAllStudents()
        {
            // Retrieve all student records from the database or a data source
            // Perform any necessary data manipulation or filtering

            // Return the list of students
            return new List<Student>();
        }

        public void UpdateAttendance(Student student, Attendance attendance)
        {
            // Update the attendance record for a student in the database or a data source
            // Perform any necessary validation or error handling
        }

        public void EnrollStudent(Student student, Course course)
        {
            // Enroll a student in a course by updating the database or a data source
            // Perform any necessary validation or error handling
        }
    }
}
