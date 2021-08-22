using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Multi threading
            var thread1 = new Thread(() => ExampleSingleton.GetInstance().SayNumberOfExample());
            var thread2 = new Thread(() => ExampleSingleton.GetInstance().SayNumberOfExample());

            thread1.Start();
            thread2.Start();


            //ExampleSingleton.GetInstance().SayNumberOfExample();

            Console.ReadKey();
        }
    }
}
