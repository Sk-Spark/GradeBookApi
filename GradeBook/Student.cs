using System;
using System.Collections;

namespace GradeBook
{
    public class Student
    {
        public int id { get; }
        public String name { get; set; }
        Boolean computeFlag { get; set; }
        float? totalMarks { get; set; }
        float? avgMarks { get; set; }
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

        public Boolean addSubject(SubjectType name, int maxMarks, int credits)
        {
            Subject s = new Subject(name, maxMarks, credits);
            if (subjects.Contains(s))
            {
                return false;
            }

            subjects.Add(s);
            computeFlag = true;

            return true;
        }

        public Boolean addSubject(SubjectType name)
        {
            Subject s = Subject.getSubject(name);
            if (subjects.Contains(s))
            {
                return false;
            }

            subjects.Add(s);
            computeFlag = true;

            return true;
        }

        public void showSubjects()
        {
            foreach(Subject s in subjects)
            {
                Console.WriteLine(s.ToString());
            }
        }

        void computeResult()
        {
            if (subjects.Count < 1) return;

            resultCount = 0;

            foreach(Subject s in subjects)
            {
                if (s.marksObtained == null) continue;

                if (totalMarks == null) totalMarks = 0;

                totalMarks += s.marksObtained;
                resultCount++;

                if (highestMarksSub == null || highestMarksSub.marksObtained < s.marksObtained)
                    highestMarksSub = s;

                if (lowestMarksSub == null || lowestMarksSub.marksObtained < s.marksObtained)
                    lowestMarksSub = s;
            }

            avgMarks = totalMarks / (float?)this.resultCount;

            computeFlag = false;
        }

        public float? getTotalMarks()
        {
            if (computeFlag)
                computeResult();

            return totalMarks;
        }

        public float? getAvgMarks()
        {
            if (computeFlag)
                computeResult();

            return avgMarks;
        }

        public Subject getHighestMarksSub()
        {
            if (computeFlag)
                computeResult();

            return highestMarksSub;
        }

        public Subject getLowestMarksSub()
        {
            if (computeFlag)
                computeResult();

            return lowestMarksSub;
        }






    }
}
