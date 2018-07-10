using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.Observer模式不使用委托
{
    public interface IObserver
    {
        void Update(IObservable sender);// 事件触发时由Subject调用，更新自身状态
    }
}
