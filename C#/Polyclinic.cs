using System;
 
namespace DZ_Polyclinic
{
    class Program
    {
        static void Main(string[] args)
        {
            int quantityOldWomans;
            int totalWaitingTime;
            int timeForAppointment = 10;
            
 
            Console.WriteLine("Вы пришли в поликлинику на прием к врачу, сколько старушек стоит перед вами?");
            quantityOldWomans = Convert.ToInt32(Console.ReadLine());
 
            totalWaitingTime = timeForAppointment * quantityOldWomans;
            int waitingTimeHours = totalWaitingTime / 60;
            int waitTimeMinutes = totalWaitingTime % 60;
 
 
 
            Console.WriteLine($"Время ожидания в очереди: {waitingTimeHours} часа(ов) и {waitTimeMinutes} минут(ы)");
 
            Console.ReadLine();
 
        }
    }
}
