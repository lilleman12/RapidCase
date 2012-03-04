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

        #region Common
        
        [Given(@"I start up the system for the first time")]
        public void GivenIStartUpTheSystemForTheFirstTime()
        {
            WebConfigHelper.SetAppSettingValue("FirstTime", "True");                           
        }

        #endregion

        #region Show database location selection screen if database location is missing
        [Given(@"the database location is not set")]
        public void GivenTheDatabaseLocationIsNotSet()
        {
            WebConfigHelper.SetAppSettingValue("DBLocation", "");
            WebConfigHelper.SetAppSettingValue("DBPort", "");
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
        #endregion

        #region  Enter setup information correct


        [Given(@"the administration password is not set")]
        public void GivenTheAdministrationPasswordIsNotSet()
        {
            WebConfigHelper.SetAppSettingValue("AdministrationPassword", "");            
        }

        [Given(@"setup screen i showing")]
        public void GivenSetupScreenIShowing()
        {
            setUpPage = new SetUpPageModel(Driver);
            Assert.IsTrue(setUpPage.LocationTextBoxElement.Displayed);
            Assert.IsTrue(setUpPage.PortTextBoxElment.Displayed);
        }

        [When(@"I select the default value local machine as database location, port 8080 as port")]
        public void WhenISelectTheDefaultValueLocalMachineAsDatabaseLocationPort8080AsPort()
        {
            //Localhost and port 8080 is set by default no action needed
        }
        
        [When(@"I enter test as administration password")]
        public void WhenIEnterTestAsAdministrationPassword()
        {
            setUpPage.AdministrationPasswordTextBoxElement.SendKeys("test");
            setUpPage.ConfirmAdministrationPasswordTextBoxElement.SendKeys("test");
        }

        [When(@"I click the save button")]
        public void WhenIClickTheSaveButton()
        {
            setUpPage.SaveButtonElement.Click();
        }        
               
        [Then(@"the database location i saved as http://localhost:8080")]
        public void ThenTheDatabaseLocationISavedAsHttpLocalhost8080()
        {
            Assert.AreEqual("Localhost", WebConfigHelper.GetAppSettingValue("DBLocation"));
            Assert.AreEqual("8080", WebConfigHelper.GetAppSettingValue("DBPort"));
        }
        

        [Then(@"administration password i saved as test")]
        public void ThenAdministrationPasswordISavedAsTest()
        {
            Assert.AreEqual("test", WebConfigHelper.GetAppSettingValue("AdministrationPassword"));
        }

       

        #endregion

        #region ""               

        [When(@"I select that my database is on a remote machine\. I enter 127\.0\.0\.1 as database location, port 8080 as port")]
        public void WhenISelectThatMyDatabaseIsOnARemoteMachine_IEnter127_0_0_1AsDatabaseLocationPort8080AsPort()
        {
            setUpPage.LocationTextBoxElement.Set("127.0.0.1");            
        }

        [Then(@"the database location i saved as http://127\.0\.0\.1:8080")]
        public void ThenTheDatabaseLocationISavedAsHttp127_0_0_18080()
        {
            Assert.AreEqual("127.0.0.1", WebConfigHelper.GetAppSettingValue("DBLocation"));
            Assert.AreEqual("8080", WebConfigHelper.GetAppSettingValue("DBPort"));
        }
        #endregion
    }
}
