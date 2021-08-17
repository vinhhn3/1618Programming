using System;
using System.Windows.Forms;

namespace TicTacToeGame
{
	enum GameResult
	{
		NoWinner,
		Player1,
		Player2,
		Draw
	}


	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string _turn = "Player 1";
		private GameResult _result = GameResult.NoWinner;

		private GameResult IsThereAWinner()
		{
			return GameResult.NoWinner;
		}

		private void button_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			if (!string.IsNullOrEmpty(button.Text))
			{
				return;
			}
			if (_turn.Equals("Player 1"))
			{
				button.Text = "X";
				_turn = "Player 2";


			}
			else
			{
				button.Text = "O";
				_turn = "Player 1";
			}

			switch (IsThereAWinner())
			{
				case GameResult.NoWinner:
					break;
				case GameResult.Player1:
					break;
				case GameResult.Player2:
					break;
				case GameResult.Draw:
					break;
				default:
					break;
			}
			turnLabel.Text = "Turn: " + _turn;
		}

		private void resetButton_Click(object sender, EventArgs e)
		{
			button00.Text = "";
			button01.Text = "";
			button02.Text = "";
			button10.Text = "";
			button11.Text = "";
			button12.Text = "";
			button20.Text = "";
			button21.Text = "";
			button22.Text = "";

			_turn = "Player 1";
			turnLabel.Text = "Turn: Player 1";
		}
	}
}
