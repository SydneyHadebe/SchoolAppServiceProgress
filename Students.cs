namespace SchoolCommunicationService
{
    public class Students : Subjects, ISubjectMarks
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string StudentSurname { get; set; }
        public char StudentSex { get; set; }
        public int StudentAge { get; set; }
        public decimal Mark { get; set ; }
    }
}