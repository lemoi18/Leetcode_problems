

public class RemoveElement : IQuestionSolving 
{
    // Custom method for the problem's logic
    public int solution(int[] nums1, int val)
    {

            int k = 0;  
            
            for(int i = 0; i < nums1.Length; i++){
                if(nums1[i]!= val){
                    nums1[k] = nums1[i];
                    k++;
                }
                
            }
            return k;

    }

    // Implementing Run to facilitate testing manually
    public void Run()
    {
        // Example test case
        int[] nums1 = {0,1,2,2,3,0,4,2};
        int n = 3;
        PrintHelper.Print($"Input: {string.Join(", ", nums1)}");
        PrintHelper.Print($"Input: {n}");

        int k = solution(nums1, n);
        Console.WriteLine($"Output: {string.Join(", ", nums1)}");
        Console.WriteLine(string.Join("k is : %d", k));

    }
}
