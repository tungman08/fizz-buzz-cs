namespace FizzBuzz.Test;

public class UnitTest
{
    [Fact]
    public void Returns_1_For_The_Number_1()
    {
        var result = FizzBuzzService.Generate(1);
        Assert.Equal("1", result);
    }

    [Fact]
    public void Returns_7_For_The_Number_7()
    {
        var result = FizzBuzzService.Generate(7);
        Assert.Equal("7", result);
    }

    [Fact]
    public void Returns_Fizz_For_The_Number_3()
    {
        var result = FizzBuzzService.Generate(3);
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void Returns_Fizz_For_The_Number_9()
    {
        var result = FizzBuzzService.Generate(9);
        Assert.Equal("Fizz", result);
    }

    [Fact]
    public void Returns_Buzz_For_The_Number_5()
    {
        var result = FizzBuzzService.Generate(5);
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void Returns_Buzz_For_The_Number_10()
    {
        var result = FizzBuzzService.Generate(10);
        Assert.Equal("Buzz", result);
    }

    [Fact]
    public void Returns_FizzBuzz_For_The_Number_15()
    {
        var result = FizzBuzzService.Generate(15);
        Assert.Equal("FizzBuzz", result);
    }

    [Fact]
    public void Returns_FizzBuzz_For_The_Number_30()
    {
        var result = FizzBuzzService.Generate(30);
        Assert.Equal("FizzBuzz", result);
    }
}