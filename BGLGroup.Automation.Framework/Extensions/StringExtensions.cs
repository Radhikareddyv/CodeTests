namespace BGLGroup.Automation.Framework.Extensions
{
    public static class StringExtensions
    {
        public static string CleanUpNewLines(this string text)
        {
            return text.Replace(System.Environment.NewLine, string.Empty).Trim();
        } 
    }
}