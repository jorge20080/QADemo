using QADemo.Pages;

namespace QADemo;

public class Tests: BaseTests
{
    [Test, Description("Validate valid user can successfully login")]
    public void ValidateLogin()
    {
        var loginPage = new LoginPage(Driver);
        var indexPage = loginPage.Login(email, password);
        Assert.IsTrue(indexPage.IsUserLogged());
    }
}
