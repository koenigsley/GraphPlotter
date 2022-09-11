using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace GraphPlotter
{
    public class Point2D
    {
        public double X, Y;

        public Point2D(double x, double y)
        {
            X = x;
            Y = y;
        }

        public Point CreateRelativePoint(Size size, Graph2D graphData)
        {
            double approximatedX = Approximate(X, graphData.BeginX, graphData.EndX);
            int relativeX = (int)(approximatedX * size.Width);

            double approximatedY = 1 - Approximate(Y, graphData.MinY, graphData.MaxY);
            int relativeY = (int)(approximatedY * size.Height);

            return new Point(relativeX, relativeY);
        }

        private static double Approximate(double value, double begin, double end)
        {
            return (value - begin) / (end - begin);
        }
    }
}
