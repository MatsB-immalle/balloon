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
        private int x = 100;
        private int y = 50;
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
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Width = diameter;
            ellipse.Height = diameter;
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

        public void MoveUp(int ystep)
        {
            y = y - ystep;
            UpdateElipse();
              
        }

        public void MoveLeft(int x2step)
        {
            x = x - x2step;
            UpdateElipse();
        }

        public void MoveDown(int y2step)
        {
            y = y + y2step;
            UpdateElipse();

        }

        public void ChangeSize(int change)
        {
            diameter = change + diameter ;
            UpdateElipse();
        }

        public void ChangeColor(int R,int G,int B,int R2, int G2,int B2)
        {
            ellipse.Fill = new SolidColorBrush(Color.FromRgb((byte)R, (byte)G, (byte)B));
            ellipse.Stroke = new SolidColorBrush(Color.FromRgb((byte)R2, (byte)G2, (byte)B2));
        }

        public void DisplayOn(Canvas drawingCanvas)
        {
            drawingCanvas.Children.Add(ellipse);
        }
    }
}
