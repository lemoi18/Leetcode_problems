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

            PrintHelper.PrintHeader("Majority Element");
            IQuestionSolving solver2 = new MajorityElement();
            solver2.Run();

            PrintHelper.PrintHeader("Two Sum");
            IQuestionSolving solver3 = new Twosum();
            solver3.Run();
        
            PrintHelper.PrintHeader("Single number");
            IQuestionSolving solver4 = new Singlenumber();
            solver4.Run();


            PrintHelper.PrintHeader("Search insert");
            IQuestionSolving solver5 = new SearchInsert();
            solver5.Run();
            
            
            PrintHelper.PrintHeader("Roman to Int");
            IQuestionSolving solver6 = new RomanToInt();
            solver6.Run();
        }
    }
}
