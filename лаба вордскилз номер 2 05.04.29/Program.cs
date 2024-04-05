using System;
internal class Program
{
    private static void Main(string[] args)
    {
        int d = Convert.ToInt32(Console.ReadLine());
        if (d == 1)
        { PrintM(Weekdeys.Monday); }
        else if (d == 2)
        { PrintM(Weekdeys.Tuesday); }
        else if (d == 3)
        { PrintM(Weekdeys.Wednesday); }
        else if (d == 4)
        { PrintM(Weekdeys.Thursday); }
        else if (d == 5)
        { PrintM(Weekdeys.Friday); }
        else if (d == 6)
        { PrintM(Weekdeys.Saturday); }
        else if (d == 7)
        { PrintM(Weekdeys.Sunday); }
        else { 
            Console.WriteLine( "неккоректные данные!!!!!!!");
            Environment.Exit(0);
        }
        void PrintM(Weekdeys weekdeys)
        {
            switch (weekdeys)
            {
                case Weekdeys.Monday:
                    Console.WriteLine("понедельник");
                    break;
                case Weekdeys.Tuesday:
                    Console.WriteLine("вторник");
                    break;
                case Weekdeys.Wednesday:
                    Console.WriteLine("среда");
                    break;
                case Weekdeys.Thursday:
                    Console.WriteLine("четверг");
                    break;
                case Weekdeys.Friday:
                    Console.WriteLine("пятница");
                    break;
                case Weekdeys.Saturday:
                    Console.WriteLine("суббота");
                    break;
                case Weekdeys.Sunday:
                    Console.WriteLine("воскресенье");
                    break;
            }
        }
        int t = Convert.ToInt32(Console.ReadLine());
        if (t >= 7 && t <= 12)
        { PrintMessage(DayTime.Morning); }
        else if (t >= 13 && t <= 18)
        { PrintMessage(DayTime.Afternoon); }
        else if (t >= 19 && t <= 23)
        { PrintMessage(DayTime.Evening); }
        else if (t >= 0 && t <= 6)
        { PrintMessage(DayTime.Night); }
        else { Console.WriteLine("неккоректные данные!!!!!!!!");
            Environment.Exit(0);
        }
        void PrintMessage(DayTime dayTime)
{
            switch (dayTime)
            {
                case DayTime.Morning:
                    Console.WriteLine("cейчас утро");
                    break;
                case DayTime.Afternoon:
                    Console.WriteLine("cейчас день");
                    break;
                case DayTime.Evening:
                    Console.WriteLine("cейчас вечер");
                    break;
                case DayTime.Night:
                    Console.WriteLine("cейчас ночь");
                    break;
            }
        }
    }
}
enum Weekdeys
{
    Monday,
    Tuesday,
    Wednesday, 
    Thursday,
    Friday,
    Saturday,
    Sunday
}
enum DayTime
{
    Morning,
    Afternoon,
    Evening,
    Night
}
