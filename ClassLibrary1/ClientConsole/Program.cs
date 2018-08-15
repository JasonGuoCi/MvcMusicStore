using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace ClientConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Client is running ...");
            TcpClient client = new TcpClient();
            try
            {
                // 与服务器建立连接
                client.Connect(IPAddress.Parse("192.168.1.7"), 8500);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            // 打印连接到的服务端信息
            Console.WriteLine("Server Connected! Local:{0} -->Server:{1}",
            client.Client.LocalEndPoint, client.Client.RemoteEndPoint);
            // 按Q退出
            ConsoleKey key;
            do
            {
                key = Console.ReadKey(true).Key;
            } while (key != ConsoleKey.Q);
        }
    }
}
