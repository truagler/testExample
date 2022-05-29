using System;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
	internal class Program
	{
		public static void Main(string[] args)
		{
			String number = Console.ReadLine();

			if (number != null)
			{
				Int32[] mass = number.Select(n =>Int32.Parse(n.ToString())).ToArray();
				
				Int32 sum = 0;
				
				for (int i = 0; i < mass.Length; i++)
				{
					sum = mass[i] + sum;
						
					if (i == mass.Length - 1)
					{
						if (sum.ToString().Length > 1)
						{
							i = -1;
							mass = sum.ToString().Select(n => Int32.Parse(n.ToString())).ToArray();
							sum = 0;
						}
					}
				}
				Console.WriteLine(sum);
			}
		}

		public static void SortMassive()
		{
			String number = Console.ReadLine();

			if (number != null)
			{
				Int32[] mass = number.Select(n =>Int32.Parse(n.ToString())).ToArray();
				
				Array.Sort(mass);
				Array.Reverse(mass);
				String newArr = String.Concat(mass);
				Console.WriteLine(newArr);
			}
		}
	}
}