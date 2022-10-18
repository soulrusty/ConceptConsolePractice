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

        /*-------Create an INT Array and Also Assign Empty Array--------*/

        int[] array = new int[] { 3,78,78,8,8,99,0 };
        array = Array.Empty<int>();

        /*-------Create an INT Array and Also Assign Empty Array--------*/


    }
}