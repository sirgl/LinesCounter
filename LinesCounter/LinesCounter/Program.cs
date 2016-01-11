using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using CommandLine;
using CommandLine.Text;

namespace LinesCounter
{
    class Options
    {
        [Option('r', Required = false, HelpText = "Regex for file name.")]
        public string Regex { get; set; }

        [Option('c', "config", Required = false, HelpText = "Path to configuration file.")]
        public string ConfigFilePath { get; set; }

    }

    class Program
    {
        static void Main(string[] args)
        {
            var options = new Options();
            var result = CommandLine.Parser.Default.ParseArguments(args, options);
            if (options.Regex != null)
            {
                
            }
        }
    }
}
