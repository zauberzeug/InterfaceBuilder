using System;
using SkiaSharp;

namespace InterfaceBuilder
{
    public static class SkiaExtensions
    {

        public static SKPoint Scale(this SKPoint point, SKPoint factor)
        {
            return new SKPoint(point.X * factor.X, point.Y * factor.Y);
        }

        public static SKPoint Scale(this SKPoint point, double factor)
        {
            return new SKPoint((float)(point.X * factor), (float)(point.Y * factor));
        }

        public static double DistanceTo(this SKPoint a, SKPoint b)
        {
            var x = b.X - a.X;
            var y = b.Y - a.Y;
            return Math.Sqrt(x * x + y * y);
        }

        public static string ToString(this SKPoint p)
        {
            return $"({p.X},{p.Y})";
        }

        public static SKColor Transparency(this SKColor color, double amount)
        {
            return color.WithAlpha((byte)(color.Alpha * amount));
        }

        public static bool Within(this SKRect rect, double left, double top, double right, double bottom)
        {
            return rect.Left > left && rect.Top > top && rect.Right < right && rect.Bottom < bottom;
        }

        public static SKRect Shrink(this SKRect rect, float amount)
        {
            return new SKRect(rect.Left + amount, rect.Top + amount, rect.Right - amount, rect.Bottom - amount);
        }

        public static SKRect ToRect(this SKSize size)
        {
            return new SKRect(0, 0, size.Width, size.Height);
        }

        public static SKPoint Center(this SKSize size)
        {
            return new SKPoint((float)size.Width / 2, (float)size.Height / 2);
        }

        /// <summary>
        /// returns largest distance between edges from smaller rect reaching over edges from bigger rect
        /// </summary>
        public static double MeasureOverlapWith(this SKRect bigger, SKRect smaller)
        {
            var leftOverlap = bigger.Left - smaller.Left;
            var topOverlap = bigger.Top - smaller.Top;
            var rightOverlap = smaller.Right - bigger.Right;
            var bottomOverlap = smaller.Bottom - bigger.Bottom;

            return Math.Max(Math.Max(Math.Max(leftOverlap, topOverlap), rightOverlap), bottomOverlap);
        }
    }

}
