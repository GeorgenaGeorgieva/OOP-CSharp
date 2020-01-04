namespace JediGalaxy
{
    public class Galaxy
    {
        private int[,] galaxyMatrix;

        public int[,] CreateMatrix(int[] dimensions)
        {
            int rows = dimensions[0];
            int cols = dimensions[1];

            this.galaxyMatrix = new int[rows, cols];
            int starsPower = 0;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    this.galaxyMatrix[row, col] = starsPower++;
                }
            }

            return this.galaxyMatrix;
        }

        public bool IsInside(int targetRow, int targetCol)
        {
            return targetRow >= 0 && targetRow < this.galaxyMatrix.GetLength(0) 
                && targetCol >= 0 && targetCol < this.galaxyMatrix.GetLength(1);
        }

        public void MoveEvilToTopLeftCorner(Evil evil) 
        {
            while (evil.Row >= 0 && evil.Col >= 0)
            {
                if (IsInside(evil.Row, evil.Col))
                {
                    this.galaxyMatrix[evil.Row, evil.Col] = 0;
                }

                evil.Row--;
                evil.Col--;
            }
        }

        public void MovePlayerToTopRightCorner(Player player)
        {
            while (player.Row >= 0 && player.Col < this.galaxyMatrix.GetLength(1))
            {
                if (IsInside(player.Row, player.Col))
                {
                    player.Score += this.galaxyMatrix[player.Row, player.Col];
                }

                player.Row--;
                player.Col++;
            }
        }
    }
}
