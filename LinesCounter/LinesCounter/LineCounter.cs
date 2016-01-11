using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace LinesCounter
{
    public class LineCounter : ILineCounter
    {
        private IEnumerable<string> Input { get; }
        private FileConfiguration Configuration { get; }

        private Regex whitespaceRegex = new Regex(@"(\s+)");

        public LineCounter(IEnumerable<string> input, FileConfiguration configuration)
        {
            Input = input;
            Configuration = configuration;
        }

        public Dictionary<LineType, int> countLines()
        {
            int sourceCodeLineCount = 0;
            int fullyCommentedLineCount = 0;
            int emptyLineCount = 0;


            var statistics = new Dictionary<LineType, int>();

            return statistics;
        }

        private LineType determineLineContent(string line, out bool isMultilineStarted, out bool isMultilineEnded)
        {

            return LineType.CODE;
        }
    }
}