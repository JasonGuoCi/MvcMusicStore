using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.Observer模式不使用委托
{
    public interface IObservable
    {
        void Register(IObserver obj); // 注册IObserver
        void Unregister(IObserver obj); // 取消IObserver的注册
    }
}
