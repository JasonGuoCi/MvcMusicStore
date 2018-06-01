using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test
{
    public class Question
    {
        /// <summary>
        /// 一个长度为10000的字符串，通过随机从a-z中抽取10000个字符组成。请用c＃语言编写主要程序来实现。
        /// </summary>
        /// <param name="str"></param>
        public static string ConcatStr()
        {
            //定义a~z的字符串
            string str = "a,b,c,d,e,f,g,h,i,j,k,l,m,n,o,p,q,r,s,t,u,v,w,x,y,z";
            string[] strArray = str.Split(',');
            int strArrLength = strArray.Length;

            StringBuilder sb = new StringBuilder(0, 10000);
            //string str2 = "";
            //随机
            Random rd = new Random();
            for (int i = 0; i < 10000; i++)
            {
                sb.Append(strArray[rd.Next(strArrLength)]);
                //str2 += strArray[rd.Next(strArrLength)];
            }

            return sb.ToString();
        }

        /// <summary>
        ///   //产生一个int数组，长度为100，并向其中随机插入1-100，并且不能重复。
        /// </summary>
        /// <returns></returns>
        public static int[] ConcatIntArray()
        {
            int[] intArray = new int[100];
            ArrayList al = new ArrayList();
            Random rd = new Random();

            while (al.Count < 100)
            {
                int num = rd.Next(1, 101);
                if (!al.Contains(num))
                {
                    al.Add(num);
                }
            }
            for (int i = 0; i < 100; i++)
            {
                intArray[i] = (int)al[i];
            }
            return intArray;
        }

        //用C#写一段选择排序算法，要求用自己的编程风格。
        /// <summary>
        /// 选择排序（Selection sort）是一种简单直观的排序算法。
        /// 它的工作原理是每一次从待排序的数据元素中选出最小（或最大）的一个元素，
        /// 存放在序列的起始位置，直到全部待排序的数据元素排完。 ‘
        /// 选择排序是不稳定的排序方法（比如序列[5， 5， 3]第一次就将第一个[5]与[3]交换，
        /// 导致第一个5挪动到第二个5后面）。
        /// </summary>
        /// <param name="list"></param>
        public static int[] xuanZePaiXun(int[] list)
        {
            //设置索引值
            int min;
            for (int i = 0; i < list.Length - 1; i++)
            {
                min = i;

                for (int j = i + 1; j < list.Length; j++)
                {
                    if (list[j] < list[min])
                    {
                        min = j;
                    }
                }

                int num = list[min];
                list[min] = list[i];
                list[i] = num;
            }
            return list;
        }

        //写一个函数计算当参数为N的值:1-2+3-4+5-6+7……+N

        public static int Counter(int n)
        {
            int sum = 0;
            for (int i = 1; i <= n; i++)
            {
                int k = i;
                if (i % 2 == 0)
                {
                    k = -k;
                }
                sum = sum + k;
            }
            return sum;
        }



    }

    //class A
    //{
    //    public A()
    //    {
    //        PrintFields();
    //    }
    //    public virtual void PrintFields() { }
    //}
    //class B : A
    //{
    //    int x = 1;
    //    int y;
    //    public B()
    //    {
    //        y = -1;

    //    }
    //    public override void PrintFields()
    //    {
    //        Console.WriteLine("x ={0},y ={1}", x, y);
    //    }

    //}
    //class A
    //{

    //    public static int X;

    //    static A()
    //    {

    //        X = B.Y + 1;

    //    }

    //}

    //class B
    //{

    //    public static int Y = A.X + 1;

    //    static B() { }

    //    static void Main()
    //    {

    //        Console.WriteLine("X ={0},Y ={1}", A.X, B.Y);

    //    }

    //}
}
