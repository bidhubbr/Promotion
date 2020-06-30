using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp2
{
	class Program
	{
		Promotion p = new Promotion();
		static void Main(string[] args)
		{
			char ch;
			do
			{
				Console.WriteLine("Enter skuids in Cart (Only Alphabets)");
				char[] SKUIds = Console.ReadLine().ToUpper().ToCharArray();

				//char[] SKUIds = new char[] { 'A', 'B', 'C'};
				//char[] SKUIds = new char[] { 'A', 'B','C','A','A','B','A','B','B','A','B' };
				//char[] SKUIds = new char[] { 'A', 'B', 'C', 'A', 'B', 'A', 'B', 'B', 'D', 'B' };

				double amount = Promotion.ApplyPromotion(SKUIds);

				Console.WriteLine("Total order Value : " + amount);
				
				Console.WriteLine("Want to Continue(Y/N)...");
				
				ch = Console.ReadKey().KeyChar;
				Console.WriteLine("\n");


			} while (ch == 'Y' || ch == 'y');
		}
		
	}
}
