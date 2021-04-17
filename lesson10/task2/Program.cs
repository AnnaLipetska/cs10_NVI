using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    // Выучите описание шаблона Template method (Шаблонный метод). Обратите внимание на
    // применимость шаблона, а также на состав его участников и связи отношения между ними.
    // Напишите небольшую программу на языке C#, представляющую собой абстрактную
    // реализацию данного шаблона.

    abstract class Breakfast
    {
        public void Have()
        {
            Set();
            Cook();
            Eat();
            Clean();
        }

        private void Set()
        {
            Console.WriteLine("Setting the table");
        }

        protected abstract void Cook();

        protected abstract void Eat();

        private void Clean()
        {
            Console.WriteLine("Cleaning the table");
        }
    }

    class ContinentalBreakfast : Breakfast
    {
        protected override void Cook()
        {
            Console.WriteLine("Cooking continental breakfast");
        }

        protected override void Eat()
        {
            Console.WriteLine("Eating continental breakfast");
        }
    }

    class EnglishBreakfast : Breakfast
    {
        protected override void Cook()
        {
            Console.WriteLine("Cooking English breakfast");
        }

        protected override void Eat()
        {
            Console.WriteLine("Eating English breakfast");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Breakfast eng = new EnglishBreakfast();
            Breakfast cont = new ContinentalBreakfast();

            eng.Have();

            Console.WriteLine(new string('-', 40));

            cont.Have();

            Console.ReadKey();
        }
    }
}
