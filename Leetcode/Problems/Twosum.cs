
using System.Diagnostics;

public class Twosum : IQuestionSolving 
{
    // Custom method for the problem's logic
    public int[] solution(int[] nums,int target) {

        for (int i = 0; i < nums.Length; i++)
        {


            for (int j =i+1 ; j < nums.Length; j++)
            {
                
                if(nums[i]+ nums[j] == target){
                    return new[] {i,j};
                }


            }
        }

        return new[] { -1, -1 };

    }   

    // Implementing Run to facilitate testing manually
    public void Run()
    {
        int[] nums = {2, 7, 11, 15,0,0,-2}; // Input array
        int target = -2;
        
        // Print the input array
        PrintHelper.Print($"Input: {string.Join(", ", nums)}");
        
        // Get the indices from the solution method
        int[] indices = solution(nums, target);
        PrintHelper.Print($"Indices returned: {indices[0]} and {indices[1]}");

        // Sum up the values at the returned indices
        int sum = nums[indices[0]] + nums[indices[1]];
        PrintHelper.Print($"Sum of values at these indices: {sum}");
        
        // Check against the target
        if(sum == target)
        {
            PrintHelper.Print("The sum equals the target!");
        }
        else
        {
            PrintHelper.Print("The sum does not equal the target!");
        }





    }

}
