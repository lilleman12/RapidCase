using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using RapidCase.Common.SpecFlow;
using OpenQA.Selenium;


namespace RapidCase.BasicSystem.Specifications.Setup
{
    public class SetUpPageModel : BasePageModel
    {
        private static readonly String Url = "http://localhost:24289";
        private static readonly By LocationTextBoxSelector = By.Id("DBLocation");
        private static readonly By PortTextBoxSelector = By.Id("DBPort");
        private static readonly By AdministrationPasswordTextBoxSelector = By.Id("AdministratorPassword");
        private static readonly By ConfirmAdministrationPasswordTextBoxSelector = By.Id("ConfirmAdministratorPassword");
        private static readonly By SaveButtonSelector = By.Id("saveButton");

        public SetUpPageModel(IWebDriver driver)
            : base(driver, SaveButtonSelector, Url)
        {
        }

        public IWebElement LocationTextBoxElement
        {
            get { return Driver.GetElement(LocationTextBoxSelector); }
        }

        public IWebElement PortTextBoxElment
        {
            get { return Driver.GetElement(PortTextBoxSelector); }
        }

        public IWebElement AdministrationPasswordTextBoxElement
        {
            get { return Driver.GetElement(AdministrationPasswordTextBoxSelector); }
        }

        public IWebElement ConfirmAdministrationPasswordTextBoxElement
        {
            get { return Driver.GetElement(ConfirmAdministrationPasswordTextBoxSelector); }
        }   

        public IWebElement SaveButtonElement
        {
            get { return Driver.GetElement(SaveButtonSelector); }
        }       
    }


}
