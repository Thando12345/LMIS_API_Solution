namespace LMIS_Dev_Branch.Models
{
    public class RegistrationModel : IModel
    {
        public Student StudentDetails { get; set; }
        public Null_Course CourseDetails { get; set; }
        public RegistrationModel(Student studentdetails, Null_Course coursedetails)
        {
            this.StudentDetails = studentdetails;
            this.CourseDetails = coursedetails;
        }

    }
}
