using System;
using System.Windows.Forms;

namespace TicTacToeGame
{
	enum GameResult // Union
	{
		NoWinner,
		Player1,
		Player2,
		Draw
	}

	enum MovieType
	{
		Action,
		Drama,
		Comedy,
		SuperHero
	}


	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private string _turn = "Player 1";
		private GameResult _result = GameResult.NoWinner;
		private int _turnCounter = 0;

		private GameResult IsThereAWinner()
		{
			bool isThereAWinner = false;

			// Check Vertical
			if (button00.Text != "" && (button00.Text == button01.Text) && (button00.Text == button02.Text))
			{
				isThereAWinner = true;
			}
			else if (button10.Text != "" && (button10.Text == button11.Text) && (button10.Text == button12.Text))
			{
				isThereAWinner = true;
			}
			else if (button20.Text != "" && (button20.Text == button21.Text) && (button20.Text == button22.Text))
			{
				isThereAWinner = true;
			}
			// Check Horizontal
			else if (button00.Text != "" && (button00.Text == button10.Text) && (button00.Text == button20.Text))
			{
				isThereAWinner = true;
			}
			else if (button01.Text != "" && (button01.Text == button11.Text) && (button01.Text == button21.Text))
			{
				isThereAWinner = true;
			}
			else if (button02.Text != "" && (button02.Text == button12.Text) && (button02.Text == button22.Text))
			{
				isThereAWinner = true;
			}
			// Check diagonal
			else if (button00.Text != "" && (button00.Text == button11.Text) && (button00.Text == button22.Text))
			{
				isThereAWinner = true;
			}
			else if (button02.Text != "" && (button02.Text == button11.Text) && (button02.Text == button20.Text))
			{
				isThereAWinner = true;
			}

			if (!isThereAWinner) // isThereAWinner = False => !isThereAWinner = True
			{
				if (_turnCounter == 9)
				{
					_result = GameResult.Draw;
					return _result;
				}
				_result = GameResult.NoWinner;
				return _result;
			}
			else                // isThereAWinner = True => !isThereAWinner = False
			{
				_result = _turn == "Player 1" ? GameResult.Player1 : GameResult.Player2;
				return _result;
			}
		}


		private void button_Click(object sender, EventArgs e)
		{
			Button button = (Button)sender;
			if (!string.IsNullOrEmpty(button.Text) || _result != GameResult.NoWinner)
			{
				return;
			}
			button.Text = _turn.Equals("Player 1") ? "X" : "O";

			_turnCounter++;

			switch (IsThereAWinner())
			{
				case GameResult.NoWinner:
					_turn = _turn.Equals("Player 1") ? "Player 2" : "Player 1";
					turnLabel.Text = "Turn: " + _turn;
					break;
				case GameResult.Player1:
					gameResult.Text = "PLAYER 1 WIN !!!";
					break;
				case GameResult.Player2:
					gameResult.Text = "PLAYER 2 WIN !!!";
					break;
				case GameResult.Draw:
					gameResult.Text = "DRAW !!!";
					break;
				default:
					break;
			}
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
			gameResult.Text = "";
			_result = GameResult.NoWinner;
		}
	}
}
