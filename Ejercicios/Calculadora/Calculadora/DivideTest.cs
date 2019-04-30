using Xunit;

namespace Calculadora
{
    public class DivideTests
    {
        //Dividir es definir las veces que puedo restaarle al primer número el segundo número, el resto debe ser mayor o igual al segundo número para seguir restando.
        public int Divide(int first, int second)
        {
            //restar al primer número el segundo número
            var resto = first - second;
            return 1;
            //verificar que resto sea menor al segundo número
            //si es mayor o igual al segundo núemro, seguir iterando
            //si es menor al segundo número, stop
        }
        [Fact]
        public void OneTimesOneIsOne()
        {
            Assert.Equal(1, Divide(1, 1));
        }
    }

}

