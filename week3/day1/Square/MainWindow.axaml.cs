using Avalonia;
using Avalonia.Controls;
using Avalonia.Controls.Shapes;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Square
{
    public class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
            var canvas = this.Get<Canvas>("canvas");
            var foxDraw = new FoxDraw(canvas);
            foxDraw.SetBackgroundColor(Colors.RosyBrown);
            foxDraw.SetStrokeColor(Colors.DarkRed);
            Squares(foxDraw, new Point(0, 0), 800);
#endif
        }

        private void Squares(FoxDraw foxDraw, Point starting, int size)
        {
            foxDraw.DrawLine(new Point(starting.X, starting.Y + size / 3), new Point(starting.X + size, starting.Y + size / 3));
            foxDraw.DrawLine(new Point(starting.X, starting.Y + size * 2 / 3), new Point(starting.X + size, starting.Y + size * 2 / 3));
            foxDraw.DrawLine(new Point(starting.X + size / 3, starting.Y), new Point(starting.X + size / 3, starting.Y + size));
            foxDraw.DrawLine(new Point(starting.X + size * 2 / 3, starting.Y), new Point(starting.X + size * 2 / 3, starting.Y + size));
            if (size > 20)
            {
                Squares(foxDraw, new Point(starting.X + size / 3, starting.Y), size / 3);
                Squares(foxDraw, new Point(starting.X, starting.Y + size / 3), size / 3);
                Squares(foxDraw, new Point(starting.X + size / 3, starting.Y + size * 2 / 3), size / 3);
                Squares(foxDraw, new Point(starting.X + size * 2 / 3, starting.Y + size / 3), size / 3);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
    

