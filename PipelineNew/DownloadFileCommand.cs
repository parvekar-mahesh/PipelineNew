using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            try
            {
                using (WebClient client = new WebClient())
                {
                    client.DownloadFile(sourceUrl,
                                        outputFile);
                }
                Console.WriteLine($"Downloading file from '{sourceUrl}' to '{outputFile}'...");
            }
            catch (Exception ex)
            {

                Console.WriteLine($" Error Downloading file from '{sourceUrl}' to '{outputFile}'..." + ex.Message); 
            }

            
        }
    }
}
