namespace JediGalaxy
{
    public class Evil
    {
        private int row;
        private int col;

        public int Row { get; private set; }
        public int Col { get; private set; }

        public void UpdateCoodrinates(int row, int col)
        {
            this.Row = row;
            this.Col = col;
        }
    }
}
