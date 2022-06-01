using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemoHandsOn
{
    public delegate void MyOperations(int a, int b);

    internal class DelegateExamples
    {
        public void Addition(int a, int b)
        {
            Console.WriteLine(a + b);

        }
        public void Subtraction(int a, int b)
        {

            Console.WriteLine(a - b);
        }
    }
}
