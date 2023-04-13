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
            int hour = 60;
            int minutesInCabinet = 10;

            Console.Write("Сочувствую! Вы оказались в поликлинике! Введите количество бабулек, что перед вами: ");
            int grannysCount = Convert.ToInt32(Console.ReadLine());

            int waitingHours = (grannysCount * minutesInCabinet) / hour;
            int waitingMinutes = (grannysCount * minutesInCabinet) % hour;

            Console.WriteLine($"Ваше время ожидания в очереди: {waitingHours} ч {waitingMinutes} мин");
            Console.ReadKey();
        }
    }
}
