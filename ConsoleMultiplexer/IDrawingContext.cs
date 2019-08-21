﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleMultiplexer
{
	public interface IDrawingContext
	{
		Size Size { get; }

		void Set(Position position, Character character);
		void Flush();
		void Clear();
	}
}
