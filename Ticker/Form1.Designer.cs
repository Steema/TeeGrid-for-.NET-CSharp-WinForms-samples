﻿namespace TeeGrid_WinForm_Ticker
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
			this.components = new System.ComponentModel.Container();
			TeeGrid.WinForm.Painter.GdiPlusPainter tGdiPlusPainter2 = new TeeGrid.WinForm.Painter.GdiPlusPainter();
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.LSpeed = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.tBSpeed = new System.Windows.Forms.TrackBar();
			this.splitContainer2 = new System.Windows.Forms.SplitContainer();
			this.tTeeGrid1 = new TeeGrid.WinForm.Grid.TeeGrid();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.tBSpeed)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
			this.splitContainer2.Panel1.SuspendLayout();
			this.splitContainer2.Panel2.SuspendLayout();
			this.splitContainer2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.LSpeed);
			this.splitContainer1.Panel1.Controls.Add(this.label1);
			this.splitContainer1.Panel1.Controls.Add(this.tBSpeed);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
			this.splitContainer1.Size = new System.Drawing.Size(402, 484);
			this.splitContainer1.SplitterDistance = 58;
			this.splitContainer1.TabIndex = 0;
			// 
			// LSpeed
			// 
			this.LSpeed.AutoSize = true;
			this.LSpeed.Location = new System.Drawing.Point(322, 19);
			this.LSpeed.Name = "LSpeed";
			this.LSpeed.Size = new System.Drawing.Size(44, 13);
			this.LSpeed.TabIndex = 2;
			this.LSpeed.Text = "LSpeed";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(7, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(79, 13);
			this.label1.TabIndex = 1;
			this.label1.Text = "Refresh speed:";
			// 
			// tBSpeed
			// 
			this.tBSpeed.LargeChange = 50;
			this.tBSpeed.Location = new System.Drawing.Point(92, 7);
			this.tBSpeed.Maximum = 2000;
			this.tBSpeed.Minimum = 1;
			this.tBSpeed.Name = "tBSpeed";
			this.tBSpeed.Size = new System.Drawing.Size(190, 45);
			this.tBSpeed.SmallChange = 10;
			this.tBSpeed.TabIndex = 0;
			this.tBSpeed.Value = 150;
			this.tBSpeed.Scroll += new System.EventHandler(this.TBSpeed_Scroll);
			// 
			// splitContainer2
			// 
			this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer2.Location = new System.Drawing.Point(0, 0);
			this.splitContainer2.Name = "splitContainer2";
			this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer2.Panel1
			// 
			this.splitContainer2.Panel1.Controls.Add(this.tTeeGrid1);
			// 
			// splitContainer2.Panel2
			// 
			this.splitContainer2.Panel2.Controls.Add(this.label2);
			this.splitContainer2.Size = new System.Drawing.Size(402, 422);
			this.splitContainer2.SplitterDistance = 231;
			this.splitContainer2.TabIndex = 0;
			// 
			// tTeeGrid1
			// 
			this.tTeeGrid1.Data = null;
			this.tTeeGrid1.DataSource = null;
			this.tTeeGrid1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tTeeGrid1.Location = new System.Drawing.Point(0, 0);
			this.tTeeGrid1.Name = "tTeeGrid1";
			this.tTeeGrid1.Painter = tGdiPlusPainter2;
			this.tTeeGrid1.Size = new System.Drawing.Size(402, 231);
			this.tTeeGrid1.TabIndex = 0;
			this.tTeeGrid1.Text = "tTeeGrid1";
			// 
			// timer1
			// 
			this.timer1.Interval = 150;
			this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(77, 78);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(234, 26);
			this.label2.TabIndex = 0;
			this.label2.Text = "Missing Ticker Editor";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(402, 484);
			this.Controls.Add(this.splitContainer1);
			this.Name = "Form1";
			this.Text = "TeeGrid Ticker";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.tBSpeed)).EndInit();
			this.splitContainer2.Panel1.ResumeLayout(false);
			this.splitContainer2.Panel2.ResumeLayout(false);
			this.splitContainer2.Panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
			this.splitContainer2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.SplitContainer splitContainer2;
		private TeeGrid.WinForm.Grid.TeeGrid tTeeGrid1;
		private System.Windows.Forms.Label LSpeed;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.TrackBar tBSpeed;
		private System.Windows.Forms.Label label2;
	}
}
