using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] { 0, 2, 5, 3, 7, 8, 4 };
    }

    public int Today()
    {
        return birdsPerDay[6];
    }

    public void IncrementTodaysCount()
    {
        birdsPerDay[6]++;
    }

    public bool HasDayWithoutBirds()
    {
        return Array.IndexOf(birdsPerDay, 0) != -1;
    }

    public int Total()
    {
        var total = 0;

        foreach (var count in birdsPerDay)
        {
            total += count;
        }

        return total;
    }

    public int BusyDays()
    {
        var days = 0;

        foreach (var count in birdsPerDay)
        {
            if (count >= 5)
            {
                days++;
            }
        }

        return days;
    }
}
