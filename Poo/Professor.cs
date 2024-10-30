using PessoaBase;

namespace PessoaProfessor{
    public class Professor: Pessoa{
        // atributes
        private string _Grupo;
        private string _CodigoProfessor;
        // constructor
        public Professor(){

        }

        public Professor(string Grupo, string CodigoProfessor){
            _Grupo = Grupo;
            _CodigoProfessor = CodigoProfessor;
        }
        // get, set
        public string Grupo{
            get{return  _Grupo;} 
            set{_Grupo = value;}
        }

        public string CodigoProfessor{
            get{return _CodigoProfessor;} 
            set{_CodigoProfessor = value;}
        }
        // methods
    } // fim Professor  
}