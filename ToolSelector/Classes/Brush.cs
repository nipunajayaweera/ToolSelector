using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using ToolSelector.Interfaces;

namespace ToolSelector.Classes
{
    public class Brush : ITool
    {
        public void Click(Point point, Canvas canvas)
        {
            Rectangle rec = new Rectangle()
            {
                Width = 30,
                Height = 30,
                Fill = Brushes.Green,
                Stroke = Brushes.Black,
                StrokeThickness = 1,
            };

            canvas.Children.Add(rec);
            Canvas.SetTop(rec, point.Y);
            Canvas.SetLeft(rec, point.X);
        }
    }
}
