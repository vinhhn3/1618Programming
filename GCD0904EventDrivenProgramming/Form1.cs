using System;
using System.Windows.Forms;

namespace GCD0904EventDrivenProgramming
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void increaseButton_Click(object sender, EventArgs e)
		{
			int counterValue = int.Parse(counter.Text);
			counterValue = counterValue + 1;
			counter.Text = counterValue.ToString();
		}

		private void decreaseButton_Click(object sender, EventArgs e)
		{
			int counterValue = int.Parse(counter.Text);
			counterValue = counterValue - 1;
			counter.Text = counterValue.ToString();
		}
	}
}
