using QADemo.Pages;

namespace QADemo;

public class Tests: BaseTests
{
    [Test, Description("Validate valid user can successfully login")]
    public void ValidateLoginWithValidCredentials()
    {
        var loginPage = new LoginPage(Driver);
        var indexPage = loginPage.Login(validEmail, validPassword);
        Assert.IsTrue(indexPage.IsUserLogged());
    }

    [Test, Description("Validate invalid user cannot successfully login")]
    public void ValidateLoginWithInvalidCredentials()
    {
        var loginPage = new LoginPage(Driver);
        loginPage.Login(invalidEmail, validPassword);
        Assert.IsTrue(loginPage.IsLoginErrorDisplayed());
    }
}
