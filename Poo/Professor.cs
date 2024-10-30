using CursoSuperior;
using PessoaBase;

namespace PessoaProfessor{
    public class Professor: Pessoa{
        // atributes
        private string _Grupo;
        private string _CodigoProfessor;

        private Curso _Curso;

        // constructor
        public Professor(){
            Console.WriteLine("Iniciando...");

        }

        public Professor(string Grupo, string CodigoProfessor, Curso Curso){
            _Grupo = Grupo;
            _CodigoProfessor = CodigoProfessor;
            _Curso = Curso;
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