using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.Observer模式不使用委托
{
    public class BoiledEventArgs2
    {
        private int temperature;
        private string type;
        private string area;

        public BoiledEventArgs2(string type, string area, int temperature)
        {
            this.temperature = temperature;
            this.type = type;
            this.area = area;
        }

        public int Temperature { get { return temperature; } }
        public string Type { get { return type; } }
        public string Area { get { return area; } }
    }
}
