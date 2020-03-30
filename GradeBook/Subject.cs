
namespace GradeBook
{
    public class Subject
    {
        public SubjectType name { get; set; }
        public int maxMarks { get; set; }
        public int credits { get; set; }
        public float? marksObtained { get; set; }

        public Subject(SubjectType name, int maxMarks, int credits, float? marksObtained)
        {
            this.name = name;
            this.maxMarks = maxMarks;
            this.marksObtained = marksObtained;
            this.credits = credits;
        }

        public Subject(SubjectType name, int maxMarks, int credits)
        {
            this.name = name;
            this.maxMarks = maxMarks;
            this.marksObtained = null;
            this.credits = credits;
        }


    }
}
