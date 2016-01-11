using System.Collections.Generic;

namespace LinesCounter
{
    public interface IConfigurationProvider
    {
        Configuration GetConfiguration();
    }

    class DefaultConfigurationProvider : IConfigurationProvider
    {
        public Configuration GetConfiguration()
        {
            var oneLineComment = new OneLineComment("//");
            var multiLineComment = new MultiLineComment("/*", "*/");
            List<OneLineComment> oneLineComments = new List<OneLineComment>();
            oneLineComments.Add(oneLineComment);
            List<MultiLineComment> multiLineComments = new List<MultiLineComment>();
            multiLineComments.Add(multiLineComment);
            var fileConfiguration = new FileConfiguration(oneLineComments, multiLineComments);
            var fileConfigurations = new Dictionary<string, FileConfiguration>();
            fileConfigurations["cs"] = fileConfiguration;
            return new Configuration(fileConfigurations);
        }
    }
}