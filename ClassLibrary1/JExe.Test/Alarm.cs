using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test
{
    /// <summary>
    /// 警报器
    /// </summary>
    public class Alarm
    {
        //发出警告
        //public void MakeAlert(int para)
        //{
        //    Console.WriteLine("Alarm：水快开了，当前温度：{0}度。", para);
        //}
        public void MakeAlert(Object sender, BoiledEventArgs e)
        {
            Heater heater = (Heater)sender;
            Console.WriteLine("Alarm：{0} - {1}: ", heater.area, heater.type);
            Console.WriteLine("Alarm: 嘀嘀嘀，水已经 {0} 度了：", e.temperature);
            Console.WriteLine();
        }
    }
}
