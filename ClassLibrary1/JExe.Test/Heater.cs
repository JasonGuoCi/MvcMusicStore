using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test
{
    /// <summary>
    /// 热水器demo
    /// </summary>
    public class Heater
    {
        private int temperature;//水温

        //烧水
        public void BoilWater()
        {
            for (int i = 0; i < 100; i++)
            {
                temperature = i;
                if (temperature > 95)
                {
                    MakeAlert(temperature);
                    ShowMsg(temperature);
                }
            }
        }
        //显示温度
        private void ShowMsg(int para)
        {
            Console.WriteLine("Display：水快开了，当前温度：{0}度。", para);
        }
        /// <summary>
        ///发出警告
        /// </summary>
        /// <param name="para"></param>
        private void MakeAlert(int para)
        {
            Console.WriteLine("Alarm：嘀嘀嘀，水已经 {0} 度了：", para);
        }
    }
}
