using Localizacao;

namespace PessoaBase{
    public class Pessoa{
        // atributes
        private string _NomeCompleto;
        private char _Sexo;
        private int _Idade;
        private Endereco _Endereco;


        public Pessoa(){
            // construtor
        }

        public Pessoa(string NomeCompleto, char Sexo, int Idade, Localizacao.Endereco Endereco){
            // construtor
            _NomeCompleto = NomeCompleto;
            _Sexo = Sexo;
            _Idade = Idade;
            _Endereco = Endereco;
        }

        //get, set
        public string NomeCompleto{
            get{return _NomeCompleto;} 
            set{_NomeCompleto = value;}
        }

        public char Sexo{
            get{return _Sexo;} 
            set{_Sexo = value;}
        }

        public int Idade{
            get{return _Idade;} 
            set{_Idade = value;}
        }

        public Endereco Endereco{
            get{return _Endereco;} 
            set{_Endereco = value;}
        }

        // métodos       


    } // fim Pessoa

}