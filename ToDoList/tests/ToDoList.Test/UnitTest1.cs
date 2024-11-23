namespace ToDoList.Test;

public class UnitTest1
{
    [Fact]
    public void Test1()
    {
        //Arrange
        var calculator = new Calculator();

        //Act
        var result = calculator.Divide(10, 5);

        //Assert
        Assert.Equal(2, result);
    }
}

public class Calculator
{
    public int Divide(int dividend, int divisor)
    {
        return dividend / divisor;
    }
}