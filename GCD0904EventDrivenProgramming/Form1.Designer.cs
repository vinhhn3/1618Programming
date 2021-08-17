
namespace GCD0904EventDrivenProgramming
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
			this.increaseButton = new System.Windows.Forms.Button();
			this.counter = new System.Windows.Forms.Label();
			this.decreaseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// increaseButton
			// 
			this.increaseButton.Font = new System.Drawing.Font("Fira Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.increaseButton.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.increaseButton.Location = new System.Drawing.Point(40, 95);
			this.increaseButton.Name = "increaseButton";
			this.increaseButton.Size = new System.Drawing.Size(198, 50);
			this.increaseButton.TabIndex = 0;
			this.increaseButton.Text = "Increase";
			this.increaseButton.UseVisualStyleBackColor = true;
			this.increaseButton.Click += new System.EventHandler(this.increaseButton_Click);
			// 
			// counter
			// 
			this.counter.AutoSize = true;
			this.counter.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.counter.Location = new System.Drawing.Point(285, 101);
			this.counter.Name = "counter";
			this.counter.Size = new System.Drawing.Size(35, 37);
			this.counter.TabIndex = 1;
			this.counter.Text = "0";
			// 
			// decreaseButton
			// 
			this.decreaseButton.Font = new System.Drawing.Font("Fira Code", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.decreaseButton.Location = new System.Drawing.Point(40, 168);
			this.decreaseButton.Name = "decreaseButton";
			this.decreaseButton.Size = new System.Drawing.Size(198, 55);
			this.decreaseButton.TabIndex = 2;
			this.decreaseButton.Text = "Decrease";
			this.decreaseButton.UseVisualStyleBackColor = true;
			this.decreaseButton.Click += new System.EventHandler(this.decreaseButton_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.decreaseButton);
			this.Controls.Add(this.counter);
			this.Controls.Add(this.increaseButton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button increaseButton;
		private System.Windows.Forms.Label counter;
		private System.Windows.Forms.Button decreaseButton;
	}
}

