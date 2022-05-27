using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using ToolSelector.Interfaces;

namespace ToolSelector.Classes
{
    public class MainCanvas
    {
        public Canvas Canvas { get; private set; }
        public MainCanvas(Canvas canvas)
        {
            Canvas = canvas;
        }
        public ITool SelectedTool { get; set; }

        public void SetTool(ITool tool)
        {
            SelectedTool = tool;
        }

        public void Click(Point point)
        {
            SelectedTool.Click(point, Canvas);
        }
    }
}
