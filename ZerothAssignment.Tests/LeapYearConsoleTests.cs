namespace ZerothAssignment.Tests;

public class LeapYearConsoleTests {

    [Fact]
    public void Returns_2004_is_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("2004");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

    [Fact]
    public void Returns_1916_is_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1916");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

    [Fact]
    public void Returns_2400_is_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("2400");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

        
    [Fact]
    public void Returns_1200_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1200");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }
    
    [Fact]
    public void Returns_0_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("0");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]    
    public void Returns_1817_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1817");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Returns_1700_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1700");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Returns_1637_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("1637");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Returns_m_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("m");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Returns_negative_8_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("-8");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Returns_24_spelled_out_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("twenty four");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Returns_4_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("4");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }
}