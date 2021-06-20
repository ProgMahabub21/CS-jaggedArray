using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Result
    {
        public Result(int[][] section)
        {
            int sum, totalsum = 0;
            int i = 0, k;
            float avg ;
            while(i <3)
            {
                k = 0;
                sum = 0;
                while(k< section[i].Length)
                {
                    sum += section[i][k];
                    k++;
                }
                totalsum += sum;
                Console.Write("Student Serial {0}", i);
                Console.WriteLine(" Total marks {0}",sum);
                i++;
            }
            Console.WriteLine("Total Marks of all Students {0}", totalsum);
            avg = (totalsum / 6);
            Console.WriteLine("Avg marks of students each course for the section {0}",avg );
        }
    }
}
