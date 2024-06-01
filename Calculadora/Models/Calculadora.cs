using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Calculadora.Models
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();
            // Com o this se referencia o de fora
            this.data = data;
        }

        public double Somar(double n1, double n2)
        {
            double res = n1 + n2;

            listaHistorico.Insert(0, "Resultado:" + res + " - Data: " + data);
            
            return res;
        }

        public double Subtrair(double n1, double n2)
        {
            double res = n1 - n2;

            listaHistorico.Insert(0, "Resultado:" + res + " - Data: " + data);
            
            return res;
        }

        public double Multiplicar(double n1, double n2)
        {
            double res = n1 * n2;

            listaHistorico.Insert(0, "Resultado:" + res + " - Data: " + data);
            
            return res;
        }

        public double Dividir(double n1, double n2)
        {
            double res = n1 / n2;

            listaHistorico.Insert(0, "Resultado:" + res + " - Data: " + data);
            
            return res;
        }

        public List<string> HistoricoDeOperacoes()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);
            return listaHistorico;
        }
    }
}