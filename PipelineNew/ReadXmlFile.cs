using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace PipelineNew
{
    internal class ReadXmlFile : IReadFile
    {
        private CommandFactory commandFactory;

    
        public string[] ReadFile(string path)
        {
            string[] lines = null;
            List<string> list = new List<string>();

            XmlDocument xmlDocument = new XmlDocument();
            xmlDocument.Load(path);

            XmlNodeList commandNodes = xmlDocument.SelectNodes("/Commands/*");

            foreach (XmlNode commandNode in commandNodes)
            {
                switch (commandNode.Name)
                {

                    case "FileCopy":
                        string sourcePath = commandNode.SelectSingleNode("SourcePath").InnerText;
                        string destinationPath = commandNode.SelectSingleNode("DestinationPath").InnerText;
                        list.Add("FileCopy" + "," + sourcePath + "," + destinationPath);
                        break;

                    case "FileDelete":
                        string filePath = commandNode.SelectSingleNode("FilePath").InnerText;
                        list.Add("FileDelete" + "," + filePath);
                        break;

                    case "QueryFolderFiles":
                        string folderPath = commandNode.SelectSingleNode("FolderPath").InnerText;
                        list.Add("QueryFolderFiles" + "," + folderPath);
                        break;

                    case "CreateFolder":
                        string folderPathCreate = commandNode.SelectSingleNode("FolderPath").InnerText;
                        string fileName = commandNode.SelectSingleNode("FileName").InnerText;
                        list.Add("CreateFolder" + "," + folderPathCreate + "," + fileName);
                        break;

                    case "Wait":
                        int durationInSeconds = int.Parse(commandNode.SelectSingleNode("DurationInSeconds").InnerText);
                        list.Add("Wait" + "," + durationInSeconds );
                        break;
                    case "ConditionalCountRowsFile":
                        string filePathCount = commandNode.SelectSingleNode("FilePath").InnerText;
                        string condition = commandNode.SelectSingleNode("Condition").InnerText;
                        list.Add("ConditionalCountRowsFile" + "," + filePathCount + "," + condition);
                        break;
                }
            }
            String[] str = list.ToArray();
            return str;
        }
    }
}
