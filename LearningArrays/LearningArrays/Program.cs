using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningArrays
{
    class Program
    {
        static void Main(string[] args)
        {
            
                string[] s1 = { "Element1", "Element2", "Element3", "Element4", "Element5" };
                for (int i = 0; i < s1.Length; i++)
                {
                    Console.WriteLine(s1[i]
                    );
                }

                int[] s2 = new int[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
                for (int i = 0; i < s2.Length / 2; i++)
                {

                    int tmp = s2[i];
                    s2[i] = s2[s2.Length - i - 1]
                ;
                    s2[s2.Length - i - 1] = tmp;
                }
                {
                    Console.WriteLine(string.Join(",", s2));
                }

            }
        }
}
