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
        public string type = "RealFile 001";//增加型号
        public string area = "China Shanghai";//增加地区

        //public delegate void BoilHandler(int parm);//声明委托
        //public event BoilHandler BoilEvent;//声明事件

        //声明委托
        public delegate void BoiledEventHandler(Object sender, BoiledEventArgs args);
        public event BoiledEventHandler Boiled;//声明事件

        // 可以供继承自 Heater 的类重写，以便继承类拒绝其他对象对它的监视
        protected virtual void OnBoiled(BoiledEventArgs e)
        {
            if (Boiled != null)
            {
                Boiled(this, e);// 调用所有注册对象的方法
            }
        }



        //烧水
        public void BoilWater()
        {
            for (int i = 0; i < 100; i++)
            {
                temperature = i;
                if (temperature > 95)
                {
                    //建立BoiledEventArgs 对象
                    BoiledEventArgs e = new BoiledEventArgs(temperature);
                    OnBoiled(e);// 调用 OnBolied方法


                    //if (BoilEvent != null)//如果有对象注册
                    //{
                    //    BoilEvent(temperature);//调用注册的对象
                    //}
                    // MakeAlert(temperature);
                    //ShowMsg(temperature);
                }
            }
        }
        ////显示温度
        //private void ShowMsg(int para)
        //{
        //    Console.WriteLine("Display：水快开了，当前温度：{0}度。", para);
        //}
        ///// <summary>
        /////发出警告
        ///// </summary>
        ///// <param name="para"></param>
        //private void MakeAlert(int para)
        //{
        //    Console.WriteLine("Alarm：嘀嘀嘀，水已经 {0} 度了：", para);
        //}
    }
}
