using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyContinuousWebJob
{
    // To learn more about Microsoft Azure WebJobs, please see http://go.microsoft.com/fwlink/?LinkID=401557
    class Program
    {
        static void Main()
        {
            for (; ; )
            {
                Console.WriteLine("It's {0}", DateTime.Now);
                Thread.Sleep(5000);
            }
        }
    }
}
