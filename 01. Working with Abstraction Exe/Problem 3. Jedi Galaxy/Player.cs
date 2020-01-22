namespace JediGalaxy
{
    public class Player
    {
        private int row;
        private int col;
        private long score;

        public int Row { get; private set; }
        public int Col { get; private set; }
        public long Score { get; private set; }

        public void UpdateCoordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
}
