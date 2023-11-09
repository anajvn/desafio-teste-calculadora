using desafioTesteCalculadora;

namespace desafioTesteCalculadoraTests
{
    public class CalculadoraTest
    {
        // Regras de negócio: 
        // Números inteiros
        // 2 parâmetros por operação 
        // Sempre retorna as últimas 3 operações do histórico

        private Calculadora _calculadora = new Calculadora();

        [Theory]
        [InlineData(1, 2, 3)]
        [InlineData(99, 99, 198)]
        [InlineData(99998, 7, 100005)]
        public void Somar2Numeros_Usa2ValoresInteiros_RetornaSucesso(int val1, int val2, int resultadoEsperado)
        {
            int resultado = _calculadora.Somar(val1, val2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, -1)]
        [InlineData(99, 99, 0)]
        [InlineData(99998, 7, 99991)]
        public void Subtrai2Numeros_Usa2ValoresInteiros_RetornaSucesso(int val1, int val2, int resultadoEsperado)
        {
            int resultado = _calculadora.Subtrair(val1, val2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 2)]
        [InlineData(99, 0, 0)]
        [InlineData(99998, 7, 699986)]
        public void Multiplica2Numeros_Usa2ValoresInteiros_RetornaSucesso(int val1, int val2, int resultadoEsperado)
        {
            int resultado = _calculadora.Multiplicar(val1, val2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Theory]
        [InlineData(1, 2, 0)]
        [InlineData(99, 99, 1)]
        [InlineData(2, 1, 2)]
        public void Dividir2Numeros_Usa2ValoresInteiros_RetornaSucesso(int val1, int val2, int resultadoEsperado)
        {
            int resultado = _calculadora.Dividir(val1, val2);

            // Assert
            Assert.Equal(resultadoEsperado, resultado);
        }

        [Fact]
        public void DivisaoPorZero_Usa1ValoreInteiroE0_RetornaException()
        {
            Assert.Throws<DivideByZeroException>(() => _calculadora.Dividir(1, 0));
        }

        [Fact]
        public void TestaHistorico_Usa4Operacoes_RetornaAsUltimas3()
        {
            _calculadora.Somar(1, 2);
            _calculadora.Subtrair(1, 2);
            _calculadora.Multiplicar(1, 2);
            _calculadora.Dividir(1, 2);

            var resultado = _calculadora.Historico();

            Assert.NotEmpty(resultado);
            Assert.Equal(3, resultado.Count);
        }
    }
}