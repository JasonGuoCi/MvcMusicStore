using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.Observer模式不使用委托
{
    class Screen : IObserver
    {
        // Subject在事件发生时调用，通知Observer更新状态(通过Notify()方法)
        public void Update()
        {
            Console.WriteLine("Screen".PadRight(7) + ": 水快烧开了。");
        }
    }
}
