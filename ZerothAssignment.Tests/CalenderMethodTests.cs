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
    
}