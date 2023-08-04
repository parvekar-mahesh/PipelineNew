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
            this.waitTime = waitTime*1000;
        }

        public override void Execute()
        {
            Console.WriteLine($"Waiting for {waitTime} seconds...");
            System.Threading.Thread.Sleep( waitTime );
        }
    }
}
