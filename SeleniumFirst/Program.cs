using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SeleniumFirst
{
    class Program
    {

        static void Main(string[] args)
        {
        }
        [SetUp]
        public void Initialize()
        {
            PropertiesCollection.driver = new FirefoxDriver();

            //Navigate to google page
            PropertiesCollection.driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Console.WriteLine("Opened URL");
        }

        [Test]
        public void ExecuteTest()
        {
            //Login to Application
            LoginPageObject pageLogin = new LoginPageObject();
            EAPageObject pageEA= pageLogin.Login("execute", "automation");
            Console.WriteLine("Successfully logged");

            pageEA.FillUserForm("KK", "Karthik", "Automation");
            Console.WriteLine("Entered initial, first and middle name");

            ////Initialize the page by calling its reference
            //EAPageObject page = new EAPageObject();

            //page.txtInitial.SendKeys("Opolska");

            //page.btnSave.Click();

            //    //Title
            //    SeleniumSetMethods.SelectDropDown("TitleId", "Mr.", PropertyType.Id);
            //    Console.WriteLine("Selected Title");

            //    //Initial
            //    SeleniumSetMethods.EnterText("Initial", "Opolska", PropertyType.Name);
            //    Console.WriteLine("Entered Initial");

            //    //Select Radiobutton
            //    SeleniumSetMethods.Click("Female", PropertyType.Name);
            //    Console.WriteLine("Selected radio button");

            //    Console.WriteLine("The value from my Title is:" + SeleniumGetMethods.GetText("TitleId", PropertyType.Id));

            //    Console.WriteLine("The value from my Initial is:" + SeleniumGetMethods.GetText("Initial", PropertyType.Name));
            //    //Click
            //    SeleniumSetMethods.Click("Save", PropertyType.Name);
            //    Console.WriteLine("Clicked Save");
        }

        
        [TearDown]
        public void CleanUp()
        {
            PropertiesCollection.driver.Close();
            Console.WriteLine("Closed the browser");
        }
    }

}
