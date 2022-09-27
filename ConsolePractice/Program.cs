using ConsolePractice;
using ConsolePractice.Delegate;
using ConsolePractice.WordProblems;
using static ConsolePractice.Delegate.DelegateClass;

internal class Program
{
    private static void Main(string[] args)
    {
        ClassPract.PrintConsole("Hello World");

        //Inhertance Practice.
        //FClass fClass = new FClass();
        //FClass gClass = new GClass();
        //FClass hClass = new HClass();

        //fClass.CallMethod();
        //gClass.CallMethod();
        //hClass.CallMethod();

        ClassPract.PrintConsole(StringProblems.ReverseEachWordOfTheSentence("My name is mukesh").ToString());
        StringProblems.GetPossibleSubstring("My name is mukesh");
    }    
}