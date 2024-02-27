using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clinic
{
	internal class Clinic
	{
		static void Main(string[] args)
		{
			int timeReceipt = 10;
			int minutesInHour = 60;

			Console.Write("Введите кол - во старушек: ");
			int numberOldLadies = Convert.ToInt32(Console.ReadLine());

			int timeInLine = timeReceipt * numberOldLadies;
			int hoursInLine = timeInLine / minutesInHour;
			int minutesInLine = timeInLine % minutesInHour;

			if (hoursInLine > 0)
				Console.WriteLine($"Вы должны отстоять в очереди {hoursInLine} часа и {minutesInLine} минут.");
			else
				Console.WriteLine($"Вы должны отстоять в очереди {minutesInLine} минут.");
		}
	}
}
