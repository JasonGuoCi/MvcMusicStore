using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.Observer模式不使用委托
{
    class Screen : IObserver
    {
        private bool isDisplayedType = false;// 标记变量，标示是否已经打印过

        // Subject在事件发生时调用，通知Observer更新状态(通过Notify()方法)
        public void Update(IObservable obj)
        {
            //// 这里存在一个向下转换(由继承体系中高级别的类向低级别的类转换)
            Heater2 heater = (Heater2)obj;

            // 打印产地和型号，只打印一次
            if (!isDisplayedType)
            {
                Console.WriteLine("{0} - {1}: ", heater.Area, heater.Type);
                Console.WriteLine();
                isDisplayedType = true;
            }

            if (heater.Temperature < 100)
            {
                Console.WriteLine(
                        String.Format("Alarm".PadRight(7) + "：水快烧开了，当前温度：{0}", heater.Temperature));
            }
            else
            {
                Console.WriteLine(
                        String.Format("Alarm".PadRight(7) + "：水已经烧开了！！"));
            }
            //Console.WriteLine("Screen".PadRight(7) + ": 水快烧开了。");
        }
    }
}
