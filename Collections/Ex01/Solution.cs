using ConsoleUtilities;

namespace CSharpCourse.Collections.Ex01
{
    public class Solution
    {
        static readonly ConsoleCompanion _cc = new();

        public static void NamesWithListManipulate()
        {
            var list = new List<string>();

            while (true)
            {
                string name = _cc.AskForString("Enter a name:");
                if (name.ToLower() == "quit")
                {
                    list.Sort();

                    RemoveFirstAndLastValue(list);

                    DisplayPeople(list);
                    return;
                }
                list.Add(name);
            }
        }

        private static void RemoveFirstAndLastValue(List<string> list)
        {
            if (list.Count == 1)
                list.RemoveAt(0);

            else if (list.Count >= 2)
            {
                list.RemoveAt(0);
                list.RemoveAt(list.Count - 1);
            }
        }

        private static void DisplayPeople(List<string> list)
        {
            foreach (var name in list)
            {
                _cc.WriteLineDark($"Name: {name}");
            }
        }
    }
}
