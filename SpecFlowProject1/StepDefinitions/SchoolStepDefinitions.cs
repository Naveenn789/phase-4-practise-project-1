using ClassLibrary1;
using NUnit.Framework;
using System;

namespace SpecFlowProject1.StepDefinitions
{
    [Binding]
    public class SchoolStepDefinitions
    {
        Teacher t = new Teacher()
        {
            Id = 1,Name="Ram"
        };
        Student s = new Student()
        {
            Id=1,Name="Vishnu",Mobile=9876543210,Class=10
        };
        Subject sub = new Subject() 
        {
            SubCode=001,SubName="English"
        };
        private readonly ScenarioContext _scenarioContext;

        public SchoolStepDefinitions(ScenarioContext scenarioContext)
        {
            this._scenarioContext = scenarioContext;
        }
        [Given(@"the list of Teacher data")]
        public void GivenTheListOfTeacherData()
        {
            Teacher teacher = t;
        }
        [Then(@"the result of Teacher data should match")]
        public void ThenTheResultOfTeacherDataShouldMatch()
        {
            Assert.AreEqual(1,t.Id);
        }

        [Given(@"the list Student of data")]
        public void GivenTheListStudentOfData()
        {
            Student student = s;
        }
        [When(@"the data is fetched")]
        
        [Then(@"the result of Student dta should match")]
        public void ThenTheResultOfStudentDtaShouldMatch()
        {
            Assert.AreEqual(9876543210,s.Mobile);  
        }

        [Given(@"the list Subject of data")]
        public void GivenTheListSubjectOfData()
        {
            Subject subject = sub;
        }

        [Then(@"the result of Subject data should match")]
        public void ThenTheResultOfSubjectDataShouldMatch()
        {
            Assert.AreEqual("English",sub.SubName);
        }
    }
}
