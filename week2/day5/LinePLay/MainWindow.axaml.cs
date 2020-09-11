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

            linePlay(foxDraw);
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

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
