using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test
{
    public class Alarm
    {
        //发出警告
        public void MakeAlert(int para)
        {
            Console.WriteLine("Alarm：水快开了，当前温度：{0}度。", para);
        }
    }
}
