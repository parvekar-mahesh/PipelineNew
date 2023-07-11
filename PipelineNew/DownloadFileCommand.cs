using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    public class DownloadFileCommand : Command
    {
        private string sourceUrl;
        private string outputFile;

        public DownloadFileCommand(string sourceUrl, string outputFile)
        {
            this.sourceUrl = sourceUrl;
            this.outputFile = outputFile;
        }

        public override void Execute()
        {
            Console.WriteLine($"Downloading file from '{sourceUrl}' to '{outputFile}'...");
            
        }
    }
}
