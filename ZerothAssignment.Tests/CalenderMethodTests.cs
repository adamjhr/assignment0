namespace ZerothAssignment.Tests;

public class CalenderMethodTests
{

    [Fact]
    public void Returns_2004_is_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(2004);

        result.Should().Be(true);
    }

    [Fact]
    public void Returns_32_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(32);

        result.Should().Be(false);
    }

    [Fact]
    public void Returns_1952_is_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(1952);

        result.Should().Be(true);
    }

    [Fact]
    public void Returns_2003_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(3);

        result.Should().Be(false);
    }
    
    [Fact]
    public void Returns_1842_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(1842);

        result.Should().Be(false);
    }

    [Fact]
    public void Returns_0_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(0);

        result.Should().Be(false);
    }

    [Fact]
    public void Returns_2100_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(2100);

        result.Should().Be(false);
    }

    [Fact]
    public void Returns_200_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(200);

        result.Should().Be(false);
    }

    [Fact]
    public void Returns_1700_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(1700);

        result.Should().Be(false);
    }

    [Fact]
    public void Returns_1600_is_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(1600);

        result.Should().Be(true);
    }

    [Fact]
    public void Returns_2400_is_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(2400);

        result.Should().Be(true);
    }

    [Fact]
    public void Returns_minus_2000_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(-2000);

        result.Should().Be(false);
    }
}