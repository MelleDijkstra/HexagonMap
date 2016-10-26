using System;
using System.Collections.Generic;
using System.Drawing;

namespace HexagonMap
{
    internal class Map
    {
        private int width;
        private int height;

        private List<Hexagon> hexagons;

        public Map(int width, int height)
        {
            this.width = width;
            this.height = height;

            CalculateHexagons();
        }

        public void Draw(Graphics g)
        {
            foreach (Hexagon hexagon in hexagons)
            {
                hexagon.Draw(g);
            }
        }

        private void CalculateHexagons()
        {
            hexagons = new List<Hexagon>();

            float x = 0;
            float y = Hexagon.Height / 2;
            //Console.WriteLine("rows = {0} = Math.Floor(({1} / {2}) = {3})", Math.Floor(height / Hexagon.Height), height, Hexagon.Height, height / Hexagon.Height);
            //Console.WriteLine("columns = {0} = Math.Floor(({1} / {2}) = {3})", Math.Floor(width / Hexagon.Height), width, Hexagon.Height, width / Hexagon.Height);
            // Calculate amount of hexagons and location
            for (int row = 1; row <= Math.Floor(height / Hexagon.Height); ++row)
            {
                //Console.WriteLine("row: {0}", row);
                x = 0;
                // For every row
                for (int column = 1; column <= Math.Floor(width / Hexagon.Height); ++column)
                {
                    // For every columns
                    //Console.WriteLine("column: {0}", column);
                    if (column % 2 == 1)
                        y += Hexagon.Height / 2;
                    hexagons.Add(new Hexagon(x, y));
                    if (column % 2 == 1)
                        y -= Hexagon.Height / 2;
                    x += Hexagon.Height;
                }
                y += Hexagon.Height;
            }
        }

        public void SetWidth(int width)
        {
            this.width = width;
        }

        public void SetHeight(int height)
        {
            this.height = height;
        }

        public void Refresh(int width, int height)
        {
            this.width = width;
            this.height = height;
            Refresh();
        }

        public void Refresh()
        {
            CalculateHexagons();
        }
    }
}