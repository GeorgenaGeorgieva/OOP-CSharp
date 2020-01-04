namespace JediGalaxy
{
    public class Player
    {
        private int row;
        private int col;
        private long score;

        public int Row { get; set; }
        public int Col { get; set; }
        public long Score { get; set; }

        public void UpdateCoordinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
}
