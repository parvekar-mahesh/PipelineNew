using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    // Concrete Factory
    public class BasicCommandFactory : CommandFactory
    {
        public override Command CreateCommand(string commandType, List<string> parameters)
        {
            switch (commandType)
            {
                case "FileCopy":
                    //check number of params they must be 2 else throw error 
                    if (parameters.Count<2)
                    {
                        throw new ArgumentException($"Need atleast 2 parameters: {commandType}");
                    }
                    return new FileCopyCommand(parameters[0], parameters[1]);
                case "FileDelete":
                    return new FileDeleteCommand(parameters[0]);
                case "QueryFolderFiles":
                    return new QueryFolderFilesCommand(parameters[0]);
                case "CreateFolder":
                    return new CreateFolderCommand(parameters[0], parameters[1]);
                case "DownloadFile":
                    return new DownloadFileCommand(parameters[0], parameters[1]);
                case "Wait":
                    return new WaitCommand(int.Parse(parameters[0]));
                case "ConditionalCountRowsFile":
                    return new ConditionalCountRowsFileCommand(parameters[0], parameters[1]);
                default:
                    Console.ReadLine();
                    throw new ArgumentException($"Unknown command type: {commandType}");
            }
        }
    }
}
