using System;
namespace N3
{
	class Matrix
	{
		protected int[,] mat;
		protected int width;
		protected int height;

		public Matrix(int width, int height)
		{
			if (width < 1 || height < 1)
			{
				throw new ArgumentOutOfRangeException();
			}
			mat = new int[width, height];
			this.width = width;
			this.height = height;
		}

		public virtual void Edit()
		{
			Show();
			var fgc = Console.ForegroundColor;
			var bgc = Console.BackgroundColor;
			var x = 0;
			var y = 0;
			var currentline = Console.CursorTop;
			Console.CursorVisible = false;
			while (Console.KeyAvailable)
				Console.ReadKey();
			for (; ; )
			{
				Console.SetCursorPosition(x * 4, currentline - height + y);
				Console.BackgroundColor = fgc;
				Console.ForegroundColor = bgc;
				Console.Write("{0,4}", mat[x, y]);
				Console.ResetColor();
				Console.SetCursorPosition(0, currentline);
				ConsoleKey key = Console.ReadKey(true).Key;
				Console.SetCursorPosition(x * 4, currentline - height + y);
				Console.Write("{0,4}", mat[x, y]);
				Console.SetCursorPosition(0, currentline);
				switch (key)
				{
					case ConsoleKey.Enter:
						goto Exit;
					case ConsoleKey.LeftArrow:
						if (x > 0)
							x--;
						break;
					case ConsoleKey.UpArrow:
						if (y > 0)
							y--;
						break;
					case ConsoleKey.RightArrow:
						if (x < width - 1)
							x++;
						break;
					case ConsoleKey.DownArrow:
						if (y < height - 1)
							y++;
						break;
					case ConsoleKey.D0:
					case ConsoleKey.D1:
					case ConsoleKey.D2:
					case ConsoleKey.D3:
					case ConsoleKey.D4:
					case ConsoleKey.D5:
					case ConsoleKey.D6:
					case ConsoleKey.D7:
					case ConsoleKey.D8:
					case ConsoleKey.D9:
						if (mat[x, y] < 0)
							mat[x, y] = -mat[x, y];
						mat[x, y] = (mat[x, y] % 10 * 10) + (key - ConsoleKey.D0);
						break;
					case ConsoleKey.NumPad0:
					case ConsoleKey.NumPad1:
					case ConsoleKey.NumPad2:
					case ConsoleKey.NumPad3:
					case ConsoleKey.NumPad4:
					case ConsoleKey.NumPad5:
					case ConsoleKey.NumPad6:
					case ConsoleKey.NumPad7:
					case ConsoleKey.NumPad8:
					case ConsoleKey.NumPad9:
						if (mat[x, y] < 0)
							mat[x, y] = -mat[x, y];
						mat[x, y] = (mat[x, y] % 10 * 10) + (key - ConsoleKey.NumPad0);
						break;
					case ConsoleKey.OemMinus:
					case ConsoleKey.Subtract:
						mat[x, y] = -mat[x, y];
						break;
					default:
						break;
				}
			}
		Exit:
			Console.CursorVisible = true;
		}

		public virtual void Show()
		{
			for (var i = 0; i < height; i++)
			{
				for (var j = 0; j < width; j++)
				{
					Console.Write("{0,4}", mat[j, i]);
				}
				Console.WriteLine();
			}
		}
	}
}
