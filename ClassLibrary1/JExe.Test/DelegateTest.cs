using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test
{
    public class DelegateTest
    {
        //public void GreetPeople(string name, GreetingDelegate MakeGreeting)
        //{
        //    MakeGreeting(name);
        //}
        public GreetingDelegate gd;

        public void GreetPeople(string name)
        {
            if (gd != null)
            {
                gd(name);
            }
        }
    }

    //定义委托，它定义了可以代表的方法的类型
    public delegate void GreetingDelegate(string name);

}
