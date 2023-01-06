using static System.Net.Mime.MediaTypeNames;

namespace Exerc01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Quero Cadastrar 2 alunos e suas duas notas
            //Quero calcular a média destas notas
            //Se média > 6 = aprovado senão reprovado

            string aluno1 = "Ulisses";
            string aluno2 = "Campos";

            double a1n1 = 8;
            double a1n2 = 8;
            double a2n1 = 4;
            double a2n2 = 4;

            double ma1 = (a1n1 + a1n2)/2;
            double ma2 = (a2n1 + a2n2)/2;

            if (ma1 > 6)
            {
                Console.WriteLine("Aprovado");
            }
            else                
            {
                Console.WriteLine("Reprovado");
            }

            if (ma2 > 6) 
            {
                Console.WriteLine("Aprovado");
            } 
            else 
            {
                Console.WriteLine("Reprovado");
            }

            Console.WriteLine($"Média aluno: {aluno1} - {ma1}");
            Console.WriteLine($"Média aluno: {aluno2} - {ma2}");


        }
    }
}