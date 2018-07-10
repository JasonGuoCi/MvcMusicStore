using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.LINQ
{
    public class ProductCollection
    {
        private List<Product> list = new List<Product>();

        private Hashtable table;
        public ProductCollection()
        {
            table = new Hashtable();
        }
        public ProductCollection(params Product[] products)
        {
            table = new Hashtable();
            foreach (Product product in products)
            {
                this.Add(product);
            }
        }
        // 索引器，以支持类似于 collection[index] 这样的访问
        //public Product this[int index]
        //{
        //    get; set;
        //}
        // 索引器，以支持类似于 collection[key] 这样的访问
        //public Product this[string key]
        //{
        //    get; set;
        //}

        // 在末尾添加成员
        public void Add(Product item) { }
        // 在任意位置添加成员
        public void Insert(int index, Product item) { }

        // 移除某一成员
        public bool Remove(Product item)
        {
            return true;
        }

        public bool RemoveAt(int index)
        {
            return true;
        }
        // 清除所有成员
        public void Clear()
        {
            table = new Hashtable();
        }
        // 获得集合的成员数量
        public int Count
        {
            get;
        }
    }
}
