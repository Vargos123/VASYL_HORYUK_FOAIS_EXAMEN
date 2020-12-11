using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace N1
{
	public partial class Form2 : Form
	{
		public int ObjSize
		{
			get; private set;
		}
		public Color ObjColour
		{
			get; private set;
		}

		public Form2()
		{
			this.StartPosition = FormStartPosition.CenterScreen;
			ObjSize = 99;
			ObjColour = Color.Red;
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			ObjSize = (int)numericUpDown1.Value;
		}
    }
}
