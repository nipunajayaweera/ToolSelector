using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ToolSelector.Classes;
using Brush = ToolSelector.Classes.Brush;
using Pen = ToolSelector.Classes.Pen;

namespace ToolSelector
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        MainCanvas mainCanvas;
        public MainWindow()
        {
            InitializeComponent();
            mainCanvas = new MainCanvas(canvas);
            mainCanvas.SetTool(new Pen());
        }

        private void Canvas_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            var pos = e.GetPosition((IInputElement)sender);
            mainCanvas.Click(pos);
        }

        private void Pen_Click(object sender, RoutedEventArgs e)
        {
            mainCanvas.SetTool(new Pen());
        }
        private void Brush_Click(object sender, RoutedEventArgs e)
        {
            mainCanvas.SetTool(new Brush());
        }
    }
}
