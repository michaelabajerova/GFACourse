using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.Media;
using GreenFox;
using System.Collections.Generic;
using JetBrains.Annotations;
using Avalonia.Animation;

namespace EnvelopeStar
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
            envelopeStar(foxDraw);

        }

        public static void envelopeStar(FoxDraw foxDraw)
        {
            var startPoint = new Point(400, 0);
            var endPoint = new Point(400, 400);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.DarkViolet);
            for (int i = 0; i < 9; i++)
            {
                foxDraw.DrawLine(400, 0 + (i * 50), 400 + (i * 50), 400);
            }
            startPoint = new Point(400, 400);
            endPoint = new Point(400, 800);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.LightYellow);
            for (int j = 0; j < 9; j++)
            {
                foxDraw.DrawLine(400 + (j * 50), 400, 400, 800 - (j * 50));
            }
            startPoint = new Point(400, 0);
            endPoint = new Point(400, 400);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.LightYellow);
            for (int k = 0; k < 9; k++)
            {
                foxDraw.DrawLine(400, 0 + (k * 50), 400 - (k * 50), 400);
            }
            startPoint = new Point(400, 800);
            endPoint = new Point(400, 400);
            foxDraw.DrawLine(startPoint, endPoint);
            foxDraw.SetStrokeColor(Colors.DarkViolet);
            for (int l = 0; l < 9; l++)
            {
                foxDraw.DrawLine(400, 800 - (l * 50), 400 - (l * 50), 400);
            }
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}