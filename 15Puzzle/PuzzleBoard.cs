namespace _15Puzzle
{
    internal class PuzzleBoard
    {
        public int Size { get; private set; }
        List<int> tiles = new List<int>();  //should this be an array list that has position or should the tile own position
        //Should the tiles just be tiles with a position instead of a list.

        public PuzzleBoard(int size)
        {
            //create a board that is size x size
            //the tile list will have size * size tiles
            //one tile needs to be the space, possibly the 0 tile

            int tile = 0;
            for (int i = 0; i < size; i++)
            {
                Console.Write("\n");
                for (int j = 0; j < size; j++)
                {
                    Console.Write($"[{tile}] ");
                    tiles.Add(tile);
                    tile++;
                }
            }
        }
        //build a set of tiles 1-15
        //keeps track of the empty space
        //methods for validating moves
        //only tiles surrounding the blank space can move into the blank space
    }
}
