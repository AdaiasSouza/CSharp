/*
    Calculando media de notas do aluno
    Obs: Adicionando projetos ao mesmo sln: dotnet sln Projeto.sln add Projeto.csproj
*/
using System;

namespace MediaAluno{
    class NotasAlunos{
        static void Main(string[] args){
            Console.WriteLine("Media Alunos");            
            Menu();
        }

    static void Menu(){
        int countNotas = 0;
        Console.WriteLine("Informe quantidade de notas: ");
        int qtdAlunos = Convert.ToInt32(Console.ReadLine());
        while(countNotas < qtdAlunos){

            Console.WriteLine("\tInforme nota: ");

            double nota1 = Convert.ToDouble(Console.ReadLine());
            double nota2 = Convert.ToDouble(Console.ReadLine());
            double nota3 = Convert.ToDouble(Console.ReadLine());            
            
            double mediaAluno = MediaAluno(nota1, nota2, nota3);
            string statusAluno = StatusAluno(mediaAluno);

            Console.WriteLine("\tStatus: "+statusAluno+" Media: "+mediaAluno);            
            countNotas++;
            Console.WriteLine("\tQtd alunos: "+countNotas);
            Console.WriteLine("<--------------------------->");

        }
        
    }
    
    static double MediaAluno(double nota1, double nota2, double nota3){
        return (nota1 + nota2 + nota3)/3;
    }

    static string StatusAluno(double mediaAluno){
        if(mediaAluno >= 7){
            return "Aprovado";
        }
        else if(mediaAluno >= 5 && mediaAluno < 7){
            return "Prova Final";
        }
        else{
            return "Reprovado";
        }
    }
    }
}