using Xunit;
namespace Lab1
{
public class TestClass{
    [Fact]
    public void  PassingTest(){
        Assert.Equal(4, Logic.SimpleOperations(2,2,'+'));
        Assert.Equal(8, Logic.SimpleOperations(12,4,'-'));
        Assert.Equal(10, Logic.SimpleOperations(5,2,'*'));
        Assert.Equal(2, Logic.SimpleOperations(6,3,'/'));
    }
    [Theory]
    [InlineData(3,3, '+')]
    public void TheoryTest(double a, double b ,char c)
    {
        Assert.Equal(6, Logic.SimpleOperations(a,b,c));
    }
}
}