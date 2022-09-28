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

        //ClassPract.PrintConsole(StringProblems.ReverseEachWordOfTheSentence("My name is mukesh").ToString());
        //StringProblems.GetPossibleSubstring("My name is mukesh");
        //StringProblems.BinarySearchOnstring();
        int[] array = new int[] {1,1,4,4,2,3,4,1,2,3,2,1,2,3,3,2,1,1,1,3,3,1};
        ArrayProblems.FindDuplicateIntegersInArrayAndReturnInAscendingOrder(array.Length,array);
    }    
}