using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    // File Delete command
    public class FileDeleteCommand : Command
    {
        private string filePath;

        public FileDeleteCommand(string filePath)
        {
            this.filePath = filePath;
        }

        public override void Execute()
        {
            try
            {
                Console.WriteLine($"Deleting file '{filePath}'...");
                File.Delete(filePath);
            }
            catch (Exception ex )
            {

                Console.WriteLine($"error Deleting file '{filePath}'..." + ex.Message);
            }
       
        }
    }
}
