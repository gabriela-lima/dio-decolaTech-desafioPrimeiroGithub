using System;
using ExemploConstrutores.Models;

namespace ExemploConstrutores
{
    class Program
    {
        //fazendo delegate
        //ele pode ter retorno
        public delegate void Operacao(int x, int y);

        static void Main(string[] args)
        {
            //Mostrando Event
            //Matematica m = new Matematica(20, 20);
            //m.Somar();

            //Mostrando delegate
            //Pode passar com o new
            //Operacao op = new Operacao(Calculadora.Somar);
            //ou pode chamar direto
            //Operacao op = Calculadora.Somar;
            //multi cast delegate
            //ele nao perde a referencia do metodo anterior, ele vai chamar o somar e o subtrair, ele chama os metodos em sequencia, um apos o outro, ordem FIFO
            //o += eh para que nao perca a referencia ao metodo anterior
            //se colocar apenas o = vai apagar a referencia ao somar, colocando apenas o subtrair
            //op += Calculadora.Subtrair;
            //chamar o delegate com o invoke
            //op.Invoke(20, 20);
            //ou passar os valores de forma direta
            //op(20, 20);

            //Mostrando constante
            //so pode ser alterada durante a inicializacao e mais nenhum outro lugar
            //nao eh possivel declarar uma constante sem valor, ela precisa ser iniciada com valor
            //const double pi = 3.14;
            //System.Console.WriteLine(pi);

            //Get e Set
            //Data data = new Data();
            //data.Mes = 10;
            //sem propriedade precisa chamar outro metodo que seta o valor
            //data.SetMes(2);
            //data.ApresentarMes();

            //Mostrando funcionamento dos construtores com herenca
            //O construtor da classe pessoa eh chamado primeiro e so dps eh chaamdo o construtor da classe aluno
            //Aluno a1 = new Aluno("Gabriela", "Lima", "Jogos");

            //Provando que a propriedade do log2 eh a do log, sao o mesmo objeto
            // Log log = Log.GetInstance();
            // log.PropriedadeLog = "Teste Instancia";
            // Log log2 = Log.GetInstance();
            // System.Console.WriteLine(log2.PropriedadeLog);

            //Nao funciona, pois o construtor eh privado
            ////Log log = new Log();

            // Pessoa p = new Pessoa("Gabriela", "Lima");
            // p.Apresentar();

        }
    }
}