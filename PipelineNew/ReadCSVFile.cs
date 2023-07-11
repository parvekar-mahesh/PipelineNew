using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    internal class ReadCSVFile : IReadFile
    {
        public string[] ReadFile(string filePath)
        {
            string[] lines = File.ReadAllLines(filePath);
            return lines; 
        }
    }
}
