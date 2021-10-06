using System;
using System.IO;
using System.Net.Sockets;
using System.Threading;

namespace ServerTcp
{
    class Program
    {
        static void Main(string[] args)
        {
            TcpListener tcpListener = new TcpListener(8080);
            tcpListener.Start();
            Socket serverSocket = tcpListener.AcceptSocket();
            StreamReader reader = default;
            StreamWriter writer = default;
            if (serverSocket.Connected)
            {
                Console.WriteLine("Client connected!");
                NetworkStream networkStream = new NetworkStream(serverSocket);
                reader = new StreamReader(networkStream);
                writer = new StreamWriter(networkStream);
            }
            string sendMsg = string.Empty;
            string msg = string.Empty;
            Thread thread = new Thread(() =>
            {
                while (true)
                {
                    sendMsg = Console.ReadLine();
                    writer.WriteLine(sendMsg);
                    writer.Flush();
                    if (sendMsg.Equals("Exit") || msg.Equals("Exit"))
                    {
                        tcpListener.Stop();
                        serverSocket.Close();
                        break;
                    }
                }
            });
            Thread thread1 = new Thread(() =>
            {
                while (true)
                {
                    msg = reader.ReadLine();
                    Console.WriteLine("Client:: " + msg);
                    if (sendMsg.Equals("Exit") || msg.Equals("Exit"))
                    {
                        Thread.Sleep(5);
                        serverSocket.Close();
                        tcpListener.Stop();
                        break;
                    }
                    double number = double.Parse(msg);
                    double nrdFIb = CalcFib.Fib(number);
                    Console.WriteLine($"{number}-th fib number :: " + nrdFIb);
                }
            });
            thread.Start();
            thread1.Start();
            //while (true)
            //{
            //    string msg = reader.ReadLine();
            //    Console.WriteLine("Client:: " + msg);
            //    if (msg.Equals("Exits"))
            //    {
            //        tcpListener.Stop();
            //        break;
            //    }
            //    string sendMsg = Console.ReadLine();
            //    writer.WriteLine(sendMsg);
            //    writer.Flush();
            //    if (sendMsg.Equals("Exits"))
            //    {
            //        tcpListener.Stop();
            //        break;
            //    }
            //}
            Console.ReadKey();
        }
    }
}
