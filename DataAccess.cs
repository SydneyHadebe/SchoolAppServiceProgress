using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace SchoolCommunicationService
{
    public class DataAccess
    {
        //I used Dapper framework to connect sql server
        public List<Students> GetStudents()
        {

            //The using namespace makes sure you don't live connection to the server open.
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlDataAccessConnection.connect("SchoolApp")))
            {
                var results = connection.Query<Students>("GetAllStudents").ToList();
                return results;
            }
        }

        public List<Students> GetIndividualStudents(string studentName)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlDataAccessConnection.connect("SchoolApp")))
            {
                var results = connection.Query<Students>("GetIndividualStudents @StudentName", new { StudentName = studentName }).ToList();
                return results;
            }
        }

        public List<Students> GetStudentsWithCourses()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlDataAccessConnection.connect("SchoolApp")))
            {
                var results = connection.Query<Students>("GetStudentsWithMarks").ToList();
                return results;
            }
        }

        public List<Students> GetStudentWithMarks()
        {

            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(SqlDataAccessConnection.connect("SchoolApp")))
            {
                var results = connection.Query<Students>("GetStudentsWithMarks").ToList();

                return results;
            }

        }


    }
}