using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BGLGroup.Automation.Framework.Contracts;
using OpenQA.Selenium;
using OpenQA.Selenium.IE;

namespace BGLGroup.Automation.Framework.Common
{
   public class IEBrowser : IBrowser
    {
        public IWebDriver Initialize()
        {
            return new InternetExplorerDriver();
        }
    }
}
