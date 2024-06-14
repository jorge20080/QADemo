using System;
using OpenQA.Selenium;
using QADemo.Utils;

namespace QADemo.Pages
{
	public class LoginPage
	{
		//Locators
		By EmailInput { get; } = By.Id("inputEmail");
		By PasswordInput { get; } = By.Id("inputPassword");
		By LoginBtn { get; } = By.XPath("//input[@value='Log In']");

		BrowserActions browserActions;
		IWebDriver driver;
		public LoginPage(IWebDriver driver)
		{
			this.driver = driver;
			browserActions = new BrowserActions(driver);
		}

		public IndexPage Login(string username, string password)
		{
			browserActions.EnterText(EmailInput, username);
			browserActions.EnterText(PasswordInput, password);
			browserActions.Click(LoginBtn);
			return new IndexPage(driver);
		}
	}
}

