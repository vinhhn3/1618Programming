using System;
using System.Windows.Forms;

namespace TicTacToeGame
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string _turn = "Player 1";

		private void label2_Click(object sender, EventArgs e)
		{

		}

		private void button00_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(button00.Text))
			{
				return;
			}
			if (_turn.Equals("Player 1"))
			{
				button00.Text = "X";
				_turn = "Player 2";

			}
			else
			{
				button00.Text = "O";
				_turn = "Player 1";
			}
			turnLabel.Text = "Turn: " + _turn;
		}

		private void button01_Click(object sender, EventArgs e)
		{
			if (!string.IsNullOrEmpty(button01.Text))
			{
				return;
			}
			if (_turn.Equals("Player 1"))
			{
				button01.Text = "X";
				_turn = "Player 2";

			}
			else
			{
				button01.Text = "O";
				_turn = "Player 1";
			}
			turnLabel.Text = "Turn: " + _turn;
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			button00.Text = "";
			button01.Text = "";
			_turn = "Player 1";
			turnLabel.Text = "Turn: Player 1";
		}
	}
}
