using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PipelineNew
{
    public class WaitCommand : Command
    {
        private int waitTime;

        public WaitCommand(int waitTime)
        {
            this.waitTime = waitTime;
        }

        public override void Execute()
        {
            Console.WriteLine($"Waiting for {waitTime} seconds...");
            // Implementation code for waiting
        }
    }
}
