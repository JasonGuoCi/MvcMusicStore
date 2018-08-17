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
            // ThreadStart ts = new ThreadStart(ThreadEntity);
            ParameterizedThreadStart pts = new ParameterizedThreadStart(ThreadEntity);
            string test = "test with parameter";
            Thread worker = new Thread(pts);
            worker.Start(test);
            Console.WriteLine("Main Thread end"); ;
            Console.ReadKey();
        }

        static void ThreadEntity()
        {

            Console.WriteLine("thread end");
        }
        static void ThreadEntity(object o)
        {
            string test = (string)o;
            Console.WriteLine("thread end " + test);
        }
    }
}
