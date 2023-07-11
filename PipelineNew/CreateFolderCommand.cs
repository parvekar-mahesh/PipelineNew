using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    public class CreateFolderCommand : Command
    {
        private string folderPath;
        private string newFolderName;

        public CreateFolderCommand(string folderPath, string newFolderName)
        {
            this.folderPath = folderPath;
            this.newFolderName = newFolderName;
        }

        public override void Execute()
        {
            Console.WriteLine($"Creating folder '{newFolderName}' in path '{folderPath}'...");
            bool exists = System.IO.Directory.Exists(folderPath + "/" + newFolderName);

            if (!exists)
                System.IO.Directory.CreateDirectory(folderPath + "/" + newFolderName);
        }
    }
}
