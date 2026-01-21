using System.Timers;

namespace TestSharpProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("START THE PROJECT");

            System.Timers.Timer myTimer = new System.Timers.Timer();
            myTimer.Interval = 1000;
            myTimer.Elapsed += TimerHandler;
            myTimer.Start();

            while (true)
            {
            }
        }

        static void TimerHandler(object? sender, ElapsedEventArgs e)
        {
            Console.WriteLine(DateTime.Now.ToString());
        }
    }
}
