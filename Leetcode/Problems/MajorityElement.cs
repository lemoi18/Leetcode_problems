
using System.Diagnostics;

public class MajorityElement : IQuestionSolving 
{
    // Custom method for the problem's logic
    public int solution(int[] nums) {

        var (count,num) = (0,0);

        foreach(var _num in nums)
        {

            if(count == 0){
                num = _num;
            }

            count += num == _num ? 1: -1;

        }

        return num;
    }

    // Implementing Run to facilitate testing manually
    public void Run()
    {
        int[] nums = {2,2,1,1,1,2,2}; // Input array

        PrintHelper.Print($"Input: {string.Join(", ", nums)}");
        int k = solution(nums);
        PrintHelper.Print($"output: {k}");



    }

}
