using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsExercise
{
    public class MathMethods
    {
        public static int Sum(int[] nums)
        {
            int value = 0;
            foreach (int i in nums)
            {
                value += i;
            }
            return value;
        }

        public static int Subtract(int[] nums)
        {
            int value = 0;
            foreach (int i in nums)
            {
                value -= i;
            }
            return value;
        }

        public static int Multiply(int[] nums)
        {
            int value = 1;
            foreach (int i in nums)
            {
                value *= i;
            }
            return value;
        }
        public static decimal Divide(int[] nums)
        {
            int value = 0;
            foreach (int i in nums)
            {
                value /= i;
            }
            return value;
        }

        
    }
}
