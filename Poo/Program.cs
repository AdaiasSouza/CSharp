/*
    Programação Orientada a Objeto: Classes, Atributos, Herança, Método
    Polimorfismo, Encapsulamento(getters, setters), Interface...
    Acessar classes em outros arquivos

*/
using System;
using Localizacao;
using PessoaBase;
using PessoaAluno;
using PessoaProfessor;
using CursoSuperior;

namespace SistemaEnsino{
    class Program{
        static void Main(string[] args){        
            
            
            // dados alunos
            Aluno aluno = new Aluno();
            aluno.NomeCompleto = "Jose";
            aluno.Idade = 27;
            aluno.Sexo = 'M';
            
            CursoSuperior.Curso curso = new Curso();
            aluno.Curso = curso;
            aluno.Curso.NomeCurso = "Ciencia da Computação";
            aluno.Curso.Centro = "Ciências Exatas";
            aluno.Curso.Periodo = "Integral";
            aluno.Departamento = "MCE";
            aluno.Matricula = "7575";

            Localizacao.Endereco endereco = new Endereco();
            endereco.Cep = "60526-640";
            endereco.Cidade = "Fortaleza";
            endereco.Estado = "CE";
            endereco.NomeRua = "Rua Turing";
            endereco.NumCasa = 32;

            aluno.Endereco = endereco;

            // dados pessoas:
            Console.WriteLine("Nome aluno: "+aluno.NomeCompleto);            
            Console.WriteLine("Nome professor: "+aluno.NomeCompleto);            
            Console.WriteLine("Idade: "+aluno.Idade);
            Console.WriteLine("Sexo: "+aluno.Sexo);
            Console.WriteLine();

            // localizacao
            Console.WriteLine("Rua: "+aluno.Endereco.NomeRua);
            Console.WriteLine("Casa: "+aluno.Endereco.NumCasa);
            Console.WriteLine("Cidade: "+aluno.Endereco.Cidade);
            Console.WriteLine("CEP: "+aluno.Endereco.Cep);
            Console.WriteLine("Estado: "+aluno.Endereco.Estado);

            // dados curso
            //...
        }
    } // fim program     
} // fim SistemaEnsino