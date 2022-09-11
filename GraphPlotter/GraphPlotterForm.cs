using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphPlotter
{
    public partial class GraphPlotterForm : Form
    {
        private MathFunction[] mathFunctions;

        public GraphPlotterForm()
        {
            InitializeComponent();
            mathFunctions = Enum.GetValues(typeof(MathFunction)).Cast<MathFunction>().ToArray();
            var mathFunctionNames = mathFunctions.Select(mf => mf.GetFunctionName()).ToArray();
            functionNamesComboBox.Items.AddRange(mathFunctionNames);
        }

        private void plotGraphButton_Click(object sender, EventArgs e)
        {
            int selectedMathFunctionIndex = functionNamesComboBox.SelectedIndex;
            if (selectedMathFunctionIndex == -1)
            {
                MessageBox.Show("Не выбрана функция!");
                return;
            }
            var selectedMathFunction = mathFunctions[selectedMathFunctionIndex];

            double beginX;
            if (!double.TryParse(beginXTextBox.Text, out beginX))
            {
                MessageBox.Show("Указано некорректное начало диапазона!");
                return;
            }

            double endX;
            if (!double.TryParse(endXTextBox.Text, out endX))
            {
                MessageBox.Show("Указан некорректный конец диапазона!");
                return;
            }

            if (beginX >= endX)
            {
                MessageBox.Show("Левая граница диапазона не может быть больше правой!");
                return;
            }

            PlotGraph(selectedMathFunction, beginX, endX);
        }

        private void PlotGraph(MathFunction mathFunction, double beginX, double endX)
        {
            int width = graphPictureBox.Size.Width;
            int height = graphPictureBox.Size.Height;
            var drawingSurface = new Bitmap(width, height);
            var gfx = Graphics.FromImage(drawingSurface);

            double stepSize = (endX - beginX) / width;
            var graphData = new Graph2D(beginX, endX, stepSize, mathFunction);

            for (int i = 0; i < graphData.Points.Count - 1; i++)
            {
                var relativePoint1 = graphData.Points[i].CreateRelativePoint(drawingSurface.Size, graphData);
                var relativePoint2 = graphData.Points[i + 1].CreateRelativePoint(drawingSurface.Size, graphData);
                gfx.DrawLine(Pens.Red, relativePoint1.X, relativePoint1.Y, relativePoint2.X, relativePoint2.Y);
            }

            graphPictureBox.Image = drawingSurface;
        }
    }
}
