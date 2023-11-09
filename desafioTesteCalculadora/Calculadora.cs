using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace desafioTesteCalculadora
{
    public class Calculadora
    {
        private List<string> _historico;
        public Calculadora()
        {
            _historico = new List<string>();
        }
        public int Somar(int val1, int val2)
        {
            _historico.Insert(0, $"{val1} + {val2} = {val1 + val2}");
            return val1 + val2;
        }

        public int Subtrair(int val1, int val2)
        {
            _historico.Insert(0, $"{val1} - {val2} = {val1 - val2}");
            return val1 - val2;
        }

        public int Multiplicar(int val1, int val2)
        {
            _historico.Insert(0, $"{val1} * {val2} = {val1 * val2}");
            return val1 * val2;
        }

        public int Dividir(int val1, int val2)
        {
            _historico.Insert(0, $"{val1} / {val2} = {val1 / val2}");
            return val1/val2;
        }

        public List<string> Historico()
        {
            return _historico.GetRange(0,3);
        }

    }
}
