using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.Observer模式不使用委托
{
    public abstract class SubjectBase : IObservable
    {
        // 使用一个 List<T>作为 IObserver 引用的容器
        private List<IObserver> container = new List<IObserver>();
        public void Register(IObserver obj)
        {
            container.Add(obj);
        }

        public void Unregister(IObserver obj)
        {
            container.Remove(obj);
        }

        // 通知所有注册了的Observer
        protected virtual void Notify()
        {
            foreach (IObserver observer in container)
            {
                observer.Update();// 调用Observer的Update()}

            }
        }
    }
}
