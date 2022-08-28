namespace CSharpCourse.Linq.Demo
{
    public class Demo1
    {
        public static void Run()
        {
            var list = new List<int> { 3, 10, 7 };

            var result1 = NumberHigherThanFive(list);
            var result2 = NumberHigherThanFive_Linq(list);

            var result3 = StarifyList(list);
            var result4 = StarifyList_Linq(list);

            var result5 = Combination(list);
        }


        private static IEnumerable<int> NumberHigherThanFive(IEnumerable<int> list)
        {
            var result = new List<int>();
            foreach (var i in list)
            {
                if (i > 5)
                    result.Add(i);
            }
            return result;
        }


        private static IEnumerable<int> NumberHigherThanFive_Linq(IEnumerable<int> list)
        {
            return list.Where(item => item > 5);
        }

        private static IEnumerable<string> StarifyList(IEnumerable<int> list)
        {
            var result = new List<string>();
            foreach (int i in list)
            {
                result.Add($"*{i}*");
            }
            return result;
        }

        private static IEnumerable<string> StarifyList_Linq(IEnumerable<int> list)
        {
            return list.Select(item => $"*{item}*");
        }

        // Filtrering + Manipulering
        private static IEnumerable<string> Combination(IEnumerable<int> list)
        {
            return list
                .Where(x => x > 5)
                .Select(x => $"*{x}*");
        }


    }
}
