using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;
using JetBrains.Annotations;
using Avalonia.Animation;

namespace sierpinsky
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
            foxDraw.SetBackgroundColor(Colors.Black);
            Sierpinski(foxDraw);
#endif
        }

        private void Sierpinski(FoxDraw foxDraw)
        {
            Point figureShift = new Point(0, 0);
            double baseSize = 200;
            int baseLevel = 5;
            //
            foxDraw.SetFillColor(Colors.LightSeaGreen);
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.DrawRectangle(figureShift.X, figureShift.Y, 3 * baseSize, 3 * baseSize);
            //
            foxDraw.SetFillColor(Colors.Black);
            Sierpinski(foxDraw, figureShift, baseSize, baseLevel);
        }
        private void Sierpinski(FoxDraw foxDraw, Point origin, double size, int level)
        {
            if (level > 0)
            {
                int squareCount = 3;
                foxDraw.DrawRectangle(origin.X + size, origin.Y + size, size, size);
                //
                for (int col = 0; col < squareCount; col++)
                {
                    for (int row = 0; row < squareCount; row++)
                    {
                        Sierpinski(
                            foxDraw,
                            new Point(origin.X + col * size, origin.Y + row * size),
                            size / 3,
                            level - 1);
                    }
                }
            }
        }

            private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
