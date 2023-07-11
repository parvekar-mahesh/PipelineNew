using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PipelineNew
{
   

    public class Application
    {
        private CommandFactory commandFactory;

        public Application(CommandFactory commandFactory)
        {
            this.commandFactory = commandFactory;
        }

        public void ExecuteCommandsFromFile(string filePath)
        {
            IReadFile file = null;
            string extension = filePath.Substring(filePath.LastIndexOf('.'), 4);
            if (extension== "txt")
            {
                file = new ReadCSVFile();
            }
            else { file= new ReadXmlFile(); }

            string[] lines= file.ReadFile(filePath);

            foreach (string line in lines)
            {
                string[] parts = line.Split(',');
                string commandType = parts[0].Trim();
                List<string> parameters = new List<string>();

                for (int i = 1; i < parts.Length; i++)
                {
                    parameters.Add(parts[i].Trim());
                }

                Command command = commandFactory.CreateCommand(commandType, parameters);
                command.Execute();
            }
        }
    }

}
