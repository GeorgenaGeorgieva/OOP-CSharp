namespace Shapes
{
    using System;
    using System.Text;

    public class Rectangle : IDrawable
    {
        private int width;
        private int height;

        public Rectangle(int width, int height)
        {
            this.Width = width;
            this.Height = height;
        }

        public int Width 
        { 
            get { return this.width; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid parameter!");
                }

                this.width = value;
            }
        }

        public int Height 
        {
            get { return this.height; }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Invalid parameter!");
                }

                this.height = value;
            }
        }

        public string Draw()
        {
            StringBuilder stringBuilder = new StringBuilder();

            DrawLine(this.Width, '*', '*', stringBuilder);
            for (int i = 1; i < this.Height - 1; ++i)
            {
                DrawLine(this.Width, '*', ' ', stringBuilder);
            }

            DrawLine(this.Width, '*', '*', stringBuilder);

            return stringBuilder.ToString();
        }

        protected string DrawLine(int width, char end, char mid, StringBuilder sb)
        {
            sb.Append(end);
            for (int i = 1; i < width - 1; ++i)
            {
                sb.Append(mid);
            }

            sb.AppendLine(end.ToString());
            return sb.ToString();
        }
    }
}
