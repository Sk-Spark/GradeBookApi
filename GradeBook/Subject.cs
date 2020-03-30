
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

        public override int GetHashCode()
        {
            return (int)this.name;
        }

        public override bool Equals(object obj)
        {
            Subject Obj = (Subject)obj;

            if (Obj.name == this.name)
                return true;
            else
                return false;
        }

        public override string ToString()
        {
            string sub = "";

            sub += $" {{ name={this.name}, credits ={this.credits}, marksObtained={this.marksObtained}, " +
                $"maxMarks={this.maxMarks} }} ";

            return sub;
        }

        public static Subject getSubject(SubjectType name)
        {
            int maxMarks = 0;
            int credits = 0;

            switch(name)
            {
                case SubjectType.C :
                    maxMarks = 100;
                    credits = 4;
                    break;

                case SubjectType.Java:
                    maxMarks = 100;
                    credits = 4;
                    break;

                case SubjectType.OS:
                    maxMarks = 100;
                    credits = 3;
                    break;
            }

            Subject s = new Subject(name, maxMarks, credits);

            return s;
        }


    }
}
