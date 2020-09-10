using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;
using JetBrains.Annotations;

namespace DrawingApplication
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
            var foxDraw = new FoxDraw(canvas);
            foxDraw.SetBackgroundColor(Colors.Teal);

            ///Exercises////
            ///Lines///
            var halfHeight = Height / 2;
            var halfWidth = Width / 2;
            foxDraw.SetStrokeColor(Colors.DarkRed);
            
            var startPoint = new Point(0, 400);
            var endPoint = new Point(800, 400);
            foxDraw.DrawLine(startPoint, endPoint);
            startPoint = new Point(400, 0);
            endPoint = new Point(400, 800);
            foxDraw.DrawLine(startPoint, endPoint);

            ///Box///
            foxDraw.SetStrokeColor(Colors.Violet);
            startPoint = new Point(200, 200);
            endPoint = new Point(200, 600);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.LightSteelBlue);
            startPoint = new Point(200, 200);
            endPoint = new Point(600, 200);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.BlanchedAlmond);
            startPoint = new Point(600, 200);
            endPoint = new Point(600, 600);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.DarkSlateGray);
            startPoint = new Point(200, 600);
            endPoint = new Point(600, 600);
            foxDraw.DrawLine(startPoint, endPoint);
            ///Diogonals///
            foxDraw.SetStrokeColor(Colors.DarkGreen);
            startPoint = new Point(0, 0);
            endPoint = new Point(800, 800);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.Red);
            startPoint = new Point(800, 0);
            endPoint = new Point(0, 800);
            foxDraw.DrawLine(startPoint, endPoint);

           /* ToTheCenter(foxDraw, startPoint, endPoint);
            HorizontalLines(foxDraw, startPoint, endPoint);
            SquareInTheCenter(foxDraw);
            DrawFour(foxDraw);
            PositionSquare(foxDraw);*/
            CenterBoxFunction(foxDraw);
            /*RainbowBoxes(foxDraw);*//*
            PurpleSteps(foxDraw);*/
            /*PurpleSteps3D(foxDraw);*/

        }
        public static void ToTheCenter(FoxDraw foxDraw, Point startPoint, Point endPoint)
        {
            startPoint = new Point (200, 200);
            endPoint = new Point (400, 400);
            foxDraw.SetStrokeColor(Colors.YellowGreen);
            foxDraw.DrawLine(startPoint, endPoint);
            
            for (int i = 0; i <= 5; i++)
             {
                foxDraw.DrawLine(20 * i, 50 * i, 400, 400);
             }
        }
        public static void HorizontalLines(FoxDraw foxDraw, Point startPoint, Point endPoint)
        {
            startPoint = new Point(0, 50);
            endPoint = new Point(800, 50);
            foxDraw.SetStrokeColor(Colors.Black);
            foxDraw.DrawLine(startPoint, endPoint);

            for (int i = 0; i <= 50; i++)
            {
                foxDraw.DrawLine(startPoint * i, endPoint * i);
            }
        }
        public static void SquareInTheCenter(FoxDraw foxDraw)
        {
            foxDraw.SetFillColor(Colors.Green);
            foxDraw.DrawRectangle(390, 390, 10, 10);
            
        }
        public static void DrawFour(FoxDraw foxDraw)
        {
            List<Color> colors = new List<Color> { Colors.MintCream, Colors.MidnightBlue, Colors.Orange, Colors.PeachPuff};
            foxDraw.DrawRectangle(400, 0, 70, 50);
            for (int x = 0; x < 4; x++)
            { 
                foxDraw.DrawRectangle((x * 20) + 400, (x * 45) + 0, (x * 20) + 70, (x * 20) + 50);
                foxDraw.SetFillColor(colors[x]);
            }
        }
        public static void PositionSquare(FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(0, 0, 50, 50);
            foxDraw.SetFillColor(Colors.Tomato);
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawRectangle((i * 40) + 0,(i * 40) + 0, 50, 50);
            }
        }
        public static void CenterBoxFunction(FoxDraw foxDraw)
        {
            List<Color> color = new List<Color> { Colors.Gold, Colors.Gray, Colors.Indigo };
            foxDraw.DrawRectangle(400, 400, 50, 50);
            for (int i = 0; i < 3; i++)
            {
                foxDraw.DrawRectangle(400, 400, ((i * 20) + 50) * 2, ((i * 20) + 50) * 2);
                foxDraw.SetFillColor(color[i]);
            }
        }
        /*        public static void RainbowBoxes(FoxDraw foxDraw)
                {
                    List<Color> colors = new List<Color> { Colors.LightSteelBlue, Colors.LightYellow, Colors.LightYellow, Colors.Indigo, Colors.Lavender };
                    foxDraw.DrawRectangle(200, 400, 50, 50);
                    for (int i = 0; i < 10; i++)
                    {
                        foxDraw.DrawRectangle((i * 45) + 100, (i * 45) + 800, 50, 50);
                        foxDraw.SetFillColor(colors[i]);
                    }
                }*/
        public static void PurpleSteps(FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(0, 0, 20, 20);
            foxDraw.SetFillColor(Colors.Purple);
            for (int i = 0; i <= 40; i++)
            {
                foxDraw.DrawRectangle((i * 20) + 0,(i * 20) + 0, 20, 20);
            }
        }
        public static void PurpleSteps3D(FoxDraw foxDraw)
        {
            foxDraw.DrawRectangle(0, 0, 20, 20);
            foxDraw.SetFillColor(Colors.Purple);
            for (int i = 0; i <= 15; i++)
            {
                foxDraw.DrawRectangle((0 + (i * 30)) + (5 * i), (0 + (i * 30)) + (5 * i), 20 + (i * 5), 20 + (i * 5));
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
        

    }
}