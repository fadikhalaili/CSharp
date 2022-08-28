namespace CSharpCourse.Linq.Demo
{
    public class Demo3
    {
        public void Run()
        {
            var people = new List<Person>
            {
                new Person ("Ludvig", 55 ),
                new Person ("Alice", 28 ),
                new Person ("Fred", 30 ),
                new Person ("Zelda",  45)
            };

            //var peopleOlderThan25 = people.Where(p => p.Age > 25);

            var peopleOlderThan25 = people.Where(MyFilter25);

            Func<Person, bool> filter;

            filter = MyFilter25;

            var result1 = people.Where(filter);

            // bla
            // bla
            // bla

            filter = MyFilter50;

            var result2 = people.Where(filter);

        }

        private int Addera(int a, int b)
        {
            return a + b;
        }

        private bool MyFilter25(Person p)
        {
            return p.Age > 25;
        }

        private bool MyFilter50(Person p)
        {
            return p.Age > 50;
        }
    }
}
