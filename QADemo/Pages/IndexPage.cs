using System;
using OpenQA.Selenium;
using QADemo.Utils;

namespace QADemo.Pages
{
	public class IndexPage
	{
		By LogOutBtn { get; } = By.XPath("//a[text()='Logout']");
		BrowserActions browserActions;

        public IndexPage(IWebDriver driver)
        {
            browserActions = new BrowserActions(driver);
        }
        public bool IsUserLogged()
		{
			try
			{
				browserActions.WaitForElementToBeVisible(LogOutBtn);
				return true;
			}
			catch
			{
				return false;
			}
		}
	}
}

