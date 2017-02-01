using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection1
{
    class Program
    {
        static void Main(string[] args)
        {
            Increment inc = new Increment();                              // Создание зависимости
            ConstructorInjection ci = new ConstructorInjection(10, inc);  // Инъекция зависимости через конструктор
            ci.SomeOperation();
            Console.WriteLine(ci.Result);
            Console.ReadLine();
        }
    }
}
