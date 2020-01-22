namespace PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(Point topLeft, Point bottomRight)
        {
            this.TopLeft = topLeft;
            this.BottomRight = bottomRight;
        }

        public Point TopLeft { get; private set; }
        public Point BottomRight { get; private set; }

        public bool Contains(Point point)
        {
            if (this.TopLeft.X <= point.X
                && this.BottomRight.X >= point.X
                && this.TopLeft.Y <= point.Y
                && this.BottomRight.Y >= point.Y)
            {
                return true;
            }

            return false;
        }
    }
}
