using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QADemo
{
	public class BaseTests
	{
        string url = "https://demo.oneboss.ca/repweb/client/login.xhtml";
        public string invalidEmail = "a@a.com";
        public string validEmail = "jorge20080@hotmail.com";
        public string validPassword = "1234";
        public IWebDriver Driver { get; set; }

        [SetUp]
        public void Setup()
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
        }

        [TearDown]
        public void TearDown()
        {
            Driver.Close();
        }
    }
}

