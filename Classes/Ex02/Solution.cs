namespace CSharpCourse.Classes.Ex02
{
    // class TAB TAB
    class Car
    {
        // Fält (field) vill vi skydda
        private string _color ="";

        // Metoder (publika)
        public void SetColor(string color)
        {
            _color = color;
        }

        public string GetColor()
        {
            return _color;
        }
    }

    public class Solution
    {
        public static void Run()
        {
            var c1 = new Car();
            c1.SetColor("blue");
            Console.WriteLine($"The color of car1 is {c1.GetColor()}");

            var c2 = new Car();
            var c3 = new Car();

            c2.SetColor("red");

            Console.WriteLine($"The color of car2 is {c2.GetColor()}");
            Console.WriteLine($"The color of car3 is {c3.GetColor()}");

        }
    }
}
