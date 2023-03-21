using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6º_Aula_Metodos_com_retorno.Classes
{
    class ClasseC
    {
        // Método com retorno e com parâmetro
        // Método com retorno int
        public int soma(int f1, int f2)
        {
            int res_soma = f1 + f2;
            return res_soma;
        }

        // Método com retorno double
        public double calculo_media(double d1, double d2, double d3)
        {
            double res_media = (d1 + d2 + d3) / 3;
            return res_media;
        }

        // Método com retorno string
        public string nome_completo(string nome, string sobrenome)
        {
            string nome_completo = nome + " " + sobrenome;
            return nome_completo;
        }
    }
}
