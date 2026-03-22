namespace _15Puzzle
{
    internal class PuzzleBoard
    {
        public int Size { get; private set; }
        public int[] Tiles {get; private set;}
        
        public PuzzleBoard(int size)
        {
            //create a board that is size x size
            //the tile list will have size * size tiles
            //one tile needs to be the space, possibly the 0 tile

            Size = size; //passes size information to our property
            Tiles = new int[size * size];
            int tile = 0;
            //build a set of tiles 1-15
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Tiles[i * size + j] = tile;
                    tile++;
                }
            }
        }

        public void CanMove()
        {
            //methods for validating moves
            //evaulate position of tile to moved,  possibly listing all movable candidates to choose from
            //only tiles surrounding the blank space can move into the blank space
        }

        public void MoveTile()
        {
            //update the puzzle to reflect the position of the tiles that moved
        }
        //keeps track of the empty space
    }
}
