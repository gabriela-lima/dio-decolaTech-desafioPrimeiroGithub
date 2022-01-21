namespace ExemploConstrutores.Models
{
    public class Data
    {
        private int mes;
        private bool mesValido;

        // Propriedades: outra forma de fazer os gets e sets (mais simples inclusive, precisam ser modificados apenas em casos necessarios, por exemplo por conta do if e mes invalido)
        public int Mes 
        {
            get
            {
                return this.mes;
            }
            set 
            {
                if(value > 0 && value <= 12)
                {
                    this.mes = value;
                    this.mesValido = true;
                }
            }   
        }

        public int GetMes()
        {
            return this.mes;
        }

        public void SetMes(int mes)
        {
            if(mes > 0  && mes <= 12)
            {
               this.mes = mes; 
               this.mesValido = true;
            }
        }
        public void ApresentarMes()
        {
            if(this.mesValido)
            {
                System.Console.WriteLine(this.mes);
            }
            else
            {
                System.Console.WriteLine("Mes invalido");
            }
        }
    }
}