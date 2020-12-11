﻿using System;
using System.Collections.Generic;
using System.Text;

namespace N2
{
    class cd2: cd
    {
		public double FrustrumRadius
		{
			get;
		}
		public override double Volume
		{
			get
			{
				var r =
					BaseRadius * BaseRadius +
					BaseRadius * FrustrumRadius +
					FrustrumRadius * FrustrumRadius;
				return Height * r * Math.PI / 3;
			}
		}

		public cd2(double height, double baseradius, double frustrumradius)
			: base(baseradius, height)
		{
			if (frustrumradius < 0)
				throw new ArgumentOutOfRangeException();
			FrustrumRadius = frustrumradius;
		}

		public override void ShowInfo()
		{
			Console.WriteLine("Висота: {0}", Height);
			Console.WriteLine("Радіус нижньої основи: {0}", BaseRadius);
			Console.WriteLine("Площа нижньої основи: {0}", BaseArea);
			Console.WriteLine("Радіус верхньої основи: {0}", FrustrumRadius);
			Console.WriteLine("Об'єм: {0}", Volume);
		}
	}
}
