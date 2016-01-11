using System.Text.RegularExpressions;

namespace LinesCounter
{
    public class RegexFileNameFilter : IFileNameFilter
    {
        private readonly Regex regex;

        public RegexFileNameFilter(Regex regex)
        {
            this.regex = regex;
        }

        public bool DoFilter(string name)
        {
            return regex.IsMatch(name);
        }
    }
}