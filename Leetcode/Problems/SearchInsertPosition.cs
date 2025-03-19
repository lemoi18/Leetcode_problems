
using System.Diagnostics;

public class SearchInsert : IQuestionSolving 
{
    public int solution(int[] nums, int target) {

        for (int i = 0; i < nums.Length; i++) {
            PrintHelper.Print($"{i}");

            if (nums[i] >= target) {
                PrintHelper.Print($"Target found at index: {i} (value: {nums[i]})");
                return i;
            }

            if (i == nums.Length-1)
            {
                return i+1;
            }





/*             if (i + 1 < nums.Length && (i != 0) ) {
                
                PrintHelper.Print($"i is {i} and i+1 {i+1} and i-1 is {i-1 }");

                if(nums[i] > target)
                {
                    PrintHelper.Print("Case 1 ");
                    return i+1;
                }
                else if (nums[i] < target)
                {
                    PrintHelper.Print("Case 2 ");
                    return i;
                }


                //return i;
            } */
        }
        return -1;
    }

    public void Run()
    {
        int[] nums = {1,3,5,7}; // Input array
        int target = 7;
        
        // Print the input array
        PrintHelper.Print($"Input: {string.Join(", ", nums)}");
        PrintHelper.Print($"target: {target}");

        // Get the indices from the solution method
        int indices = solution(nums, target);

        PrintHelper.Print($"output: {indices}");






    }

}
