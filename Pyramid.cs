using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pyramid
{
    class Pyramid
    {
        public void DisplayPyramid(int countHeight)
        {
            for(int level=1;level<=countHeight;level = level + 2)
            {
                string text = string.Join(" ", Enumerable.Repeat("*", level));
                Console.WriteLine(text.PadLeft(countHeight - level + text.Length));
            }
            for(int level = countHeight-2;level>0;level = level - 2)
            {
                string text = string.Join(" ", Enumerable.Repeat("*", level));
                Console.WriteLine(text.PadLeft(countHeight - level + text.Length));
            }
        }
    }
}
