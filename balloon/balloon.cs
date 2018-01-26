using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace balloon
{
    class balloon0
    {
        private int x = 20;
        private int y = 20;
        private int diameter = 10;
        private Ellipse ellipse;


        public balloon0()
        {
            CreateEllipse();
        }

        private void CreateEllipse()
        {
            ellipse = new Ellipse();
            ellipse.Stroke = new SolidColorBrush(Colors.Blue);
            ellipse.StrokeThickness = 3;        
          
        }

        private void UpdateElipse()
        {
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }

        public void MoveRight(int xstep)
        {
            x = x + xstep;
            UpdateElipse();
        }

        public void ChangeSize(int change)
        {
            diameter = change + diameter ;
            UpdateElipse();
        }

        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
        }
    }
}
