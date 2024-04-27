namespace testPrueba;

public class UnitTest1
{
    [Theory]
    [InlineData(1,2,3)]
    [InlineData(2,2,4)]
    [InlineData(3,2,5)]
    [InlineData(6,3,9)]
    [InlineData(3,5,8)]
    public void testSuma(int a, int b, int esperado)
    {
        //AAA
        //arrange
        int resultado;
        Operacion mOperacion = new Operacion()
        //act
        resultado=mOperacion.sumar(a,b)
        
        //assert
        Assert.Equal(resultado, esperado)

    }
}