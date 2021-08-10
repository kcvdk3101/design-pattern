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
            var thread1 = new Thread(() => Singleton.GetInstance().SayCardId());
            var thread2 = new Thread(() => Singleton.GetInstance().SayCardId());

            thread1.Start();
            thread2.Start();


            //Singleton.GetInstance().SayCardId();
            
            Console.ReadKey();
        }
    }
}
