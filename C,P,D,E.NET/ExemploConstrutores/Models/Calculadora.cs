namespace ExemploConstrutores.Models
{
    public class Calculadora
    {
        //declarando delegate que sera usado para o event
        public delegate void DelegateCalculadora();

        //Declarando evento
        public static event DelegateCalculadora EventoCalculadora;
        public static void Somar(int x, int y)
        {
            if(EventoCalculadora != null)
            {
                System.Console.WriteLine($"Adicao: {x + y}");
                EventoCalculadora();
            }
            else
            {
                System.Console.WriteLine("Nenhum escrito");
            }
            
        }

        public static void Subtrair(int x, int y)
        {
            System.Console.WriteLine($"Subtracao: {x - y}");
        }
    }
}