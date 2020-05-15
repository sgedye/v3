using Xunit;

public class BirdCountTests
{
    [Fact]
    public void LastWeek()
    {
        Assert.Equal(new int[] { 0, 2, 5, 3, 7, 8, 4 }, BirdCount.LastWeek());
    }

    [Fact]
    public void TodayForDisappointingDay()
    {
        var counts = new int[] { 0, 0, 1, 0, 0, 1, 0 };
        var birdCount = new BirdCount(counts);
        Assert.Equal(0, birdCount.Today());
    }

    [Fact]
    public void TodayForBusyDay()
    {
        var counts = new int[] { 8, 8, 9, 5, 4, 7, 10 };
        var birdCount = new BirdCount(counts);
        Assert.Equal(10, birdCount.Today());
    }

    [Fact]
    public void HasDayWithoutBirdsWithDayWithoutBirds()
    {
        var counts = new int[] { 5, 5, 4, 0, 7, 6, 7 };
        var birdCount = new BirdCount(counts);
        Assert.True(birdCount.HasDayWithoutBirds());
    }

    [Fact]
    public void HasDayWithoutBirdsWithNoDayWithoutBirds()
    {
        var counts = new int[] { 4, 5, 9, 10, 9, 4, 3 };
        var birdCount = new BirdCount(counts);
        Assert.False(birdCount.HasDayWithoutBirds());
    }

    [Fact]
    public void IncrementTodaysCountWithNoPreviousVisits()
    {
        var counts = new int[] { 0, 0, 0, 4, 2, 3, 0 };
        var birdCount = new BirdCount(counts);
        birdCount.IncrementTodaysCount();
        Assert.Equal(1, birdCount.Today());
    }

    [Fact]
    public void IncrementTodaysCountWithMultiplePreviousVisits()
    {
        var counts = new int[] { 8, 8, 9, 2, 1, 6, 4 };
        var birdCount = new BirdCount(counts);
        birdCount.IncrementTodaysCount();
        Assert.Equal(5, birdCount.Today());
    }

    [Fact]
    public void TotalForDisappointingWeek()
    {
        var counts = new int[] { 0, 0, 1, 0, 0, 1, 0 };
        var birdCount = new BirdCount(counts);
        Assert.Equal(2, birdCount.Total());
    }

    [Fact]
    public void TotalForBusyWeek()
    {
        var counts = new int[] { 5, 9, 12, 6, 8, 8, 17 };
        var birdCount = new BirdCount(counts);
        Assert.Equal(65, birdCount.Total());
    }

    [Fact]
    public void BusyDaysForDisappointingWeek()
    {
        var counts = new int[] { 1, 1, 1, 0, 0, 0, 0 };
        var birdCount = new BirdCount(counts);
        Assert.Equal(0, birdCount.BusyDays());
    }

    [Fact]
    public void BusyDaysForBusyWeek()
    {
        var counts = new int[] { 4, 9, 5, 7, 8, 8, 2 };
        var birdCount = new BirdCount(counts);
        Assert.Equal(5, birdCount.BusyDays());
    }
}
