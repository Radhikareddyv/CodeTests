using System;
using System.Collections.Generic;
using System.Linq;
using BGLGroup.Automation.Framework.Contracts;
using BGLGroup.Automation.Framework.Models;

namespace BGLGroup.Automation.Framework.Common
{
    public sealed class Pages
    {
        public static readonly Pages Welcome = new Pages("Welcome", "WelcomePageObject", (manager) => manager.GoToWelcomePage());

        public static readonly Pages AboutYou = new Pages("AboutYou", "AboutYouPageObject",
            (manager) => manager.GoToAboutYouPage());

        public string Name;
        public string Description;
        public Func<INavigationManager, PageModel> Navigate; 

        public Pages(string name, string description, Func<INavigationManager, PageModel> navigate)
        {
            this.Name = name;
            this.Description = description;
            this.Navigate = navigate;
        }

        private static IEnumerable<Pages> GetAllPages()
        {
            return new[] { Welcome, AboutYou };
        }

        public static Pages By(string name)
        {
            return GetAllPages().FirstOrDefault(x => x.Name == name);
        }
    }
}