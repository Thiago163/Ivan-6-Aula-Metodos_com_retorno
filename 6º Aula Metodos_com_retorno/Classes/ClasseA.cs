using _6º_Aula_Metodos_com_retorno.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6º_Aula_Metodos_com_retorno
{
    class ClasseA
    {
        static void Main(string[] args)
        {
            // chamada dos métodos retorno e sem parâmetros
            ClasseB dududu = new ClasseB();

            Console.WriteLine(
                "\n\t" + dududu.nome_programa() + "\n");

            Console.WriteLine("O resultado da soma é: " + dududu.soma());
            Console.WriteLine("O resultado da média é: " + dududu.calculo_media());
            
            ClasseC dadada = new ClasseC();

            int g1 = 300, g2 = 500;
            double n1 = 5, n2 = 90, n3 = 400;

            Console.WriteLine(
                "\n\n\t Chamada dos métodos com retorno e com parametro \n");

            Console.WriteLine("O resultado da soma é: " + dadada.soma(g1, g2));
            Console.WriteLine("O resultado da média é: " + dadada.calculo_media(n1, n2, n3));

            Console.Write("Digite o nome: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o sobrenome: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("*\n Nome completo: " + dadada.nome_completo(nome, sobrenome));

            Console.ReadKey();
        }
    }
}
