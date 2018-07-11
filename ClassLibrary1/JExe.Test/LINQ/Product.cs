using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JExe.Test.LINQ
{
    public class Product
    {
        //
        public int Id { get; set; }//序号
        public string Code { get; set; }//产品编号
        public string Name { get; set; }//产品名称
        public string Category { get; set; }//产品分类
        public DateTime ProduceDate { get; set; }//生产日期
        public decimal Price { get; set; }//价格

        public override string ToString()
        {
            return string.Format("{0}{1}{2}{3}{4}{5}", this.Id.ToString().PadLeft(2), this.Category.PadLeft(15),
                                this.Code.PadLeft(7), this.Name.PadLeft(17), this.Price.ToString().PadLeft(4), this.ProduceDate.ToString("yyyy-M-d").PadLeft(13));
        }

        public static ProductCollection GetSampleCollection()
        {
            ProductCollection collection = new ProductCollection(
                            new Product { Id = 1, Code = "1001", Category = "Red Wine", Name = "Li Si", ProduceDate = new DateTime(10 / 07 / 2018), Price = 89 },
                            new Product { Id = 3, Code = "2001", Category = "White Spirit", Name = "Zhang San", ProduceDate = new DateTime(10 / 07 / 2018), Price = 89 },
                            new Product { Id = 4, Code = "2013", Category = "White Spirit", Name = "Li Si", ProduceDate = new DateTime(10 / 07 / 2018), Price = 89 },
                            new Product { Id = 8, Code = "3001", Category = "Beer", Name = "Li Si", ProduceDate = new DateTime(10 / 07 / 2018), Price = 89 },
                            new Product { Id = 11, Code = "1003", Category = "Red Wine", Name = "Li Si", ProduceDate = new DateTime(10 / 07 / 2018), Price = 89 },
                            new Product { Id = 15, Code = "1007", Category = "Red Wine", Name = "Li Si", ProduceDate = new DateTime(10 / 07 / 2018), Price = 89 },
                            new Product { Id = 17, Code = "3009", Category = "Beer", Name = "Li Si", ProduceDate = new DateTime(10 / 07 / 2018), Price = 89 }
                            );
            return collection;
        }
    }
}
