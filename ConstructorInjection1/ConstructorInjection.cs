using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorInjection1
{
    class ConstructorInjection
    {
        public int Argument { get; set; }
        public int Result { get; set; }
        private IOperation operation;

        public ConstructorInjection(int argument, IOperation operation) // Инъекция через конструктор
        {
            Argument = argument;
            this.operation = operation;
        }

        public void SomeOperation()
        {
            Result = operation.DoOperation(Argument);
        }
    }
}
