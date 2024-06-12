using System.Globalization;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

namespace Assignment_6._2._2
{
    internal class Program
    {
        
        static void Main(string[] args)
        {

            int[] nums = { 1, 2, 3, 4, };
            int[] result = Product(nums);
            
            
            
        }

        static int[] Product(int[] nums)
        {
            int n = nums.Length;

            int[] leftSide = new int[n];

            int[] rightSide = new int[n];

            int[] result = new int[n];

            int leftProduct = 1;
            for (int i = 0; i < n; i++)
            {
                leftSide[i] = leftProduct;
                leftProduct = leftProduct * nums[i];
            }

            int rightProduct = 1;
            for(int i = 0;i < n; i--)
            {
                rightSide[i] = rightProduct;
                rightProduct = rightProduct * nums[i];
            }

            for (int i = 0; i < n; i++)
            {
                result[i] = leftSide[i] * rightSide[i];
            }
            return result;

        }
        

        
    }
}
