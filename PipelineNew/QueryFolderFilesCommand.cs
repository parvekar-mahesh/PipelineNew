using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    // Query Folder Files command
    public class QueryFolderFilesCommand : Command
    {
        private string folderPath;

        public QueryFolderFilesCommand(string folderPath)
        {
            this.folderPath = folderPath;
        }

        public override void Execute()
        {
            Console.WriteLine($"Querying files in folder '{folderPath}'...");

            DirectoryInfo place = new DirectoryInfo(folderPath);
            foreach (FileInfo file in place.GetFiles()) { Console.WriteLine(file.Name + ","); }
        }
    }
}
