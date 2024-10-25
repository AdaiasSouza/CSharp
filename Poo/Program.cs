/*
    Programação Orientada a Objeto: Classes, Atributos, Herança, Método
    Polimorfismo, Encapsulamento(getters, setters), Interface...

*/
using System;

namespace SistemaEnsino{
    class Program{
        static void Main(string[] args){

            Pessoa aluno = new Pessoa();                          
            aluno.NomeCompleto = "Jose";
            aluno.Endereco = "Rua Tabajara";
            aluno.Idade = 27;
            aluno.Sexo = 'M';
            Console.WriteLine("Nome aluno: "+aluno.NomeCompleto);            
            Console.WriteLine("Nome professor: "+aluno.NomeCompleto);
            Console.WriteLine("Endereço : "+aluno.Endereco);
            Console.WriteLine("Idade: "+aluno.Idade);
            Console.WriteLine("Sexo: "+aluno.Sexo);

            Console.WriteLine("<--------------------------->");

            Aluno aluno1 = new Aluno();
            aluno1.NomeCompleto = "Jose Camargo";
            aluno1.Endereco = "Rua Flor de Lis";
            aluno1.Idade = 32;
            aluno1.Sexo = 'M';

            Console.WriteLine("Nome professor: "+aluno1.NomeCompleto);
            Console.WriteLine("Endereço : "+aluno1.Endereco);
            Console.WriteLine("Idade: "+aluno1.Idade);
            Console.WriteLine("Sexo: "+aluno1.Sexo);
            
            aluno1.Curso = "Ciências da Computação";
            aluno1.Departamento = "Ciências Exatas";
            aluno1.Matricula = "1231";

            Console.WriteLine("Curso: "+aluno1.Curso);
            Console.WriteLine("Departamento: "+aluno1.Departamento);
            Console.WriteLine("Matricula: "+aluno1.Matricula);
            Console.WriteLine("<--------------------------->");

        }
    }

    public class Pessoa{
        // atributes
        private string _NomeCompleto;
        private char _Sexo;
        private int _Idade;
        private string _Endereco;


        public Pessoa(){
            // construtor
        }

        public Pessoa(string NomeCompleto, char Sexo, int Idade, string Endereco){
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

        public string Endereco{
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
        private string __Grupo;
        private string _CodigoProfessor;
        // constructor
        public Professor(){

        }

        public Professor(string Grupo, string CodigoProfessor){
            __Grupo = Grupo;
            _CodigoProfessor = CodigoProfessor;
        }
        // get, set
        public string Grupo{
            get{return  __Grupo;} set{__Grupo = value;}
        }

        public string CodigoProfessor{
            get{return _CodigoProfessor;} set{_CodigoProfessor = value;}
        }
        // methods
    }
}