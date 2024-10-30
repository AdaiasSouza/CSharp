using PessoaBase;

namespace PessoaAluno{
    public class Aluno: Pessoa{
        // atributes
        private string _Curso;
        private string _Departamento;
        private string _Matricula;


        // constructor
        public Aluno(){

        }

        public Aluno(string Curso, string Departamento, string Matricula){
            _Curso = Curso;
            _Departamento = Departamento;
            _Matricula = Matricula;
        }
        // get, set
        public string Curso{
            get{return _Curso;} 
            set{_Curso = value;}
        }

        public string Departamento{
            get{return _Departamento;} 
            set{_Departamento = value;}
        }

        public string Matricula{
            get{return _Matricula;} 
            set{_Matricula = value;}
        }

        // methods
    }
}