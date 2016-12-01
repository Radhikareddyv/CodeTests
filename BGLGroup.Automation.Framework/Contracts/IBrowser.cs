using OpenQA.Selenium;

namespace BGLGroup.Automation.Framework.Contracts
{
    public interface IBrowser
    {
        IWebDriver Initialize();
    }
}