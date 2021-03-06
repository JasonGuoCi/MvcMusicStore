﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.Observer模式不使用委托
{
    public class Heater2 : SubjectBase
    {
        private string type;
        private string area;
        private int temperature;

        public string Type
        {
            get { return type; }
        }

        public string Area
        {
            get
            {
                return area;
            }
        }
        // 新添属性 Temperature
        public int Temperature { get { return temperature; } }
        public Heater2(string type, string area)
        {
            this.type = type;
            this.area = area;
            this.temperature = 0;
        }

        public Heater2() : this("RealFile 001", "China Shanghai") { }

        // 供子类覆盖，以便子类拒绝被通知，或添加额外行为
        public virtual void OnBoiled()
        {
            //将本身传递过来
            base.Notify(this); //调用父类Notify()方法，进而调用所有注册了Observer的Update()方法
        }

        public void BoilWater()
        {
            for (int i = 0; i < 100; i++)
            {
                temperature = i + 1;
                if (temperature > 97)
                {
                    //BoiledEventArgs2 e = new BoiledEventArgs2(type, area, temperature);
                    OnBoiled();
                }
            }
        }
    }
}
