/*
    Programação Orientada a Objeto: Classes, Atributos, Herança, Método
    Polimorfismo, Encapsulamento(getters, setters), Interface...

*/
using System;

namespace SistemaEnsino{
    class Program{
        static void Main(string[] args){

            Aluno aluno = new Aluno();   

            // dados alunos
            aluno.NomeCompleto = "Jose";
            aluno.Idade = 27;
            aluno.Sexo = 'M';
            aluno.Curso = "Ciencia da Computação";
            aluno.Departamento = "Exatas";
            aluno.Matricula = "7575";

            // endereco
            aluno.Endereco.Cep = "60526640";
            aluno.Endereco.Cidade = "Fortaleza";
            aluno.Endereco.Estado = "CE";
            aluno.Endereco.NomeRua = "Rua Flor";
            aluno.Endereco.NumCasa = 305;
            
            Console.WriteLine("Nome aluno: "+aluno.NomeCompleto);            
            Console.WriteLine("Nome professor: "+aluno.NomeCompleto);
            Console.WriteLine("Endereço : "+aluno.Endereco);
            Console.WriteLine("Idade: "+aluno.Idade);
            Console.WriteLine("Sexo: "+aluno.Sexo);           

        }
    }

    public class Pessoa{
        // atributes
        private string _NomeCompleto;
        private char _Sexo;
        private int _Idade;
        private Endereco _Endereco;


        public Pessoa(){
            // construtor
        }

        public Pessoa(string NomeCompleto, char Sexo, int Idade, Endereco Endereco){
            // construtor
            _NomeCompleto = NomeCompleto;
            _Sexo = Sexo;
            _Idade = Idade;
            _Endereco = Endereco;
        }

        //get, set
        public string NomeCompleto{
            get{return _NomeCompleto;} set{_NomeCompleto = value;}
        }

        public char Sexo{
            get{return _Sexo;} set{_Sexo = value;}
        }

        public int Idade{
            get{return _Idade;} set{_Idade = value;}
        }

        public Endereco Endereco{
            get{return _Endereco;} set{_Endereco = value;}
        }

        // métodos       


    }

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
            get{return _Curso;} set{_Curso = value;}
        }

        public string Departamento{
            get{return _Departamento;} set{_Departamento = value;}
        }

        public string Matricula{
            get{return _Matricula;} set{_Matricula = value;}
        }

        // methods
    }

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
            get{return  _Grupo;} set{_Grupo = value;}
        }

        public string CodigoProfessor{
            get{return _CodigoProfessor;} set{_CodigoProfessor = value;}
        }
        // methods
    }

    public class Endereco{
        private string _NomeRua;
        private int _NumCasa;
        private string _Cep;
        private string _Cidade;
        private string _Estado;

        // constructor
        public Endereco(){

        }

        public Endereco(string NomeRua, int NumCasa, string Cep, string Cidade, string Estado){
            _NomeRua = NomeRua;
            _NumCasa = NumCasa;
            _Cep = Cep;
            _Cidade = Cidade;
            _Estado = Estado;
        }

        public string NomeRua{
            get{return _NomeRua;} set{_NomeRua = value;}
        }

        public int NumCasa{
            get{return _NumCasa;} set{_NumCasa = value;}
        }

        public string Cep{
            get{return _Cep;} set{_Cep = value;}
        }

        public string Cidade{
            get{return _Cidade;} set{_Cidade = value;}
        }

        public string Estado{
            get{return _Estado;} set{_Estado = value;}
        }

    }
}