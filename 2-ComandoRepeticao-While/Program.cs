namespace _2_ComandoRepeticao_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tabuada;
            Console.Write("Qual a tabuada?");
            tabuada = Convert.ToInt32(Console.ReadLine());
            string valor = string.Empty;
            

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine("{0} X {1} = {2}",tabuada, i, i * tabuada);
            }
        }
    }
}