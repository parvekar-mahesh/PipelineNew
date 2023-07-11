using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    internal interface IReadFile
    {
        string[] ReadFile(string path);
    }
}
