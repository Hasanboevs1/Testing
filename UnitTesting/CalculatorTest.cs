using Xunit;

namespace UnitTesting;


public class CalculatorTest
{
     [Fact]
    public void Add_ShouldReturnSumOfTwoNumbers()
    {
        var calculator = new Calculator();
        int number1 = 5;
        int number2 = 10;

        int result = calculator.Add(number1, number2);

        Assert.Equal(15, result);
    }
}
