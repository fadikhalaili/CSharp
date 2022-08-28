namespace CSharpCourse.Linq.Ex01
{
    public class Solution_Start
    {
        public static void Run()
        {
            // Läs in TV-tablån

            string[] rows = ReadTvShowFile();

            // Skapa en lista av Show's

            List<Show> allShows = ParseTvShows(rows);

            // Skriva ut info om Show'erna

            DisplayInfoAboutShows(allShows);
        }

        private static void DisplayInfoAboutShows(List<Show> allShows)
        {
            // Visa alla titlar

            Console.WriteLine("ALLA TITLAR");
            Console.WriteLine();

            var allTitles = allShows.Select(x => x.Title);

            foreach (var title in allTitles)
            {
                Console.WriteLine(title);
            }

            // Alla program som börjar senare än eller lika med 21.00 

            Console.WriteLine();
            Console.WriteLine("Program som börjar senare än kl 21");
            Console.WriteLine();

            var allShowsThatStartAfter21 = allShows.Where(x => x.StartAt.Hours >= 21);

            foreach (var show in allShowsThatStartAfter21)
            {
                Console.WriteLine($"{show.Channel} {show.StartAt} {show.Title}");
            }

        }

        private static List<Show> ParseTvShows(string[] rows)
        {
            var allShows = new List<Show>();

            foreach (string line in rows)
            {
                string[] splittedLine = line.Split('*');

                var show = new Show
                {
                    Channel = splittedLine[0],
                    StartAt = TimeSpan.Parse(splittedLine[1]),
                    Title = splittedLine[2],
                };

                allShows.Add(show);
            }
            return allShows;
        }

        // Extrauppgift: Gör metoden ovan mha LINQ

        private static string[] ReadTvShowFile()
        {
            return File.ReadAllLines(@"Linq\Ex01\tv-data.txt");
        }
    }
}
