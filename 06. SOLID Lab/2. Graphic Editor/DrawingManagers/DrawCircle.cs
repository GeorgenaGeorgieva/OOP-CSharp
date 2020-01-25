namespace P02.GraphicEditor.DrawingManagers
{
    using Interfaces;
    using Figures;

    public class DrawCircle : DrawingManager
    {
        protected override string DrawingFigure(IShape shape)
        {
            var circle = shape as Circle;
            return $"I'm {circle}";
        }
    }
}
