using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace QADemo.Utils
{
	public class BrowserActions
	{
		readonly WebDriverWait wait;

        public BrowserActions(IWebDriver driver)
		{
			this.wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        }
        public IWebElement WaitForElementToBeVisible(By element)
		{
			var elementFound = wait.Until(e => e.FindElement(element));
			return elementFound;
        }
        public void EnterText(By element, string text)
		{
			WaitForElementToBeVisible(element).SendKeys(text);
		}
		public void Click(By element)
		{
			WaitForElementToBeVisible(element).Click();
		}
	}
}

