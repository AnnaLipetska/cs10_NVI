using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    // Реализуйте шаблон NVI в собственной иерархии наследования.
    class Breakfast
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

        protected virtual void Cook()
        {
            Console.WriteLine("Cooking breakfast");
        }

        protected virtual void Eat()
        {
            Console.WriteLine("Eating breakfast");
        }

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
            Breakfast breakfast = new Breakfast();
            Breakfast eng = new EnglishBreakfast();
            Breakfast cont = new ContinentalBreakfast();

            breakfast.Have();

            Console.WriteLine(new string('-', 40));

            eng.Have();

            Console.WriteLine(new string('-', 40));

            cont.Have();

            Console.ReadKey();
        }
    }
}
