using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test
{
    /// <summary>
    /// 显示器
    /// </summary>
    public class Display
    {
        ////显示温度
        //public static void ShowMsg(int para)
        //{
        //    Console.WriteLine("Display：水快开了，当前温度：{0}度。", para);
        //}
        public static void ShowMsg(Object sender, BoiledEventArgs e)
        {
            Heater heater = (Heater)sender;
            Console.WriteLine("Display：{0} - {1}: ", heater.area, heater.type);
            Console.WriteLine("Display：水快烧开了，当前温度：{0}度。", e.temperature);
            Console.WriteLine();
        }
    }
}
