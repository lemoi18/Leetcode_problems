public class MergeSortedArray : IQuestionSolving 
{
    // Custom method for the problem's logic
    public void Merge(int[] nums1, int m, int[] nums2, int n)
    {
            int p1 = m-1;
            int p2= n-1;
            int p3= m+n - 1;

            while (p1 >= 0 && p2 >= 0) {


            if(nums1[p1] >= nums2[p2]){

            
                nums1[p3] = nums1[p1];
                --p1;
            }
            else
            {
                nums1[p3] = nums2[p2];
                --p2;
            }



            --p3;

            }
        while (p2 >= 0) {
        nums1[p3] = nums2[p2];
        p2--;
        p3--;
        }

    }

    // Implementing Run to facilitate testing manually
    public void Run()
    {
        // Example test case
        int[] nums1 = {1,2,3,0,0,0};
        int[] nums2 = {2,5,6};
        Merge(nums1, 3, nums2, 3);
        Console.WriteLine(string.Join(", ", nums1));
    }
}
