using System;
using SkiaSharp;
using SkiaSharp.Views.Forms;
using Xamarin.Forms;

namespace InterfaceBuilder
{
    public class Noise : SKCanvasView
    {
        Random random = new Random();
        SKPaint paint = new SKPaint
        {
            Style = SKPaintStyle.Stroke,
            StrokeWidth = 2,
            IsAntialias = true,
            StrokeJoin = SKStrokeJoin.Round,
        };

        public Noise(double width, double height)
        {
            HorizontalOptions = LayoutOptions.StartAndExpand;
            VerticalOptions = LayoutOptions.StartAndExpand;
            WidthRequest = width;
            HeightRequest = height;
        }

        protected override void OnPaintSurface(SKPaintSurfaceEventArgs e)
        {
            base.OnPaintSurface(e);

            var canvas = e.Surface.Canvas;
            canvas.Clear();

            DrawNoise(canvas, e.Info.Width, e.Info.Height);
        }

        private void DrawNoise(SKCanvas canvas, float width, float height)
        {

            for (int i = 0; i < (width * height) / 10; i++)
            {
                paint.Color = Theme.Colors.Black.ToSKColor().Transparency(random.NextDouble() / 20);
                var x = random.Next(0, (int)width);
                var y = random.Next(0, (int)height);
                canvas.DrawPoint(x, y, paint);
            }
        }
    }
}
