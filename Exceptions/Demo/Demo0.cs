namespace CSharpCourse.Exceptions.Demo
{
    public class Demo0
    {
        public static void Run()
        {
            Console.WriteLine("Snart lunch");

            int x = Addera(3, 4);

            throw new Exception("Ojojoj!");

            Console.WriteLine("Detta kommer aldrig inträffa");

        }

        private static int Addera(int v1, int v2)
        {
            // Fördelar:
            // * Fail fast!
            // * Det går att bygga programmet, vi behöver inte returnera något
            throw new NotImplementedException();
        }
    }
}
