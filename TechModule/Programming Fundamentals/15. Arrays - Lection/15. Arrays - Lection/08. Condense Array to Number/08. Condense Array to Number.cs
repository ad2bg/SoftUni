﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.Condense_Array_to_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            

            while (nums.Length > 1)
            {
                int[] condensed = new int[nums.Length - 1];
                for (int i = 0; i < condensed.Length; i++)
                {
                    
                    condensed[i] = nums[i] + nums[i + 1];
                    
                }
                nums = condensed;
            }
            Console.WriteLine(string.Join(" ", nums));
        }
    }
}
