namespace P02.GraphicEditor
{
    using Interfaces;

    public abstract class DrawingManager : IDrawer
    {
        public  string Draw(IShape shape)
        {
            return this.DrawingFigure(shape);
        }

        protected abstract string DrawingFigure(IShape shape);
    }
}
