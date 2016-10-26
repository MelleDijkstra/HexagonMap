using System;
using System.Drawing;

namespace HexagonMap
{
    class Hexagon
    {

        float x;
        float y;

        private PointF[] points;

        public const float Height = 80;

        public float Width = (float)(4 * (Height / 2 / Math.Sqrt(3)));

        public Hexagon(float x, float y)
        {
            this.x = x;
            this.y = y;

            points = new[]
            {
                new PointF(x, y),
                new PointF(x + Width * 0.25f, y - Height / 2),
                new PointF(x + Width * 0.75f, y - Height / 2),
                new PointF(x + Width, y),
                new PointF(x + Width * 0.75f, y + Height / 2),
                new PointF(x + Width * 0.25f, y + Height / 2),
            };
        }

        public void Draw(Graphics g)
        {
            g.DrawPolygon(Pens.DarkSlateBlue, points);
            foreach (PointF point in points)
            {
                g.DrawRectangle(Pens.Tomato, point.X - 1.5f, point.Y - 1.5f, 3, 3);
                g.DrawString($"[{Math.Round(point.X)}:{Math.Round(point.Y)}]", SystemFonts.DefaultFont, Brushes.Black, point.X - 10f, point.Y + 10f);
            }
        }
    }
}
