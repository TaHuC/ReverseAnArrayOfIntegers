using System;

namespace ReverseAnArrayOfIntegers
{
	class MainClass
	{
		public static void Main()
		{
			var getNum = int.Parse(Console.ReadLine());

			var createArray = new int[getNum];

			for (var i = 0; i < getNum; i++)
			{
				createArray[getNum - i - 1] = int.Parse(Console.ReadLine());
			}

			for (var i = 0; i < getNum; i++)
			{
				if (i == getNum - 1)
				{
					Console.Write(createArray[i]);
				}
				else
				{
					Console.Write($"{createArray[i]} ");
				}
			}
		}
	}
}
