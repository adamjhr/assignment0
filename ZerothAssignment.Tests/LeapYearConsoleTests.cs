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

    [Fact]
    public void Returns_16_is_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("16");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

    [Fact]
    public void Returns_400_is_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("400");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

        
    [Fact]
    public void Returns_2000_is_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("2000");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }
    
    [Fact]
    public void Returns_0_is_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("0");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("yay");
    }

    [Fact]    
    public void Returns_17_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("17");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Returns_300_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("300");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }

    [Fact]
    public void Returns_637_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("637");
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
    public void Returns_twenty_four_isnt_leap_year() {

        using var writer = new StringWriter();
        Console.SetOut(writer);
        using var reader = new StringReader("24");
        Console.SetIn(reader);

        var program = Assembly.Load(nameof(ZerothAssignment));
        program.EntryPoint?.Invoke(null, new[] { Array.Empty<string>() });

        var output = writer.GetStringBuilder().ToString().TrimEnd();
        output.Should().Be("nay");
    }
}