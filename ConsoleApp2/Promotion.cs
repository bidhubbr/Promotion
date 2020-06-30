using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
	class Promotion
	{
		public static double ApplyPromotion(Char[] skuIds)
		{
			double total = 0;
			int countA = 0;
			int countB = 0;
			int countC = 0;
			int countD = 0;
			Array.Sort<char>(skuIds);			

			foreach (char skuId in skuIds)
			{
				switch (skuId)
				{
					case 'A':
						countA++; break;
					case 'B':
						countB++; break;
					case 'C':
						countC++; break;
					case 'D':
						countD++; break;
					default:
						break;
				}
			}

			// Promotion 1

			if (countA > 2)
			{
				total = (int)(countA / 3) * 130 + (countA % 3) * 50;
			}
			else
			{
				total = countA * 50;
			}

			// Promotion 2

			if (countB > 1)
			{
				total = total + (int)(countB / 2) * 45 + (countB % 2) * 30;
			}
			else
			{
				total = total + countB * 30;
			}

			// Promotion 3

			if (countC > 0)
			{
				if (countD > 0)
				{
					if (countC == countD)
					{
						total = total + countC * 30;
					}
					else if (countC > countD)
					{
						total = total + countD * 30 + (countC - countD) * 20;
					}
					else
					{
						total = total + countC * 30 + (countD - countC) * 15;
					}
				}
				else
				{
					total = total + countC * 20;
				}
			}
			else if (countD > 0)
			{
				total = total + countD * 15;
			}

			return total;
		}
	}
}
