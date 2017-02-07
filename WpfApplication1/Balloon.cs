using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Shapes;
using System.Windows.Media;
using System.Windows.Controls;

namespace WpfApplication1
{
    // ENCAPSULATIE

    class Balloon
    {
        private int x = 10;
        private int y = 100;
        private int diameter = 10;

        Ellipse ellipse = new Ellipse();

        static Random rndGen = new Random();

        public Balloon(Canvas canvas, Color color)
        {
            diameter = rndGen.Next(10, 30);
            x = rndGen.Next(10, 300);
            y = rndGen.Next(10, 200);

            UpdateEllipse(canvas, color);
        }

        public Balloon(Canvas canvas, int diameter, Color color)
        {
            this.diameter = diameter;
            x = rndGen.Next(10, 300);
            y = rndGen.Next(10, 200);

            UpdateEllipse(canvas, color);
        }

        public Balloon(Canvas canvas, int diameter, int height, Color color)
        {
            this.diameter = diameter;
            x = rndGen.Next(10, 300);
            y = height;

            UpdateEllipse(canvas, color);
        }

        void UpdateEllipse(Canvas canvas, Color color)
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Red);
            ellipse.Fill = new SolidColorBrush(color);
            canvas.Children.Add(ellipse);
        }

        public void Grow()
        {
            diameter += 10;
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }

        public void Shrink()
        {
            diameter -= 10;
            ellipse.Width = diameter;
            ellipse.Height = diameter;
        }

        public void Up()
        {
            y -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        public void Down()
        {
            y += 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        public void Left()
        {
            x -= 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        public void Right()
        {
            x += 10;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }
    }
}