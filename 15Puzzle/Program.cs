namespace _15Puzzle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //come up with a potential design as a starting point, would our design
            //be able to accomdate 3x3 or 5x5 boards
            Console.Title = "15 puzzle";
            Console.WriteLine("Welcome to 15 puzzle.");
            PuzzleBoard puzzle = new PuzzleBoard(4);  //creates a list of tiles and displays a list
        }
    }
}
