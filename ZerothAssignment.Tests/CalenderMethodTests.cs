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
    public void Returns_0_isnt_leap_year()
    {
        var calender = new GregorianCalender();

        var result = calender.IsLeapYear(0);

        result.Should().Be(false);
    }
}