using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace SchoolCommunicationService
{
    public class Service1 : IStudentServ
    {
        public List<Students> GetIndivualStudenst(string studentName)
        {
            DataAccess access = new DataAccess();
            var results = access.GetIndividualStudents(studentName);
            return results;
        }

        public List<Students> GetStudents()
        {
            DataAccess access = new DataAccess();
            var results = access.GetStudents();
            return results;
        }

       
        public List<Students> GetStudentWithMarks()
        {
            DataAccess access = new DataAccess();
            var results = access.GetStudentWithMarks();
            return results;
        }
    }
}
