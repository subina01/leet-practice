// See https://aka.ms/new-console-template for more information
// See https://aka.ms/new-console-template for more information

/*You are given two integer arrays nums1 and nums2, sorted in 
non-decreasing order, and two integers m and n, representing the 
number of elements in nums1 and nums2 respectively.

Merge nums1 and nums2 into a single array sorted in non-decreasing
 order.

The final sorted array should not be returned by the function, 
but instead be stored inside the array nums1. To accommodate this,
 nums1 has a length of m + n, where the first m elements denote the
elements that should be merged, and the last n elements are set to
 0 and should be ignored. nums2 has a length of n*/


public class Progarm
{
    public static void MergeSortedArray(int[] num3, int[] num4)
    {
        Console.WriteLine("The elements in sorted order in the first array");
        for (int i = 0; i < num3.Length; i++)
        {
            Console.WriteLine(num3[i]);
        }
        Console.WriteLine("The elements in sorted order in the Second array");
        for (int i = 0; i < num4.Length; i++)
        {
            Console.WriteLine(num4[i]);
        }
        int[] arr = new int[num3.Length];
        int a = 0, b = 0;   
        int c = num3.Length - num4.Length;
        while(a < num3.Length && b < num4.Length)
        {
          if (num3[a] < num4[b] && a < c)
            {
                arr[a] = num3[a];
                a++;
            }
          else {
                arr[a] = num4[b];
                a++;
                b++;
            }
        }

        
        for(int i = 0;i < num3.Length;i++)
        {
            num3[i] = arr[i];
        }

        Console.WriteLine("The array values in num 1 are:");
        foreach(int i in num3) {
            Console.WriteLine(i);
        }
    }
    public static void Main(string[] args)
    {
        int m, n;
        Console.WriteLine("enter the size of array num1 and num2:");
        m = int.Parse(Console.ReadLine());
        n = int.Parse(Console.ReadLine());
        int[] num1 = new int[m + n];
        int[] num2 = new int[n];
        Console.WriteLine("the size of num1 is"+num1.Length);
        Console.WriteLine("the size of num2 is" + num2.Length);
        Console.WriteLine("Enter the elements in sorted order in the first array");
        for (int i = 0; i < num1.Length; i++)
        {
            num1[i] =int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Enter the elements in sorted order in the Second array");
        for (int i = 0; i < num2.Length; i++)
        {
            num2[i] = int.Parse(Console.ReadLine());
        }
        

         MergeSortedArray(num1, num2);
    }
}
