namespace Zork_Builder
{
	partial class ZorkBuilder
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
			System.Windows.Forms.Label fileLabel;
			this.filenameTextBox = new System.Windows.Forms.TextBox();
			this.selectFileButton = new System.Windows.Forms.Button();
			this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
			fileLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// filenameTextBox
			// 
			this.filenameTextBox.Location = new System.Drawing.Point(31, 6);
			this.filenameTextBox.Name = "filenameTextBox";
			this.filenameTextBox.ReadOnly = true;
			this.filenameTextBox.Size = new System.Drawing.Size(1226, 20);
			this.filenameTextBox.TabIndex = 0;
			// 
			// fileLabel
			// 
			fileLabel.AutoSize = true;
			fileLabel.Location = new System.Drawing.Point(2, 10);
			fileLabel.Name = "fileLabel";
			fileLabel.Size = new System.Drawing.Size(26, 13);
			fileLabel.TabIndex = 1;
			fileLabel.Text = "File:";
			// 
			// selectFileButton
			// 
			this.selectFileButton.Location = new System.Drawing.Point(1263, 5);
			this.selectFileButton.Name = "selectFileButton";
			this.selectFileButton.Size = new System.Drawing.Size(75, 23);
			this.selectFileButton.TabIndex = 2;
			this.selectFileButton.Text = "...";
			this.selectFileButton.UseVisualStyleBackColor = true;
			this.selectFileButton.Click += new System.EventHandler(this.SelectFileButton_Click);
			// 
			// openFileDialog
			// 
			this.openFileDialog.Filter = "World Files (*.json)|*.json";
			// 
			// ZorkBuilder
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1350, 729);
			this.Controls.Add(this.selectFileButton);
			this.Controls.Add(fileLabel);
			this.Controls.Add(this.filenameTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximizeBox = false;
			this.Name = "ZorkBuilder";
			this.Text = "ZorkBuilder";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.ZorkBuilder_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox filenameTextBox;
		private System.Windows.Forms.Button selectFileButton;
		private System.Windows.Forms.OpenFileDialog openFileDialog;
	}
}

