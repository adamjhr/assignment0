namespace ZerothAssignment.Tests;

public class LeapYearConsoleTests {

    [Fact]
    public void Returns_4_is_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("4");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }


}