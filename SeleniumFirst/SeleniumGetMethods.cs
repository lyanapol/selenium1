using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumGetMethods
    {
        //Get value from text field
        public static string GetText(IWebElement element)
        {
            return element.GetAttribute("value");
        }

        //Get value from drop-down list
        //public static string GetTextFromDDL(string element, PropertyType elementtype)
        //{
        //    if (elementtype == "Id")
        //        return new SelectElement(PropertiesCollection.driver.FindElement(By.Id(element))..Text);
        //    if (elementtype == "Name")
        //        return new SelectElement(PropertiesCollection.driver.FindElement(By.Name(element)).AllSelectedOptions.SingleOrDefault().Text;
        //    else return String.Empty;
        //}
    }
}
