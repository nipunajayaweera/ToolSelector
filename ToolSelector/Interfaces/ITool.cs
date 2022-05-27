using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace ToolSelector.Interfaces
{
    public interface ITool
    {
        void Click(Point point, Canvas canvas);
    }
}
