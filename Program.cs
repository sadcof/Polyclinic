using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polyclinic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int minutesInHour = 60;
            int minutesInCabinet = 10;

            Console.Write("Сочувствую! Вы оказались в поликлинике! Введите количество бабулек, что перед вами: ");
            int grannysCount = Convert.ToInt32(Console.ReadLine());

            int timeInLineCalculation = grannysCount * minutesInCabinet;
            int waitingHours = timeInLineCalculation / minutesInHour;
            int waitingMinutes = timeInLineCalculation % minutesInHour;

            Console.WriteLine($"Ваше время ожидания в очереди: {waitingHours} ч {waitingMinutes} мин");
            Console.ReadKey();
        }
    }
}
