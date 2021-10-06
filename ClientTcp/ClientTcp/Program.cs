using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace ClientTcp
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpClient client = new TcpClient("localhost",8080);
            Console.WriteLine("Connected to server!");
            NetworkStream networkStream = client.GetStream();
            StreamReader reader = new StreamReader(networkStream);
            StreamWriter writer = new StreamWriter(networkStream);
            string sendMsg = string.Empty;
            string msg = string.Empty;
            Thread thread =new Thread(()=> 
            {
                while (true)
                {
                    sendMsg = Console.ReadLine();
                    writer.WriteLine(sendMsg);
                    writer.Flush();
                    if (sendMsg.Equals("Exit") || msg.Equals("Exit"))
                    {
                        Thread.Sleep(5);
                        client.Close();
                        break;
                    }
                }
            });
            
            
            Thread thread1 = new Thread(() =>
            {
                while (true)
                {
                   msg = reader.ReadLine();
                    Console.WriteLine("Server:: " + msg);
                    if (sendMsg.Equals("Exit") || msg.Equals("Exit"))
                    {
                        Thread.Sleep(5);
                        client.Close();
                        break;
                    }
                }
            });
            thread.Start();
            thread1.Start();
            //while (true)
            //{
            //     sendMsg = Console.ReadLine();
            //    writer.WriteLine(sendMsg);
            //    writer.Flush();
            //    if (sendMsg.Equals("Exits"))
            //    {
            //        client.Close();
            //        break;
            //    }
            //    string msg = reader.ReadLine();
            //    Console.WriteLine("Server:: " + msg);
            //    if (msg.Equals("Exits"))
            //    {
            //        client.Close();
            //        break;
            //    }
            //}

            Console.ReadKey();
        }
    }
}
