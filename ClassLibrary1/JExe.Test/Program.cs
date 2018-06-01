using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            //string str = Question.ConcatStr();
            //int[] intArray = Question.ConcatIntArray();
            //Console.WriteLine(intArray.Length);
            //for (int i = 0; i < intArray.Length; i++)
            //{
            //    Console.WriteLine(intArray[i]);
            //}
            //Console.Write(str);

            //B b = new B();
            GetFlag(3);
            Console.ReadKey();
        }

        private static bool GetFlag(int num)
        {
            if (num < 1) return false;
            return (num & num - 1) == 0;
        }
    }
}
