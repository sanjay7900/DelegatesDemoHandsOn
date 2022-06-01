using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemoHandsOn
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DelegateExamples delegateExamples = new DelegateExamples(); 
            MyOperations myOperations=new MyOperations(delegateExamples.Addition);
            myOperations+=new MyOperations(delegateExamples.Subtraction);
            myOperations(2, 9);
            Console.WriteLine("============================");
            List<Emp> emps = new List<Emp>
            {
                new Emp{Id =1, Name ="sanjay",Exp=3,salary=20000},
                new Emp{Id =2, Name ="Rahul",Exp=4,salary=25000},
                new Emp{Id =3, Name ="Lalit",Exp=2,salary=120000},
                new Emp{Id =4, Name ="Gopal",Exp=5,salary=220000},
            };
            IsPrmote isPrmote = new IsPrmote(Emp.Prmote);
            //isPrmote()
            Emp.Prmotion(emps, isPrmote);
            Console.ReadKey();  
        }
    }
}
