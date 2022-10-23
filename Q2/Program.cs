using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q2
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("請輸入第一個整數");
			int num1 = Convert.ToInt32(Console.ReadLine());
			Console.WriteLine("請輸入第二個整數");
			int num2 = Convert.ToInt32(Console.ReadLine());

			for (int i = num1; i <= num2; i++)
			{
				int isPrime = 0;
				for (int k = 1; k < i; k++)
				{
					if (i % k == 0)
					{
						isPrime++;
					}
					if (isPrime == 2)
					{
						break;
					}
				}
				if (isPrime != 2)
				{ Console.WriteLine(i); }
			}
		}
	}
}
