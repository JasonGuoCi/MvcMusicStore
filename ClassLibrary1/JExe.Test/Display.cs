using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test
{
    public class Display
    {
        ////显示温度
        public static void ShowMsg(int para)
        {
            Console.WriteLine("Display：水快开了，当前温度：{0}度。", para);
        }
    }
}
