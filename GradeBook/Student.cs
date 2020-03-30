using System;
using System.Collections;

namespace GradeBook
{
    public class Student
    {
        public int id { get; }
        public String name { get; set; }
        Boolean computeFlag { get; set; }
        int? totalMarks { get; set; }
        float avgMarks { get; set; }
        Subject highestMarksSub { get; set; }
        Subject lowestMarksSub { get; set; }
        char? Grade { get; set; }
        ArrayList subjects;
        int resultCount { get; set; } // Subject With Obtained Marks

        public Student(int id, String name)
        {
            this.id = id;
            this.name = name;
            computeFlag = false;
            totalMarks = null;
            avgMarks = 0;
            highestMarksSub = null;
            lowestMarksSub = null;
            Grade = null;
            resultCount = 0;
            subjects = new ArrayList();
        }

        public Boolean addSubject(SubjectType name, int maxMarks, int credits, float? marksObtained)
        {

            Subject s = new Subject(name, maxMarks, credits, marksObtained);
            if(subjects.Contains(s))
            {
                return false;
            }

            subjects.Add(s);
            computeFlag = true;

            return true;
        }



    }
}
