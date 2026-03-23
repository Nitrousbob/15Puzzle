namespace _15Puzzle
{
    internal class PuzzleBoard
    {
        public int Size { get; private set; }
        public int[] Tiles {get; private set;}
        public int BlankIndex { get; private set;}
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
            BlankIndex = 0;
        }

        public bool IsSolved()
        {
            
            return false;
        }

        public bool CanMove(int tile)
        {
            //methods for validating moves
            //evaulate position of tile to moved,  possibly listing all movable candidates to choose from
            //only tiles surrounding the blank space can move into the blank space
            return false;
        }

        public void MoveTile(int tile)
        {
            //update the puzzle to reflect the position of the tiles that moved
        }


        //loop through the board
        public int GetTileIndex(int tile)
        {
            for (int i = 0; i < Tiles.Length; i++)
            {
                //check each value in Tiles
                if (Tiles[i] == tile)
                {
                    //if it finds the title number, it returns that array index
                    return i;
                }
            }
            //if it does not find it, it returns -1
            return -1;  //-1  is a common "not found" value
        }

        //keep track of the empty space
        public int GetBlankRow()
        {
            return BlankIndex / Size;

            //example if BlankIndex = 6, row = 6/4 = 1
            
        }

        public int GetBlankColumn()
        {
            return BlankIndex % Size;

            //example if BlankIndex = 6, column = 6 % 4 = 2
        }

        
    }
}
