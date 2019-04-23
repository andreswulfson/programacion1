using Xunit;

namespace Calculadora
{
    public class MultiplicateTests
    {
        // Mutiplicar es sumar el primer numero las veces que indique el segundo número siendo ambos números enteros y menores a 100
        public int Multiplicate(int first, int second)
        {
            var result = 0;
            for (var i = 0; i < second; i++)
            {
                result = result + first;
            }
            return result;
           

        }

     //En lenguaje natural dividir dos numeros enteros menores que 100 (ejercicio)
     //En lenguaje natural potenciar dos numeros enteros menores a 100 (ejercicio)

        [Fact]
        public void OneTimesOneIsOne()
        {
            Assert.Equal(1, Multiplicate(1, 1));
        }

        [Fact]
        public void OneTimesTwoIsTwo()
        {
            Assert.Equal(2, Multiplicate(1, 2));
        }

        [Fact]
        public void FiveTimesElevenIsFiftyFive()
        {
            Assert.Equal(55, Multiplicate(5, 11));
        }

        [Fact]
        public void ZeroTimesZeroIsZero()
        {
            Assert.Equal(0, Multiplicate(0, 0));
        }

        [Fact]
        public void MillonTimesMillionIsBillon()
        {
            Assert.Equal(100000000, Multiplicate(10000, 10000));
        }
    }
}


