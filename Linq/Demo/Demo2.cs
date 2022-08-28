namespace CSharpCourse.Linq.Demo
{

    public class Demo2
    {
        public static void Run()
        {
            var p = new Person("Ludvig", 55);
            var a = new Person("Alice", 28);

            var people = new List<Person>
            {
                new Person ("Ludvig", 55 ),
                new Person ("Alice", 28 ),
                new Person ("Fred", 30 ),
                new Person ("Zelda",  45)
            };

            IEnumerable<Person> peopleOlderThan32 = people.Where(p => p.Age > 32);

            IEnumerable<string> allNamesUppercased = people.Select(p => p.FirstName.ToUpper());

            IEnumerable<string> combined = people
                .Where(p => p.Age > 32)
                .Select(p => p.FirstName);

            // 

        }
    }
}
