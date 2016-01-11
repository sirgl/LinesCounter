using System.Collections.Generic;
using System.IO;

namespace LinesCounter
{
    class ExtensionFilter : IFileNameFilter
    {
        private readonly HashSet<string> allowedExtensions;

        public ExtensionFilter(HashSet<string> allowedExtensions)
        {
            this.allowedExtensions = allowedExtensions;
        }

        public bool DoFilter(string name)
        {
            var extension = Path.GetExtension(name);
            return allowedExtensions.Contains(extension);
        }
    }
}