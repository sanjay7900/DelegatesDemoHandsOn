using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesDemoHandsOn
{
    public delegate bool IsPrmote(Emp emp);
    public class Emp
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Exp { get; set; }
        public int salary { get; set; }
        public static void Prmotion(List<Emp> EmpList,IsPrmote isPrmote)
        {
            foreach(Emp emp in EmpList)
            {
                if (isPrmote(emp))
                {
                    Console.WriteLine("Prmote");
                }
            }

        }
        public static bool Prmote(Emp emp)
        {
            if (emp.Exp > 4)
            {
                return true;
            }
            return false;   
        }
    }
}
