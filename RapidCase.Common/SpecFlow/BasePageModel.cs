﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;

namespace RapidCase.Common.SpecFlow
{
    public class BasePageModel
    {
        private IWebDriver driver;

        protected BasePageModel(IWebDriver webDriver, By knownElementOnPage, String loadUrl = "")
        {
            this.driver = webDriver;
            if (loadUrl != String.Empty)
            {
                driver.Navigate().GoToUrl(loadUrl);
            }
            this.FindKnownElementOnPage(knownElementOnPage);
        }

        public string Title
        {
            get { return driver.Title; }
        }

        public IWebDriver Driver
        {
            get { return this.driver; }
            set { this.driver = value; }
        }

        private void FindKnownElementOnPage(By knownElementOnPage)
        {
            this.Driver.GetElement(knownElementOnPage);
        }
    }

}
