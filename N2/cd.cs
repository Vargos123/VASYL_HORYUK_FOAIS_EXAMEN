﻿using System;
using System.Collections.Generic;
using System.Text;

namespace N2
{
    class cd
    {

		public double BaseRadius
		{
			get;
		}
		public double Height
		{
			get;
		}
		public double BaseArea
		{
			get => BaseRadius * BaseRadius * Math.PI;
		}
		public virtual double Volume
		{
			get => BaseArea * Height / 3;
		}

		public cd(double height, double baseradius)
		{
			if (baseradius < 0 || height < 0)
				throw new ArgumentOutOfRangeException();
			BaseRadius = baseradius;
			Height = height;
		}

		public virtual void ShowInfo()
		{
			Console.WriteLine("Висота: {0}", Height);
			Console.WriteLine("Радіус нижньої основи: {0}", BaseRadius);
			Console.WriteLine("Площа нижньої основи: {0}", BaseArea);
			Console.WriteLine("Об'єм: {0}", Volume);
		}
	}
}
