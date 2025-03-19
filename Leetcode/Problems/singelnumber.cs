
using System.Diagnostics;

public class Singlenumber : IQuestionSolving 
{
    // Custom method for the problem's logic
    public int solution(int[] nums) {

        var counts = new Dictionary<int, int>();

        foreach (var item in nums)
        {
            
            if(counts.ContainsKey(item)){

                counts[item] += 1;
            }
            else{
                counts[item] = 1;
            }

        }

        foreach (var onlyone in counts)
        {
            if(onlyone.Value == 1){
                return onlyone.Key;
            }
        }
        return -1;

    }   

    // Implementing Run to facilitate testing manually
    public void Run()
    {
        int[] nums = {4,1,2,1,2}; // Input arra
        
        // Print the input array
        PrintHelper.Print($"Input: {string.Join(", ", nums)}");
        
        // Get the indices from the solution method
        int result = solution(nums);

        PrintHelper.Print($"output: {result}");




    }

}
