// Syfte: Properties gör att vi slipper skapa metoder som "SetColor" och "GetColor"

namespace CSharpCourse.Classes.Ex05
{
    public class Solution
    {
        class Car
        {
            public int Weight { get; set; } 
            public string Color { get; set; }

            public Car(string c, int w)
            {
                Color = c;
                Weight = w;
            }

            public Car()
            {
                Color = "pink";
                Weight = 999;
            }
        }

        public static void Run()
        {
            var c1 = new Car("blue", 1200);
            var c2 = new Car("red", 800);
            var c3 = new Car(); // ska ge en bil med lila färg som väger 999kg 

            c2.Color = "yellow";
            c2.Weight = 600;

            Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
            Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
            Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");
        }
    }
}
