using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using OpenQA.Selenium;


namespace RapidCase.Common.SpecFlow
{
    [Binding]
    public class BaseStepDefinitions
    {
        private const string CurrentPageKey = "Current.Page";
        public static IWebDriver Driver { get; set; }
        
        //protected GoogleHomePageModel GoogleHomePage
        //{
        //    get { return (GoogleHomePageModel)ScenarioContext.Current[CurrentPageKey]; }
        //    set { ScenarioContext.Current[CurrentPageKey] = value; }
        //}        
    }

}
