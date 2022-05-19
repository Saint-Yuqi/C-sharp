using System;

namespace Palindrome
{
    class Program
    {
        static bool IsPalindrome(int x)
        {
                
            if (x < 0 || x % 10 == 0)
            {
                return false;
            }
            if (x < 10)
            {
                return true;
            }
            
            var y = Convert.ToString(x);
            var len = y.Length;
            for(int i = 0; i < len/2; i++)
            {
                if(y[i] != y[len - 1 - i])
                {
                    return false;
                }
            }
            return true;
        }                
             
       
        static void Main(string[] args)
        { 
            int x = int.Parse(Console.ReadLine());
            
            if (IsPalindrome(x) == true)
            {
                Console.WriteLine("true");
            }
        }
        
    }
}

