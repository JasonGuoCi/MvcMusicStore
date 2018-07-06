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


            ///Delegate test
            //DelegateTest gt = new DelegateTest();
            //gt.GreetPeople("Jason", EnglingGreeting);
            //gt.GreetPeople("小小", ChineseGreeting);
            //GreetingDelegate gd;
            //gd = EnglingGreeting;
            //gd += ChineseGreeting;
            //gt.gd = EnglingGreeting;
            //gt.gd += ChineseGreeting;
            //gt.GreetPeople("Jason", gt.gd);
            //gt.GreetPeople("jason");

            Heater heater = new Heater();

            Alarm alarm = new Alarm();
            //heater.BoilEvent += alarm.MakeAlert;
            //heater.BoilEvent += (new Alarm()).MakeAlert;
            //heater.BoilEvent += Display.ShowMsg;

            heater.Boiled += alarm.MakeAlert;
            heater.Boiled += (new Alarm()).MakeAlert;
            heater.Boiled += new Heater.BoiledEventHandler(alarm.MakeAlert);
            //也可以这么注册

            heater.Boiled += Display.ShowMsg;
            heater.BoilWater();

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
