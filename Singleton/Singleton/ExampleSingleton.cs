using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class ExampleSingleton
    {
        private int number;
        private static ExampleSingleton _uniqueInstance;
        private ExampleSingleton(int number)
        {
            this.number = number;
        }
        public static ExampleSingleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                var random = new Random();

                _uniqueInstance = new ExampleSingleton(random.Next(1, 4));
            }
            return _uniqueInstance;
        }

        public void SayNumberOfExample()
        {
            Console.WriteLine("This is " + number + " example of Singleton");
        }
    }
}
