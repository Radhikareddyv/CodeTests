using BGLGroup.Automation.Framework.Common;

namespace BGLGroup.Automation.Framework.Models.AboutYou
{
    public class AboutYouModel : AboutYouPageObject
    {
        public string HeaderText => HeaderElement.Text;
    }
}
