using Microsoft.VisualStudio.TestTools.UnitTesting;
using GradeBook;
using System;

namespace GradeBookTests
{
    [TestClass]
    public class SubjectTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            try
            {
                Subject s = new Subject(SubjectType.C,100,4);

                if (s.marksObtained != null)
                    Assert.Fail();
            }
            catch(Exception e)
            {
                Assert.Fail();
            }

        }
    }
}
