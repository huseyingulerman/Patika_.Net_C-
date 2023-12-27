namespace hazir_metotlar_datetime
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DateTime.Now); // 9/24/2021 11:00:00 AM
            Console.WriteLine(DateTime.Now.Date); // 9/24/2021 12:00:00 AM
            Console.WriteLine(DateTime.Now.Day); // 24
            Console.WriteLine(DateTime.Now.Month); // 9
            Console.WriteLine(DateTime.Now.Year); // 2021
            Console.WriteLine(DateTime.Now.Hour); // 11
            Console.WriteLine(DateTime.Now.Minute); // 0
            Console.WriteLine(DateTime.Now.Second); // 0

            Console.WriteLine(DateTime.Now.DayOfWeek); // Friday
            Console.WriteLine(DateTime.Now.DayOfYear); // 267

            Console.WriteLine(DateTime.Now.ToLongDateString()); // 24 Eylül 2021 Cuma
            Console.WriteLine(DateTime.Now.ToShortDateString()); // 24.09.2021
            Console.WriteLine(DateTime.Now.ToLongTimeString()); // 11:00:00
            Console.WriteLine(DateTime.Now.ToShortTimeString()); // 11:00

            Console.WriteLine(DateTime.Now.AddDays(2)); // 26.09.2021 11:00:00
            Console.WriteLine(DateTime.Now.AddHours(3)); // 24.09.2021 14:00:00
            Console.WriteLine(DateTime.Now.AddMonths(5)); // 24.02.2022 11:00:00
            Console.WriteLine(DateTime.Now.AddYears(10)); // 24.09.2031 11:00:00
            Console.WriteLine(DateTime.Now.AddSeconds(30)); // 24.09.2021 11:00:30

            //DateTime Format
            Console.WriteLine(DateTime.Now.ToString("dd")); // 24
            Console.WriteLine(DateTime.Now.ToString("ddd")); // Cum
            Console.WriteLine(DateTime.Now.ToString("dddd")); // Cuma

            Console.WriteLine(DateTime.Now.ToString("MM")); // 09
            Console.WriteLine(DateTime.Now.ToString("MMM")); // Eyl
            Console.WriteLine(DateTime.Now.ToString("MMMM")); // Eylül

            Console.WriteLine(DateTime.Now.ToString("yy")); // 21
            Console.WriteLine(DateTime.Now.ToString("yyyy")); // 2021

            //Math Kütüphanesi
            Console.WriteLine(Math.Abs(-25)); // 25
            Console.WriteLine(Math.Sin(10)); // -0,5440211108893698
            Console.WriteLine(Math.Cos(10)); // -0,8390715290764524
            Console.WriteLine(Math.Tan(10)); // 0,6483608274590866

            Console.WriteLine(Math.Ceiling(22.3)); // 23
            Console.WriteLine(Math.Round(22.3)); // 22
            Console.WriteLine(Math.Round(22.7)); // 23
            Console.WriteLine(Math.Floor(22.7)); // 22

            Console.WriteLine(Math.Max(2, 6)); // 6
            Console.WriteLine(Math.Min(2, 6)); // 2

            Console.WriteLine(Math.Pow(3, 4)); // 81
            Console.WriteLine(Math.Sqrt(9)); // 3
            Console.WriteLine(Math.Log(9)); // 2,1972245773362196
            Console.WriteLine(Math.Exp(3)); // 20,085536923187668
            Console.WriteLine(Math.Log10(10)); // 1
        }
    }
}