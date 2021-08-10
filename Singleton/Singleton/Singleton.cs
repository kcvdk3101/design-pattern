using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Singleton
    {
        private int number;
        private static Singleton _uniqueInstance;
        private Singleton(int number)
        {
            this.number = number;
        }
        public static Singleton GetInstance()
        {
            if (_uniqueInstance == null)
            {
                var random = new Random();

                _uniqueInstance = new Singleton(random.Next(1,4));
            }
            return _uniqueInstance;
        }

        public void SayCardId()
        {
            Console.WriteLine("I have a card with id is " + number);
        }
    }
}   
