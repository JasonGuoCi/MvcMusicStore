using System;
using System.Collections;
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
            //GetFlag(3);
            //ArrayList al = new ArrayList();
            //int i = 10;
            //al.Add(i);
            //string l = (string)al[0];

            DelegateTest gt = new DelegateTest();
            gt.GreetPeople("Jason", EnglingGreeting);
            gt.GreetPeople("小小", ChineseGreeting);
            Console.ReadKey();
        }

        private static bool GetFlag(int num)
        {
            if (num < 1) return false;
            return (num & num - 1) == 0;
        }

        private static void EnglingGreeting(string name)
        {
            Console.Write("Hello " + name);
        }

        private static void ChineseGreeting(string name)
        {
            Console.Write("你好 " + name);
        }
    }
}
