using System;

class Program
{
    static void Main()
    {
        // Replace the date of birth with the actual date
        DateTime dob = new DateTime(2001, 12, 11);

        // Calculate age
        TimeSpan ageTimeSpan = DateTime.Now - dob;
        int years = ageTimeSpan.Days / 365;
        int months = (ageTimeSpan.Days % 365) / 30;
        int weeks = ((ageTimeSpan.Days % 365) % 30) / 7;
        int days = ((ageTimeSpan.Days % 365) % 30) % 7;

        // Display the result
        Console.WriteLine($"Hello, Prajita!");
        Console.WriteLine($"Your DOB: {dob.ToLongDateString()}");
        Console.WriteLine($"Age as of now: {years} Years {months} Months {weeks} Weeks {days} Days");
    }
}
