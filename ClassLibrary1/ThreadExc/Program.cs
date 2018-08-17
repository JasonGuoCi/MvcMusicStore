using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadExc
{
    class Program
    {
        static void Main(string[] args)
        {
            ThreadStart ts = new ThreadStart(ThreadEntity);
            Thread worker = new Thread(ts);
            worker.Start();
            Console.WriteLine("Main Thread end"); ;
            Console.ReadKey();
        }

        static void ThreadEntity()
        {

            Console.WriteLine("thread end");
        }
    }
}
