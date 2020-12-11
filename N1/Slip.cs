using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;

namespace N1
{
	class Slip
	{
		protected float Pos_X
		{
			get; set;
		}
		protected float Pos_Y
		{
			get; set;
		}
		protected float Size
		{
			get; set;
		}
		protected Pen Outline
		{
			get; set;
		}
		protected Brush FillBrush
		{
			get; set;
		}

		public Slip(Form window)
		{
			Pos_X = 200.5F;
			Pos_Y = 200.5F;
			Form2 f = new Form2();
			if (f.ShowDialog() == DialogResult.OK)
			{
				Size = f.ObjSize;
				Outline = new Pen(Color.Black, 2);
				FillBrush = new SolidBrush(f.ObjColour);
			}
			else
			{
				window.Close();
			}
		}

		public virtual void Draw(Graphics g, Color bgcolor)
		{
			g.Clear(bgcolor);
			g.SmoothingMode = SmoothingMode.HighQuality;
			g.DrawRectangle(Outline, Pos_X, Pos_Y, Size, Size);
			g.FillRectangle(FillBrush, Pos_X, Pos_Y, Size, Size);
		}
		public virtual bool MoveRight(Form window)
		{
			if (Pos_X < window.Width - Size - 17)
			{
				Pos_X++;
				window.Invalidate();
				return true;
			}
			return false;
		}

		public virtual bool MoveLeft(Form window)
		{
			if (Pos_X > 0)
			{
				Pos_X--;
				window.Invalidate();
				return true;
			}
			return false;
		}
	}
}
