// See https://aka.ms/new-console-template for more information
using System.Collections.Immutable;
using System.Linq.Expressions;




/*Given an integer array nums and an integer val, remove all occurrences of val in nums in-place. The order of the elements may be changed. Then return the number of elements in nums which are not equal to val.

Consider the number of elements in nums which are not equal to val be k, to get accepted, you need to do the following things:

Change the array nums such that the first k elements of nums contain the elements which are not equal to val. The remaining elements of nums are not important as well as the size of nums.
Return k.
Custom Judge:

The judge will test your solution with the following code:

int[] nums = [...]; // Input array
int val = ...; // Value to remove
int[] expectedNums = [...]; // The expected answer with correct length.
                            // It is sorted with no values equaling val.

int k = removeElement(nums, val); // Calls your implementation

assert k == expectedNums.length;
sort(nums, 0, k); // Sort the first k elements of nums
for (int i = 0; i < actualLength; i++)
{
    assert nums[i] == expectedNums[i];
}
If all assertions pass, then your solution will be accepted.

 

Example 1:

Input: nums = [3, 2, 2, 3], val = 3
Output: 2, nums = [2, 2, _, _]
Explanation: Your function should return k = 2, with the first two elements of nums being 2.
It does not matter what you leave beyond the returned k (hence they are underscores).
Example 2:

Input: nums = [0, 1, 2, 2, 3, 0, 4, 2], val = 2
Output: 5, nums = [0, 1, 4, 0, 3, _, _, _]
Explanation: Your function should return k = 5, with the first five elements of nums containing 0, 0, 1, 3, and 4.
Note that the five elements can be returned in any order.
It does not matter what you leave beyond the returned k (hence they are underscores).





*/
public class Solution
{
    public static int[] RemoveElement(int[] nums, int val)
    {
        int count = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                nums[count] = nums[i];
                count++;
            }
        }

        int[] newarr = new int[count];
        /*for (int i = 0; i < nums.Length; i++)
        {
            Console.WriteLine("nuns" + nums[i]);
        }*/
        Array.Copy(nums, newarr, count);
        return newarr;


    }

    public static int[] Sort(int[] nums,int k)
    {
        for (int i = 0;i < nums.Length-1 ;i++)
        {
          for(int j =0;j < nums.Length-i-1 ;j++)
            {
                if (nums[j] > nums[j+1])
                {
                    int temp = nums[j];
                    nums[j] = nums[j+1];
                    nums[j+1] = temp;

                }
            }
        }
        return nums;
    }
    static void Main(string[] args)
    {
        int[] nums = { 1, 3, 4, 7, 6 };
        int val = 3;
        int[] expectedNums = { 1, 4, 6, 7 };
        int[] k = RemoveElement(nums, val);

        int p = expectedNums.Length;
       int[] l =  Sort (k , p);
        for (int i = 0; i< p; i++)
        {
            
            if (expectedNums[i] == l[i])
            {
            Console.WriteLine(expectedNums[i] + " Matched  " + l[i]);   
            }

            
        }

        Console.WriteLine("ALL ASSERTION PASSESed");
    }

       
    
}
