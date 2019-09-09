using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            Pyramid ps = new Pyramid();
            Console.WriteLine("Please Enter Count");
            int inputCount = int.Parse(Console.ReadLine());
            ps.DisplayPyramid(inputCount);
            Console.WriteLine("-----------------------------------");
            Telephone telephone = new Telephone();
            telephone.answer();
            Telephone.HangUp();
            Console.ReadKey();
        }
    }
}
