using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using RapidCase.Common.SpecFlow;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace RapidCase.BasicSystem.Specifications.Setup
{    
    [Binding]
    public class InitalSetUpStepDefinitions : BaseStepDefinitions
    {
        SetUpPageModel setUpPage;

        [Given(@"I start up the system for the first time")]
        public void GivenIStartUpTheSystemForTheFirstTime()
        {
            ChangeWebConfig.SetAppSettingValue("FirstTime", "True");            
        }

        [Given(@"the database location is not set")]
        public void GivenTheDatabaseLocationIsNotSet()
        {
            ChangeWebConfig.SetAppSettingValue("DBLocation", "");
            ChangeWebConfig.SetAppSettingValue("DBPort", "");
        }

        [Then(@"I will be asked to enter the location of the database\. Either I can select local and port number or a remote url and a port number\.")]
        public void ThenIWillBeAskedToEnterTheLocationOfTheDatabase_EitherICanSelectLocalAndPortNumberOrARemoteUrlAndAPortNumber_()
        {
            Assert.AreEqual("Initial setup - RapidCase", setUpPage.Title);
            Assert.IsTrue(setUpPage.LocationTextBoxElement.Displayed);
            Assert.IsTrue(setUpPage.PortTextBoxElment.Displayed);
        }

        [When(@"I navigate to the default page")]
        public void WhenINavigateToTheDefaultPage()
        {
            setUpPage = new SetUpPageModel(Driver);            
        }
    }
}
