using System.Collections;
using System.Collections.Generic;

namespace LinesCounter
{
    public class Configuration
    {
        public Dictionary<string, FileConfiguration> FileConfigurations { get; }

        public Configuration(Dictionary<string, FileConfiguration> fileConfigurations)
        {
            FileConfigurations = fileConfigurations;
        }

        public Configuration()
        {
        }
    }

    public class FileConfiguration
    {
        public List<OneLineComment> OneLineComments { get; }
        public List<MultiLineComment> MultiLineComments { get; }

        public FileConfiguration()
        {
        }

        public FileConfiguration(List<OneLineComment> oneLineComments, List<MultiLineComment> multiLineComments)
        {
            OneLineComments = oneLineComments;
            MultiLineComments = multiLineComments;
        }
    }

    public class OneLineComment
    {
        public string StartingToken { get; }

        public OneLineComment()
        {
        }

        public OneLineComment(string startingToken)
        {
            StartingToken = startingToken;
        }
    }

    public class MultiLineComment
    {
        public string StartingToken { get; }
        public string EndingToken { get; }

        public MultiLineComment()
        {
        }

        public MultiLineComment(string startingToken, string endingToken)
        {
            StartingToken = startingToken;
            EndingToken = endingToken;
        }
    }


}