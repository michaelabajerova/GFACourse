using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System;
using System.Collections.Generic;

namespace HexagonDrawing
{
    public class MainWindow : Window
    {

        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            var canvas = this.Get<Canvas>("canvas");
            Width = 800;
            Height = 800;
            FoxDraw foxDraw = new FoxDraw(canvas);


            drawBoxes(foxDraw, 100, 100, 100);
        }

        public void drawBoxes(FoxDraw foxDraw, int columnCount, int rowCount, int boxSize)
        {

            var yOffset = -0.5 * boxSize;

            for (int row = 0; row < rowCount; row++)
            {
                for (int column = 0; column < columnCount; column++)
                {
                    if (row % 2 == 0)
                    {
                        drawBox(foxDraw, boxSize,
                            new Point(column * (boxSize * Math.Sqrt(3)),
                                     yOffset + (row * 1.5 * boxSize)));
                    }
                    else
                    {
                        drawBox(foxDraw, boxSize,
                            new Point(column * (boxSize * Math.Sqrt(3)) + boxSize * Math.Sqrt(3) / 2,
                                      yOffset + (row * 1.5 * boxSize)));
                    }
                }
            }


        }

        public void drawBox(FoxDraw foxDraw, double boxSize, Point startingPoint)
        {
            var xAdjustment = (Math.Sqrt(3) / 2) * boxSize;

            Point a = new Point(startingPoint.X, startingPoint.Y);
            Point b = new Point(xAdjustment + startingPoint.X, 0.5 * boxSize + startingPoint.Y);
            Point c = new Point(xAdjustment + startingPoint.X, 1.5 * boxSize + startingPoint.Y);
            Point d = new Point(startingPoint.X, 2 * boxSize + startingPoint.Y);
            Point e = new Point(-xAdjustment + startingPoint.X, 1.5 * boxSize + startingPoint.Y);
            Point f = new Point(-xAdjustment + startingPoint.X, 0.5 * boxSize + startingPoint.Y);

            Point center = new Point(startingPoint.X, boxSize + startingPoint.Y);

            foxDraw.SetStrokeThicknes(0);

            // #4EB99F
            foxDraw.SetFillColor(Colors.Beige);
            foxDraw.DrawPolygon(new List<Point> { a, b, center, f });

            // #078388
            foxDraw.SetFillColor(Colors.Black);
            foxDraw.DrawPolygon(new List<Point> { b, c, d, center });

            // #122F41
            foxDraw.SetFillColor(Colors.DimGray);
            foxDraw.DrawPolygon(new List<Point> { center, d, e, f });
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
