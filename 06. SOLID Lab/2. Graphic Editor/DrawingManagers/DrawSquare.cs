namespace P02.GraphicEditor.DrawingManagers
{
    using Interfaces;
    using Figures;

    public class DrawSquare : DrawingManager
    {
        protected override string DrawingFigure(IShape shape)
        {
            var square = shape as Square;

            return $"I'm {square}";
        }
    }
}
