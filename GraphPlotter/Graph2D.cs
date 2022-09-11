using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphPlotter
{
    public class Graph2D
    {
        public double BeginX { get; private set; }
        public double EndX { get; private set; }
        public double StepSize { get; private set; }
        public double MinY { get; private set; }
        public double MaxY { get; private set; }
        public List<Point2D> Points { get; private set; }
        private Func<double, double> func;

        public Graph2D(double BeginX, double endX, double stepSize, MathFunction mathFunction)
        {
            this.BeginX = BeginX;
            EndX = endX;
            StepSize = stepSize;
            func = mathFunction.GetFunc();
            FillPoints();
        }

        private void FillPoints()
        {
            MinY = double.MaxValue;
            MaxY = double.MinValue;

            Points = new List<Point2D>();
            for (double x = BeginX; x <= EndX; x += StepSize)
            {
                double y = func(x);

                MinY = Math.Min(MinY, y);
                MaxY = Math.Max(MaxY, y);

                var point = new Point2D(x, y);
                Points.Add(point);
            }
        }
    }
}
