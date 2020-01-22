namespace ClassBoxData
{
    using System;
    using System.Text;

    public class Box
    {
        private double length;
        private double width;
        private double height;
        private double surfaceArea;
        private double lateralArea;
        private double volume;

        public Box(double length, double width, double height)
        {
            this.Length = length;
            this.Width = width;
            this.Height = height;

            this.SurfaceArea = surfaceArea;
            this.LateralArea = lateralArea;
            this.Volume = volume;
        }

        public double Length
        {
            get
            {
                return this.length;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Length cannot be zero or negative.");
                }

                this.length = value;
            }
        }

        public double Width
        {
            get
            {
                return this.width;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Width cannot be zero or negative.");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException($"Height cannot be zero or negative.");
                }

                this.height = value;
            }
        }

        public double SurfaceArea
        {
            get { return this.surfaceArea; }
            private set { this.surfaceArea = value; }
        }
            
        public double LateralArea 
        {
            get { return this.lateralArea; } 
            private set { this.lateralArea = value; }
        }
        public double Volume 
        {
            get { return this.volume; } 
            private set { this.volume = value; }
        }

        public void GetVolume()
        {
            this.Volume = this.Length * this.Width * this.Height;
        }

        public void GetLateralSurfaceArea()
        {
            this.LateralArea = (2 * this.Length * this.Height) + (2 * this.Width * this.Height);
        }

        public void GetSurfaceArea()
        {
            this.SurfaceArea = (2 * this.Length * this.Width) 
                + (2 * this.Length * this.Height) 
                + (2 * this.Width * this.Height);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendLine($"Surface Area - {this.SurfaceArea:F2}");
            output.AppendLine($"Lateral Surface Area - {this.LateralArea:F2}");
            output.AppendLine($"Volume - {this.Volume:F2}");

            return output.ToString().TrimEnd();
        }
    }
}
