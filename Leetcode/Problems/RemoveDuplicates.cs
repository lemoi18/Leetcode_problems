
using System.Diagnostics;

public class RemoveDuplicates : IQuestionSolving 
{
    // Custom method for the problem's logic
    public int solution(int[] nums) {
        int k = 0;

        return k;
    }

    // Implementing Run to facilitate testing manually
    public void Run()
    {
        int[] nums = {1,1,2}; // Input array
        int[] expectedNums = {1,2}; // The expected answer with correct length

        PrintHelper.Print($"Input: {string.Join(", ", nums)}");
        int k = solution(nums);
        PrintHelper.Print($"output: {k}");



    }

}
