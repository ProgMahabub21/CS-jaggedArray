using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] section = new int[3][];
            section[0] = new int[2];
            section[1] = new int[3]; 
            section[2] = new int[1];
            int i =0,r;
            while(i<3)
            {
                r = 0;
                while(r<section[i].Length)
                {
                   int marks= Convert.ToInt32(Console.ReadLine());
                    if (marks > 100)
                    {
                        Console.WriteLine("Marks Cant be over 100");
                        marks = Convert.ToInt32(Console.ReadLine());
                        section[i][r] = marks;
                    }
                    else
                        section[i][r] = marks;
                   r++;
                }
                i++;  
            }
            Result obj1 = new Result(section);
             //  Result object1 = new Result(section);
        }
    }
}
