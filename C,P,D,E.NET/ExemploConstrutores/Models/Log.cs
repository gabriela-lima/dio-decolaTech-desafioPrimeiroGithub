namespace ExemploConstrutores.Models
{
    public class Log
    {
        private static Log _log;
        public string PropriedadeLog { get; set; }

        //Padrao de projeto singleton, permite uma unica instancia da classe, dessa forma o objeto sera o mesmo reutilizado no projeto
        //eh comum utilizar o construtor privado nesse tipo de projeto
        private Log()
        {
            
        }   

        //Dessa forma ele vai ser instanciado uma vez, apos isso ele nao sera mais nulo e toda vez que a funcao for chamada ela vai retornar o mesmo log que ja foi criado
        public static Log GetInstance()
        {
            if(_log == null)
            {
                _log = new Log();
            }
            return _log;
        }
    }
}