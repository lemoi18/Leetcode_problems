
using System.Diagnostics;

public class RomanToInt : IQuestionSolving 
{
    public int solution(string s) {

        Dictionary<char, int> sub = new Dictionary<char, int>();

        sub.Add('I', 1);
        sub.Add('V', 5);
        sub.Add('X', 10);
        sub.Add('L', 50);
        sub.Add('C', 100);
        sub.Add('D', 500);
        sub.Add('M', 1000);


        int sum= 0;
        int prev = 0;
        foreach (var _char in s)
        {


            if (sub.ContainsKey(_char))
            {
                if (prev < sub[_char])  
                {
                    sum += sub[_char] - 2 * prev;

                }
                else
                {
                    sum +=  sub[_char];

                }

                prev = sub[_char];
            }
        }


        return sum;
    }

    // Implementing Run to facilitate testing manually
    public void Run()
    {
        string s = "IIX";
        int target = 56;

        PrintHelper.Print($"Input: {s}");
        int k = solution(s);
        PrintHelper.Print($"output: {k} should be {target}");



    }

}
