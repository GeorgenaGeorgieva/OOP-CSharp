namespace P02.GraphicEditor.DrawingManagers
{
    using Interfaces;
    using Figures;

    public class DrawRectengle : DrawingManager
    {
        protected override string DrawingFigure(IShape shape)
        {
            var rectangle = shape as Rectangle;
            return $"I'm {rectangle}";
        }
    }
}
