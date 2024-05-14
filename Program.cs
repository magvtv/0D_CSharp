using System;


class Program
{
    public static void ShowMedicineSchedule()
    {
        /* Format and display medicine times */
        int[] times = {800, 1200, 1600, 2000}; 

        foreach (int val in times)
        {
            string time = val.ToString();
            int len = time.Length;

            if (len >= 3)
            {
                time = time.Insert((len - 2), ":");
            }
            else if (len == 2)
            {
                time = time.Insert(0, "0:");
            }
            else
            {
                time = time.Insert(0, "0:0");
            }
            Console.Write($"{time}");
        }
    }

    public static void AdjustMedicineSchedule()
    {
        int[] times = {800, 1200, 1600, 2000}; 
        int diff = 0;

        for(int x = 0; x < times.Length; x++)
        {
            times[x] = (times[x] + diff) % 2400;
        }
    }

    static void Main(string[] args)
    {
        int[] times = {800, 1200, 1600, 2000};
        int diff = 0;

        Console.WriteLine("Enter current GMT");
        int currentGMT = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Current Medicine Schedule:");
        ShowMedicineSchedule();

        Console.WriteLine("Enter new GMT");
        int newGMT = Convert.ToInt32(Console.ReadLine());

        if (Math.Abs(newGMT) > 12 || Math.Abs(currentGMT) > 12)
        {
            Console.WriteLine("Invalid GMT");
        }
        else if (newGMT <= 0 && currentGMT <= 0 || newGMT >= 0 && currentGMT >= 0) 
        {
            diff = 100 * (Math.Abs(newGMT) - Math.Abs(currentGMT));
            AdjustMedicineSchedule();
        } 
        else 
        {
            diff = 100 * (Math.Abs(newGMT) + Math.Abs(currentGMT));
            AdjustMedicineSchedule();
        }
    }
}