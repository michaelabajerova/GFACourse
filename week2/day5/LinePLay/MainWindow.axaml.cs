using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;
using JetBrains.Annotations;
using Avalonia.Animation;

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
            foxDraw.SetBackgroundColor(Colors.Black);

            /*linePlay(foxDraw);*/
            /*linePlay4(foxDraw);*/
            linePlay16(foxDraw);
        }

        public static void linePlay(FoxDraw foxDraw)
        {
            var startPoint = new Point(0, 0);
            var endPoint = new Point(10, 800);
            foxDraw.DrawLine(startPoint, endPoint);
            for (int i = 0; i < 17; i++)
            {
                foxDraw.DrawLine(0, 0 + (i * 50), 10 + (i * 50), 800);
                foxDraw.SetStrokeColor(Colors.DarkViolet);
            }
            startPoint = new Point(0, 0);
            endPoint = new Point(800, 10);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.AntiqueWhite);
            for (int i = 0; i < 17; i++)
            {
                foxDraw.DrawLine(0 + (i * 50), 0, 800, 10 + (i * 50));
            }
        }
        /// Don't kill me for this code ///
        public static void linePlay4(FoxDraw foxDraw)
        {
            var startPoint = new Point(0, 0);
            var endPoint = new Point(0, 400);
            foxDraw.DrawLine(startPoint, endPoint);
            for (int i = 0; i < 11; i++)
            {
                foxDraw.DrawLine(0, 0 + (i * 40), 0 + (i * 40), 400);
                foxDraw.SetStrokeColor(Colors.DarkViolet);
            }
            startPoint = new Point(0, 0);
            endPoint = new Point(400, 0);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.AntiqueWhite);
            for (int i = 0; i < 11; i++)
            {
                foxDraw.DrawLine(0 + (i * 40), 0, 400, 0 + (i * 40));
            }

            startPoint = new Point(400, 0);
            endPoint = new Point(400, 400);
            foxDraw.DrawLine(startPoint, endPoint);
            for (int i = 0; i < 11; i++)
            {
                foxDraw.DrawLine(400, 0 + (i * 40), 400 + (i * 40), 400);
                foxDraw.SetStrokeColor(Colors.Blue);
            }
            startPoint = new Point(400, 0);
            endPoint = new Point(800, 0);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.IndianRed);
            for (int i = 0; i < 11; i++)
            {
                foxDraw.DrawLine(400 + (i * 40), 0, 800, 0 + (i * 40));
            }
            startPoint = new Point(0, 400);
            endPoint = new Point(0, 800);
            foxDraw.DrawLine(startPoint, endPoint);
            for (int i = 0; i < 11; i++)
            {
                foxDraw.DrawLine(0, 400 + (i * 40), 0 + (i * 40), 800);
                foxDraw.SetStrokeColor(Colors.BurlyWood);
            }
            startPoint = new Point(0, 400);
            endPoint = new Point(400, 400);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.Aquamarine);
            for (int i = 0; i < 11; i++)
            {
                foxDraw.DrawLine(0 + (i * 40), 400, 400, 400 + (i * 40));
            }
            startPoint = new Point(400, 400);
            endPoint = new Point(400, 800);
            foxDraw.DrawLine(startPoint, endPoint);
            for (int i = 0; i < 11; i++)
            {
                foxDraw.DrawLine(400, 400 + (i * 40), 400 + (i * 40), 800);
                foxDraw.SetStrokeColor(Colors.Firebrick);
            }
            startPoint = new Point(400, 400);
            endPoint = new Point(800, 400);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.LawnGreen);
            for (int i = 0; i < 11; i++)
            {
                foxDraw.DrawLine(400 + (i * 40), 400, 800, 400 + (i * 40));
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
