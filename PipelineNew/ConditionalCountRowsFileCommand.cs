using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    public class ConditionalCountRowsFileCommand : Command
    {
        private string sourceFile;
        private string searchString;

        public ConditionalCountRowsFileCommand(string sourceFile, string searchString)
        {
            this.sourceFile = sourceFile;
            this.searchString = searchString;
        }

        public override void Execute()
        {
            Console.WriteLine($"Counting rows in file '{sourceFile}' that contain '{searchString}'...");
            string[] lines = File.ReadAllLines(sourceFile);
            int lineAsArray = lines.Count(s => s.Contains(searchString));
            int rowCount = lineAsArray;
            Console.WriteLine($" rows in file '{sourceFile}' contains '{rowCount}' that contain '{searchString}'");

        }
    }
}
