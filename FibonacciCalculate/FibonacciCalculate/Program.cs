using System;
using System.IO;
using System.Text;
using System.Threading;

namespace FibonacciCalculate
{
    class Program
    {
        static void Main(string[] args)
        {
            Mutex mutex = new Mutex(true, "MyMutexSync");
            
                mutex.WaitOne();

                Console.WriteLine("wait Write");
                Stream stream = new FileStream("sendfile.txt", FileMode.OpenOrCreate, FileAccess.Write);
                //StreamWriter writer = new StreamWriter("sendfile.txt", true);
                string s = Console.ReadLine();
                var array = Encoding.ASCII.GetBytes(s);
                stream.Write(array, 0, array.Length);
                stream.Close();
                //writer.WriteLine(s);
                
                mutex.ReleaseMutex();
            
        }
    }
}
