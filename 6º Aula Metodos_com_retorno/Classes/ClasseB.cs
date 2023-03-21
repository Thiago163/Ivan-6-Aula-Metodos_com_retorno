using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6º_Aula_Metodos_com_retorno
{
    class ClasseB
    {
        // Método com retorno e sem parâmetro
        public int soma()
        {
            int h1 = 200, h2 = 300;
            int res_soma = h1 + h2;
            return res_soma;
        }

        // Método com retorno Double
        public double calculo_media()
        {
            double d1 = 200, d2 = 300, d3 = 400;
            double res_media = (d1 + d2 + d3) / 3;
            return res_media;
        }

        // Método com retorno string
        public string nome_programa()
        {
            string nome_programa = "Programa métodos c#";
            return nome_programa;
        }
    }
}
