using ConsolePractice;
using ConsolePractice.Delegate;
using ConsolePractice.Inhertance;
using ConsolePractice.Interface;
using System.Text;
using static ConsolePractice.Delegate.DelegateClass;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassPract.PrintConsole("I love you");

        //FClass fClass = new FClass();
        //FClass gClass = new GClass();
        //FClass hClass = new HClass();

        //fClass.CallMethod();
        //gClass.CallMethod();
        //hClass.CallMethod();

        // Instantiate the delegate.
        Del handler = DelegateMethod;

        // Call the delegate.
        handler(6,9);
        ClassPract.PrintConsole(handler(6, 9).ToString());

        ClassPract.PrintConsole(TimesACharIsThere("DEVELOPER"));
    }

    public static int AddNumber(string inputnums)
    {
        int sum = 0;
        var number = inputnums.Split(',');
        foreach( string s in number){
            sum=sum+Convert.ToInt32(s);
        }
        return sum;
    }

    public static int TimesAStringIsThere(string tofind,string fromstring)
    {
        var numofTimes = fromstring.Split(tofind, StringSplitOptions.RemoveEmptyEntries);
        return numofTimes.Length-1;
    }

    public static string TimesACharIsThere(string fromstring)
    {
        Dictionary<char, int> dict = new ();
        StringBuilder stringBuilder = new StringBuilder();

        foreach (char c in fromstring)
        {
            if (dict.ContainsKey(c))
            {
                dict[c] = dict[c] + 1;
            }
            else
            {
                dict.Add(c, 1);
            }
        }
        foreach(var kvp in dict)
        {
            stringBuilder.Append(kvp.Key);
            stringBuilder.Append(kvp.Value);
        }

        return stringBuilder.ToString();
    }
}