using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LinesCounter
{
    public class PatternStorage
    {
        public PatternStorage(Configuration configuration)
        {
            
        }


        class FilePatterns
        {
            public FilePatterns(List<SingleLineCommentPatternStorage> singleLinePatternStorages)
            {
                SingleLinePatternStorages = singleLinePatternStorages;
            }

            public List<SingleLineCommentPatternStorage> SingleLinePatternStorages { get; } = new List<SingleLineCommentPatternStorage>();
            private List<MultiLineCommentPatternStorage> MultiLinePatternStorages { get; } = new List<MultiLineCommentPatternStorage>();
        }

        class SingleLineCommentPatternStorage
        {
            public Regex SingleLineRegex { get; }

            public SingleLineCommentPatternStorage(string token)
            {
                SingleLineRegex = new Regex(@"^(\s)*" + token + @"(.)*$");
            }
        }

        class MultiLineCommentPatternStorage
        {
            public Regex MultiLineStartRegex { get; }

            public MultiLineCommentPatternStorage(string startToken, string endToken)
            {
                MultiLineStartRegex = new Regex(@"[^(hello)]*(start)");
            }
        }
    }
}