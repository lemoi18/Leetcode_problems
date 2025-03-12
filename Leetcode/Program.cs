namespace Leetcode
{
    class Program
    {
        static void Main(string[] args)
        {

            PrintHelper.PrintHeader("RemoveElement");
            IQuestionSolving solver = new RemoveElement();
            solver.Run();
            
            PrintHelper.PrintHeader("Merge Sorted Array");
            IQuestionSolving solver1 = new MergeSortedArray();
            solver1.Run();

        }
    }
}
