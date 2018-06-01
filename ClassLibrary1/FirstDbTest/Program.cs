using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstDbTest
{
    class Program
    {
        static void Main(string[] args)
        {
            string dataDir = AppDomain.CurrentDomain.BaseDirectory;
            if (dataDir.EndsWith(@"\bin\Debug\")
                || dataDir.EndsWith(@"\bin\Release\"))
            {
                dataDir = System.IO.Directory.GetParent(dataDir).Parent.Parent.FullName;
                AppDomain.CurrentDomain.SetData("DataDirectory", dataDir);
            }

            Console.WriteLine("请输入用户名");
            string userName = Console.ReadLine();
            Console.WriteLine("请输入密码");
            string password = Console.ReadLine();

            using (SqlConnection conn = new SqlConnection(@"Data Source=.\data4media;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True;User Instance=True"))
            {
                conn.Open();
                Console.WriteLine("连接打开");
                using (SqlCommand com = conn.CreateCommand())
                {
                    com.CommandText = "Insert into T_Users(UserName,Password) values('" + userName + "','" + password + "')";
                    com.ExecuteNonQuery();
                    Console.WriteLine("插入成功");
                }
            }

            Console.ReadKey();

        }
    }
}
