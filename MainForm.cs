using System;
using System.Drawing;
using System.Windows.Forms;

namespace Simulated_annealing
{
	public partial class MainForm : Form
	{
		private readonly Graphics _g;
		private Field _field;

		private readonly Pen _pen;

		private readonly Font _drawFont;
		private readonly SolidBrush _drawBrush;
		private readonly StringFormat _drawFormat ;

		public MainForm()
		{
			InitializeComponent();
			_g = pictureBox.CreateGraphics();

			_pen = new Pen(Brushes.Blue);

			_drawFont = new Font("Arial", 16);
			_drawBrush = new SolidBrush(Color.Black);
			_drawFormat = new StringFormat();
		}

		#region Buttons

		private void setButton_Click(object sender, EventArgs e)
		{
			clearButton_Click(this, e);
			RunButton.Enabled = true;

			_field = new Field(pictureBox.Width,
							   pictureBox.Height,
							   int.Parse(numericUpDown.Text));

			for (int i = 0; i < _field.Points.Count; i++)
			{
				DrawDot(_field.Points[i].From - 5,
						_field.Points[i].To - 5);

				DrawString( i.ToString(),
						   _field.Points[i].From,
						   _field.Points[i].To);
			}

			_drawFont.Dispose();
			_drawBrush.Dispose();
		}

		private void clearButton_Click(object sender, EventArgs e)
		{
			RunButton.Enabled = false;
			_g.Clear(Color.White);
			_field = null;
		}

		private void runButton_Click(object sender, EventArgs e)
		{
			Compute();
		}

		private void Compute()
		{
			var simAnn = new SimulatedAnnealing(_field.Points, int.Parse(iterationNumericUpDown.Text));

			var state = simAnn.PerformSimulatedAnnealing(int.Parse(initialTempNumeric.Text),
														 double.Parse(endTempNumeric.Text));

			for (int i = 1; i < state.Count; i++)
			{
				DrawLine(_field.Points[state[i]].From,
						 _field.Points[state[i]].To,
						 _field.Points[state[i - 1]].From,
						 _field.Points[state[i - 1]].To);
			}
		}

		#endregion Buttons

		#region Drawing

		private void DrawDot(int x, int y)
		{
			_g.FillEllipse(Brushes.Black, x, y, 10, 10);
		}

		private void DrawLine(int x1, int y1, int x2, int y2)
		{
			_g.DrawLine(_pen, x1, y1, x2, y2);
		}

		private void DrawString(string drawString, int x, int y)
		{
			_g.DrawString(drawString, _drawFont, _drawBrush, x, y, _drawFormat);
		}

		#endregion Drawing
	}
}