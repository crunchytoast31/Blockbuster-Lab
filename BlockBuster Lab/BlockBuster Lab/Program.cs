namespace BlockBuster_Lab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Blockbuster we're going broke please buy something.");
            Console.WriteLine();

            List<Movies> listOfMovies = new List<Movies>();
            listOfMovies.Add(new VHS("Shrek", Category.Action, 91, new string[] { "Shrek comes on to the scene", "He begins to bathe in the swamp", "Shrek starts to bathe in the swamp", "Shrek slays some invaders", "Shrek now slumbers" }));
            listOfMovies.Add(new VHS("Shrek2", Category.Comedy, 251, new string[] { "Shrek wakes up ", "He remembers he forgot the internet bill", "Shrek goes to the at&t store", "Shrek patiently waits his turn patiently ", "Shrek had to pay a late fee, Shrek is sad" }));
            listOfMovies.Add(new VHS("Shrek3", Category.Romance, 132, new string[] { "Shrek meets a women on his way home from at&t", "She approached him because he was attractive", "Shrek entertains her and finds interest", "They go on a date and it seems they are meant for eachother", "Shrekly ever after" }));

            BlockBuster shop = new BlockBuster(listOfMovies);


            for (int i = 0; i < listOfMovies.Count; i++)
            {

                Console.WriteLine($"{i + 1}) {listOfMovies[i].Name}");
            }
        }
    }
}