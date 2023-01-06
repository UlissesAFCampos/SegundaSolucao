namespace _01_ComandosCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int idade = 18;
            double altura = 1.60;

            //operadores lógicos e (&&) ou (||)
            //comando if  -  Se (teste Verdadeiro) 
            if ((idade >= 18) && (altura > 1.50))
            {
                Console.WriteLine("Pode entrar");
            }
            else
            {
                Console.WriteLine("Não pode entrar");
            }
        }
    }
}