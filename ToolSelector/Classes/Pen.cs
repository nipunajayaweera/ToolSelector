using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using ToolSelector.Interfaces;

namespace ToolSelector.Classes
{
    public class Pen : ITool
    {
        private Point _firstPoint = new Point(-1,-1);
        public void Click(Point point, Canvas canvas)
        {
            if (IsFirstPoint())
            {
                _firstPoint = point;
            }
            else
            {
                Line line = new Line()
                {
                    X1 = _firstPoint.X,
                    Y1 = _firstPoint.Y,
                    X2 = point.X,
                    Y2 = point.Y,
                    Stroke = Brushes.Black,
                    StrokeThickness = 5
                };
                canvas.Children.Add(line);
                SetDefaultPoint();
            }

        }

        private bool IsFirstPoint()
        {
            return _firstPoint.Equals(new Point(-1, -1));
        }

        private void SetDefaultPoint()
        {
            _firstPoint = new Point(-1, -1);
        }
    }
}
