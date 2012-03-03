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
        private static readonly By LocationTextBoxSelector = By.Id("ravenDBLocation");
        private static readonly By PortTextBoxSelector = By.Id("ravenDBPort");
        private static readonly By PasswordTextBoxSelector = By.Id("password");
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

        public IWebElement PasswordTextBoxElement
        {
            get { return Driver.GetElement(PasswordTextBoxSelector); }
        }   

        public IWebElement SaveButtonElement
        {
            get { return Driver.GetElement(SaveButtonSelector); }
        }       
    }


}
