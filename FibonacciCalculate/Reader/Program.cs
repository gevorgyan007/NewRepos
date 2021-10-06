using System;
using System.IO;
using System.Text;
using System.Threading;

namespace Reader
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (Mutex mutex = new Mutex(false, "MyMutexSync"))
            //{
            Mutex mutex = new Mutex(false, "MyMutexSync");
                mutex.WaitOne();
                Console.WriteLine("wait read");
                Stream stream = new FileStream("sendfile.txt", FileMode.OpenOrCreate, FileAccess.Read);
                var array = new byte[stream.Length];

                Console.WriteLine("Reading!!!!....");
                stream.Read(array, 0, array.Length);
                string utfString = Encoding.ASCII.GetString(array, 0, array.Length);

                Console.WriteLine(utfString);

                mutex.ReleaseMutex();
                stream.Close();
            //}
            Console.ReadKey();
        }
    }
}
