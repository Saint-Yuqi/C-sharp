using System;
using System.Collections.Generic; // to invoke the Dictionary! It's important.

namespace Roman
{
    class Solution
    {
        static int RomanToInt(string s)
        {
            Dictionary<char, int> r = new Dictionary<char, int>();
	        r.Add('I',1);
	        r.Add('V',5);
	        r.Add('X',10);
	        r.Add('L',50);
	        r.Add('C',100);
	        r.Add('D',500);
	        r.Add('M',1000);           
            int integer = 0;
            int later = 0;
            // I want to transfer from left to right , 
            // "XLIII" = X L I I I  we know X < L , if later > current our integer should substract the current value. 
            // so at first  1 + 1 + 1 + 50 - 10 
            for (int i = s.Length - 1; i >= 0; i--)
            {
                int current = r[ s[i] ];
                if (current >= later)
                {
                    integer = integer + current;
                }
                else
                {
                    integer = integer - current;
                }
                later = current;
            }
            return integer;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            int x = RomanToInt(s);
            Console.WriteLine(x);
        }
    }
}
