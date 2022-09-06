namespace ZerothAssignment.Tests;

public class CalenderMethodTests
{

    [Fact]
    public void Returns_4_is_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(4);

        result.Should().Be(true);
    }

    [Fact]
    public void Returns_32_is_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(32);

        result.Should().Be(true);
    }

    [Fact]
    public void Returns_52_is_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(52);

        result.Should().Be(true);
    }

    [Fact]
    public void Returns_3_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(3);

        result.Should().Be(false);
    }
    
    [Fact]
    public void Returns_42_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(42);

        result.Should().Be(false);
    }

    [Fact]
    public void Returns_0_is_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(0);

        result.Should().Be(true);
    }

    [Fact]
    public void Returns_100_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(100);

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
    public void Returns_2200_is_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(2200);

        result.Should().Be(true);
    }
}