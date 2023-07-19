using System;

namespace EnumExcersises
{
    class Program
    {
        static void Main(string[] args)
        {
            DayOfWeek day = DayOfWeek.Monday;
            GetNextDay(day);
        }

             public enum DayOfWeek
        {
            Monday,
            Tuseday,
            Wednsday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        public static void GetNextDay(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Monday:
                    Console.WriteLine("Tuseday");
                    break;

                case DayOfWeek.Tuseday:
                    Console.WriteLine("Wednsday");
                    break;

                case DayOfWeek.Wednsday:
                    Console.WriteLine("Thursday");
                    break;

                case DayOfWeek.Thursday:
                    Console.WriteLine("Friday");
                    break;

                case DayOfWeek.Friday:
                    Console.WriteLine("Saturday");
                    break;

                case DayOfWeek.Saturday:
                    Console.WriteLine("Sunday");
                    break;

                case DayOfWeek.Sunday:
                    Console.WriteLine("Monday");
                    break;
            }
        }
    }
}



