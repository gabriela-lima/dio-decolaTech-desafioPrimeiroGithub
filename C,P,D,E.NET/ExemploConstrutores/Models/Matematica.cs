namespace ExemploConstrutores.Models
{
    public class Matematica
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Matematica(int x, int y)
        {
            X = x;
            Y = y;

            //Inscrevendo o metodo EventHandler no evento da calculadora
            //quando o evento for chamado vai executar o metodo EventHandler
            Calculadora.EventoCalculadora += EventHandler;
        }

        public void Somar()
        {
            Calculadora.Somar(X, Y);
        }

        public void EventHandler()
        {
            System.Console.WriteLine("Metodo executado");
        }
    }
}