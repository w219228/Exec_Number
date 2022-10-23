using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入0跟1之外的正整數");
			string num = Console.ReadLine();
			bool isInt = int.TryParse(num, out int n1);

			if (isInt && n1 > 1)
			{
				for (int i = 2; i < n1; i++)
				{
					if (n1 % i == 0)
					{
						Console.WriteLine("不是質數");
						Console.WriteLine($"因為它可以被{i}整除");
						return;
					}
				}
				Console.WriteLine("它是質數");
			}
			else
			{
				Console.WriteLine("請輸入0跟1之外的正整數");
			}
		}
	}
}
