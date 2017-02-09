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
        private int txt;

        Label Textblock = new Label();
        Ellipse ellipse = new Ellipse();
        Canvas cans = new Canvas();

        static Random rndGen = new Random();

        public Balloon(Canvas canvas, Color color)
        {
            cans = canvas;
            diameter = rndGen.Next(10, 30);
            x = rndGen.Next(10, 300);
            y = rndGen.Next(10, 200);
            
            DrawEllipse(color);
            DrawTextblock();
        }

        public Balloon(Canvas canvas, int diameter, Color color)
        {
            cans = canvas;
            this.diameter = diameter;
            x = rndGen.Next(10, 300);
            y = rndGen.Next(10, 200);
            
            DrawEllipse(color);
            DrawTextblock();
        }

        public Balloon(Canvas canvas, int diameter, int height, Color color)
        {
            cans = canvas;
            this.diameter = diameter;
            x = rndGen.Next(10, 300);
            y = height;


            DrawEllipse(color);
            DrawTextblock();
        }

        void DrawEllipse(Color color)
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
            ellipse.Stroke = new SolidColorBrush(Colors.Red);
            ellipse.Fill = new SolidColorBrush(color);
            cans.Children.Add(ellipse);
        }

        void DrawTextblock()
        {
            txt = y - (diameter / 3);
            Textblock.Content = "te";
            Textblock.Margin = new Thickness(x, txt, 0, 0);
            cans.Children.Add(Textblock);
        }

        void UpdateTextblock()
        {
            txt = y - (diameter / 3);
            Textblock.Margin = new Thickness(x, txt, 0, 0);
        }

        void UpdateEllipse()
        {
            ellipse.Width = diameter;
            ellipse.Height = diameter;
            ellipse.Margin = new Thickness(x, y, 0, 0);
        }

        public void Grow()
        {
            diameter += 10;
            UpdateEllipse();
        }

        public void Shrink()
        {
            diameter -= 10;
            UpdateEllipse();
        }

        public void Up()
        {
            y -= 10;
            UpdateEllipse();
            UpdateTextblock();
        }

        public void Down()
        {
            y += 10;
            UpdateEllipse();
            UpdateTextblock();
        }

        public void Left()
        {
            x -= 10;
            UpdateEllipse();
            UpdateTextblock();
        }

        public void Right()
        {
            x += 10;
            UpdateEllipse();
            UpdateTextblock();
        }
    }
}