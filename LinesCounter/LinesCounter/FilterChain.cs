using System.Collections.Generic;
using System.Linq;

namespace LinesCounter
{
    public class FilterChain : IFileNameFilter
    {
        private readonly List<IFileNameFilter> filters = new List<IFileNameFilter>();

        public FilterChain()
        {
        }

        public void AddFilter(IFileNameFilter filter)
        {
            filters.Add(filter);
        }


        public bool DoFilter(string name)
        {
            return filters.All(filter => filter.DoFilter(name));
        }
    }
}