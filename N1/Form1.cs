using System;
using System.Windows.Forms;

namespace N1
{
	public partial class Form1 : Form
	{
		Slip slip;

		public Form1()
		{
			this.StartPosition = FormStartPosition.CenterScreen;
			InitializeComponent();
		}

		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			switch (e.KeyData)
			{
				case Keys.Left:
					movemode = 1;
					break;
				case Keys.Right:
					movemode = 2;
					break;
				default:
					break;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			slip = new Slip(this);
		}

		private void Form1_Paint(object sender, PaintEventArgs e)
		{
			slip.Draw(e.Graphics, BackColor);
		}

		int movemode = 0;
		private void timer1_Tick(object sender, EventArgs e)
		{
			switch (movemode)
			{
				case 1:
					if (!slip.MoveLeft(this))
						movemode = 2;
					return;
				case 2:
					if (!slip.MoveRight(this))
						movemode = 1;
					return;
			}
		}
    }
}
