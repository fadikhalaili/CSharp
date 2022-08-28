// Ctrl . ==> Generell kodhjälp, i detta fallet "Remove unnecessary usings"

namespace CSharpCourse.Fundamentals.Demo
{
    public class Demo1
    {
        public static void Run()
        {
            Console.Write("Enter you height: ");
            string? answer = Console.ReadLine()!;

            // cw + TAB ==> Console.Writeline

            Console.WriteLine("You are " + answer +"cm long");
        }
    }
}
