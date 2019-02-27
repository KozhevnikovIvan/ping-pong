namespace Ping_Pong
{
	partial class MainForm
	{

		private System.ComponentModel.IContainer components = null;
		
		
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(239, 169);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(557, 73);
			this.label1.TabIndex = 0;
			this.label1.Text = "Game Over!";
			this.label1.Visible = false;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(862, 433);
			this.Controls.Add(this.label1);
			this.MaximumSize = new System.Drawing.Size(880, 480);
			this.MinimumSize = new System.Drawing.Size(880, 480);
			this.Name = "MainForm";
			this.Text = "Ping-Pong";
			this.Paint += new System.Windows.Forms.PaintEventHandler(this.MainFormPaint);
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainFormKeyDown);
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Label label1;
	}
}
