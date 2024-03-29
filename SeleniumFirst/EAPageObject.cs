﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium;

namespace SeleniumFirst
{
    class EAPageObject
    {
        public EAPageObject()
        {
            PageFactory.InitElements(PropertiesCollection.driver, this);
        }

        [FindsBy(How = How.Id,Using ="TitleId")]
        public IWebElement ddTitileID { get; set; }

        [FindsBy(How= How.Name,Using ="Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Id, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How=How.Name,Using ="Save")]
        public IWebElement btnSave { get; set; }

        public void FillUserForm(string initial, string middleName, string firstName)
        {
            //SeleniumSetMethods.EnterText(txtInitial, initial);
            //SeleniumSetMethods.EnterText(txtFirstName, firstName);
            //SeleniumSetMethods.EnterText(txtMiddleName, middleName);
            //SeleniumSetMethods.Click(btnSave);

            txtInitial.SendKeys(initial);
            txtFirstName.SendKeys(firstName);
            txtMiddleName.SendKeys(middleName);
            btnSave.Click();
        }
    }
}
