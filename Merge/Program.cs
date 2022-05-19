using System;

namespace Merge
{
    public class Solution 
    {
        private static void Merge(int[] nums1, int m, int[] nums2, int n) 
        {
           for (int i = 0; i < n; i++)
           {
               nums1[i + m] = nums2[i];
           }
           int cur; 
           for(int j = nums1.Length - 1; j > 0; j--)
           {
               
               for(int k = 0; k < j; k ++ )
               {
                   if (nums1[j] > nums1[j + 1])
                   {
                     cur = nums1[j];
                     nums1[j] = nums1[j + 1];
                     nums1[j + 1] = cur;
                   
                   }
               }
           }
        }

        static void Main(string[] args)
        {
            string str1 = Console.ReadLine();
            int m = int.Parse(Console.ReadLine());
            string str2 = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            string[] arr1 = str1.Split(' ');
            string[] arr2 = str2.Split(' ');
            m = arr1.Length;
            n = arr2.Length;
            int[] nums1 = new int[m + n];
            int[] nums2 = new int[n];
            for(int i = 0; i < m; i++)
            {
                nums1[i] = Convert.ToInt32(arr1[i]);
            }
            for(int i = 0; i < n; i++)
            {
                nums2[i] = Convert.ToInt32(arr2[i]);
            }

            Merge(nums1, m, nums2, n);
            Console.WriteLine(nums1);


            
        }
    

    }
}
