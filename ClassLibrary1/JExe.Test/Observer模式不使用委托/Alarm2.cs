using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.Observer模式不使用委托
{
    public class Alarm2 : IObserver
    {

        public void Update(IObservable obj)
        {
            Console.WriteLine("Alarm".PadRight(7) + "：嘟嘟嘟，水温快烧开了。");
        }
    }
}
