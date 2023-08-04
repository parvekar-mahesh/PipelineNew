using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    using System;
    using System.Collections.Generic;



    // File Copy command
    public class FileCopyCommand : Command
    {
        private string sourceFile;
        private string destinationFile;

        public FileCopyCommand(string sourceFile, string destinationFile)
        {
            this.sourceFile = sourceFile;
            this.destinationFile = destinationFile;
        }

        public override void Execute()
        {
            try
            {
                File.Copy(sourceFile, destinationFile, true);
                Console.WriteLine($"Copying file from '{sourceFile}' to '{destinationFile}'");
            }
            catch (Exception ex)
            {

                Console.WriteLine($"Error Occured -"+ ex.Message );
            }
           
        }
    }

 


   
 


   

}
