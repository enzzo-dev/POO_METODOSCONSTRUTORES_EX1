using System;

namespace POO_METODOSCONSTRUTORES_EX1.classes
{
    public class Pessoa
    {
        private string nome;
        private string sobreNome;

        public Pessoa(string firstName , string lastName){
            nome = firstName;
            sobreNome = lastName;
        }

        public string Nome{
            get{return nome;}
            set{nome = value;}
        }

        public string SobreNome{
            get{return sobreNome;}
            set{sobreNome = value;}
        }
    }
}