
namespace TicTacToeGame
{
	partial class Form1
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.resetButton = new System.Windows.Forms.Button();
			this.button00 = new System.Windows.Forms.Button();
			this.button01 = new System.Windows.Forms.Button();
			this.button02 = new System.Windows.Forms.Button();
			this.button10 = new System.Windows.Forms.Button();
			this.button11 = new System.Windows.Forms.Button();
			this.button12 = new System.Windows.Forms.Button();
			this.button20 = new System.Windows.Forms.Button();
			this.button21 = new System.Windows.Forms.Button();
			this.button22 = new System.Windows.Forms.Button();
			this.turnLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(96, 48);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 29);
			this.label1.TabIndex = 0;
			this.label1.Text = "Player 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(542, 48);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 29);
			this.label2.TabIndex = 1;
			this.label2.Text = "Player 2";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(335, 350);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(93, 29);
			this.label3.TabIndex = 2;
			this.label3.Text = "Result: ";
			// 
			// resetButton
			// 
			this.resetButton.Location = new System.Drawing.Point(310, 393);
			this.resetButton.Name = "resetButton";
			this.resetButton.Size = new System.Drawing.Size(137, 45);
			this.resetButton.TabIndex = 3;
			this.resetButton.Text = "Reset Game";
			this.resetButton.UseVisualStyleBackColor = true;
			this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
			// 
			// button00
			// 
			this.button00.Location = new System.Drawing.Point(163, 105);
			this.button00.Name = "button00";
			this.button00.Size = new System.Drawing.Size(92, 54);
			this.button00.TabIndex = 4;
			this.button00.UseVisualStyleBackColor = true;
			this.button00.Click += new System.EventHandler(this.button00_Click);
			// 
			// button01
			// 
			this.button01.Location = new System.Drawing.Point(335, 105);
			this.button01.Name = "button01";
			this.button01.Size = new System.Drawing.Size(92, 54);
			this.button01.TabIndex = 5;
			this.button01.UseVisualStyleBackColor = true;
			this.button01.Click += new System.EventHandler(this.button01_Click);
			// 
			// button02
			// 
			this.button02.Location = new System.Drawing.Point(496, 105);
			this.button02.Name = "button02";
			this.button02.Size = new System.Drawing.Size(92, 54);
			this.button02.TabIndex = 6;
			this.button02.UseVisualStyleBackColor = true;
			// 
			// button10
			// 
			this.button10.Location = new System.Drawing.Point(163, 194);
			this.button10.Name = "button10";
			this.button10.Size = new System.Drawing.Size(92, 54);
			this.button10.TabIndex = 7;
			this.button10.UseVisualStyleBackColor = true;
			// 
			// button11
			// 
			this.button11.Location = new System.Drawing.Point(335, 194);
			this.button11.Name = "button11";
			this.button11.Size = new System.Drawing.Size(92, 54);
			this.button11.TabIndex = 8;
			this.button11.UseVisualStyleBackColor = true;
			// 
			// button12
			// 
			this.button12.Location = new System.Drawing.Point(496, 194);
			this.button12.Name = "button12";
			this.button12.Size = new System.Drawing.Size(92, 54);
			this.button12.TabIndex = 9;
			this.button12.UseVisualStyleBackColor = true;
			// 
			// button20
			// 
			this.button20.Location = new System.Drawing.Point(163, 283);
			this.button20.Name = "button20";
			this.button20.Size = new System.Drawing.Size(92, 54);
			this.button20.TabIndex = 10;
			this.button20.UseVisualStyleBackColor = true;
			// 
			// button21
			// 
			this.button21.Location = new System.Drawing.Point(335, 283);
			this.button21.Name = "button21";
			this.button21.Size = new System.Drawing.Size(92, 54);
			this.button21.TabIndex = 11;
			this.button21.UseVisualStyleBackColor = true;
			// 
			// button22
			// 
			this.button22.Location = new System.Drawing.Point(496, 283);
			this.button22.Name = "button22";
			this.button22.Size = new System.Drawing.Size(92, 54);
			this.button22.TabIndex = 12;
			this.button22.UseVisualStyleBackColor = true;
			// 
			// turnLabel
			// 
			this.turnLabel.AutoSize = true;
			this.turnLabel.Location = new System.Drawing.Point(331, 55);
			this.turnLabel.Name = "turnLabel";
			this.turnLabel.Size = new System.Drawing.Size(105, 20);
			this.turnLabel.TabIndex = 13;
			this.turnLabel.Text = "Turn: Player 1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.turnLabel);
			this.Controls.Add(this.button22);
			this.Controls.Add(this.button21);
			this.Controls.Add(this.button20);
			this.Controls.Add(this.button12);
			this.Controls.Add(this.button11);
			this.Controls.Add(this.button10);
			this.Controls.Add(this.button02);
			this.Controls.Add(this.button01);
			this.Controls.Add(this.button00);
			this.Controls.Add(this.resetButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Button resetButton;
		private System.Windows.Forms.Button button00;
		private System.Windows.Forms.Button button01;
		private System.Windows.Forms.Button button02;
		private System.Windows.Forms.Button button10;
		private System.Windows.Forms.Button button11;
		private System.Windows.Forms.Button button12;
		private System.Windows.Forms.Button button20;
		private System.Windows.Forms.Button button21;
		private System.Windows.Forms.Button button22;
		private System.Windows.Forms.Label turnLabel;
	}
}

