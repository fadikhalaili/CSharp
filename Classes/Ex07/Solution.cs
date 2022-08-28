// Syfte: Ofta är det bra att ställa krav på inparametrar. Det gör att buggar upptäcks tidigare. Fail fast.

namespace CSharpCourse.Classes.Ex07
{
    public class Solution
    {
        class Car
        {
            public int Weight { get; }
            public string Color { get; }

            public Car(string c, int w)
            {
                if (c == null)
                {
                    throw new ArgumentNullException("The color can't be null");
                }

                // Exercise: Verify "c" (at least one character)

                if (c.Length == 0)
                {
                    throw new ArgumentException("The color must have one character");
                }

                // Exercise: Verify "w" ( a positive number)

                if (w < 0)
                {
                    throw new ArgumentException("The weight can't be negative");
                }


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
            var c3 = new Car();

            var c4 = new Car("blue", -111);  // ---> detta kommer få programmet att krascha (vilket är bra)
            var c5 = new Car("", 800);       // ---> detta kommer få programmet att krascha (vilket är bra)

            Console.WriteLine($"The color of car1 is {c1.Color} and the weight is {c1.Weight}");
            Console.WriteLine($"The color of car2 is {c2.Color} and the weight is {c2.Weight}");
            Console.WriteLine($"The color of car3 is {c3.Color} and the weight is {c3.Weight}");
        }
    }
}
