namespace Scores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter  in your first mane.");
            string date = DateTime.Today.ToShortDateString();
            string uName = Console.ReadLine();
            string msg = $"\nWelcome back {uName}. Today is {date}.";
            Console.WriteLine(msg);

            //define the file path
            string path = @"C:\Users\coste\OneDrive\Programing_and_WebDev_folder\Coste's Web Developer projects\Scores\Scores\studentScores.txt";

            //using Sistem.IO to open the file in the path read all lines and store them in an array
            string[] lines = System.IO.File.ReadAllLines(path);

            double tScore = 0.0;
            Console.WriteLine("\nStudent Scores are: \n");
            foreach (string line in lines)
            {
                Console.Write("\n" + line);
                double score = Convert.ToDouble(line);
                tScore += score;
            }
            double avgScore = tScore / lines.Length;
            Console.WriteLine("\nTotal of " + lines.Length + " student scores. \tAverage score: " + avgScore);

            Console.WriteLine("\n\nPress any key to exit!");
            Console.ReadLine();

        }
    }
}