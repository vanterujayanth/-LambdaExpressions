using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambdaExpressions
{
    public class LambdaExperssion_Demo
    {
        List<int> Numbers = new List<int>()
        { 1, 3, 4,  5, 6, 7, 8, 9 };
        public LambdaExperssion_Demo()
        {
            Console.Write("the list of elements : ");
            Console.Write("The list : ");
            foreach (var value in Numbers)
            {
                Console.Write("{0} ", value);   // for printing
            }
            Console.WriteLine();
            List<int> Square = Numbers.Select(x => x * x).ToList();
            Console.Write("the Square of the numbers in list : ");
            foreach (var value in Square)
            {
                Console.Write("{0} ", value);   // for printing
            }
            Console.WriteLine();
            List<int> DivBy3 = Square.FindAll(x => (x % 3) == 0);
            Console.Write("numbers divisiable by 3 :");
            foreach (var value in DivBy3)
            {
                Console.Write("{0} ", value);   // for printing
            }
        }
    }
}
