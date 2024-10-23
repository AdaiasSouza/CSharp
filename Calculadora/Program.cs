/*
    Calculadora artimetica: soma, subtração, multiplicação e divisao
*/
using System;

namespace Calculadora{
    class Operacoes{
        static void Main(string[] args){
            Menu();
        }

        static void Menu(){

            bool menuPrincipal = true;
            while(menuPrincipal){
                Console.WriteLine("Seleciona um opção: ");
                Console.WriteLine("\t1 - Soma ");
                Console.WriteLine("\t2 - Subtração ");
                Console.WriteLine("\t3 - Multiplicação ");
                Console.WriteLine("\t4 Divisão ");

                short opcao = short.Parse(Console.ReadLine());                
                
                switch(opcao){
                    case 1: OpcaoSoma(); break;
                    case 2: OpcaoSubtracao(); break;                    
                    case 3: OpcaoMultiplicacao(); break;
                    case 4: OpcaoDivisao(); break;
                    default: Console.WriteLine("Opcao inválida!"); break;
                     
                }

                Console.WriteLine("Voltar ao menu principal ?");
                char voltaMenuPrincipal = char.Parse(Console.ReadLine());
                if(voltaMenuPrincipal != 'S'){
                            menuPrincipal = false;
                } 
                
            } // fim menu principal        

        }
        // metodos
        static float Soma(float num1, float num2){
            return (num1 + num2);
        }
        static float Subtracao(float num1, float num2){
            return (num1 - num2);
        }
        static float Multiplicacao(float num1, float num2){
            return (num1 * num2);
        }
        static float Divisao(float num1, float num2){
            if(num2 != 0){
                return (num1 / num2);
            }
            else{
                return -1;
            }
        }        

        static void OpcaoSoma(){
            bool opcaoMenu = true;
                    while(opcaoMenu){
                        Console.WriteLine("Informe um numero: ");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe um numero: ");
                        float num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Soma: "+Soma(num1, num2));

                        Console.WriteLine("Efetuar nova subtração ? S  -> Sim N -> Nao");
                        char opcaoSelecao = char.Parse(Console.ReadLine());
                        if(opcaoSelecao != 'S'){
                            opcaoMenu = false;
                        }                    
                    } // fim while                     
        } // fim OpcaoSoma

        static void OpcaoSubtracao(){
            bool opcaoMenu = true;
                    while(opcaoMenu){
                        Console.WriteLine("Informe um numero: ");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe um numero: ");
                        float num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Subtracao: "+Subtracao(num1, num2));

                        Console.WriteLine("Efetuar nova subtração ? S  -> Sim N -> Nao");
                        char opcaoSelecao = char.Parse(Console.ReadLine());
                        if(opcaoSelecao != 'S'){
                            opcaoMenu = false;
                        }                    
                    } // fim while 
        } // fim OpcaoSubtracao

        static void OpcaoMultiplicacao(){
            bool opcaoMenu = true;
                    while(opcaoMenu){
                        Console.WriteLine("Informe um numero: ");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe um numero: ");
                        float num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Multiplicacao: "+Multiplicacao(num1, num2));

                        Console.WriteLine("Efetuar nova multiplicacao ? S  -> Sim N -> Nao");
                        char opcaoSelecao = char.Parse(Console.ReadLine());
                        if(opcaoSelecao != 'S'){
                            opcaoMenu = false;
                        }                    
                    } // fim while 

        }

        static void OpcaoDivisao(){
            bool opcaoMenu = true;
                    while(opcaoMenu){
                        Console.WriteLine("Informe um numero: ");
                        float num1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Informe um numero: ");
                        float num2 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Divisao: "+Divisao(num1, num2));

                        Console.WriteLine("Efetuar nova divisao ? S  -> Sim N -> Nao");
                        char opcaoSelecao = char.Parse(Console.ReadLine());
                        if(opcaoSelecao != 'S'){
                            opcaoMenu = false;
                        }                    
                    } // fim while 
        }
        
        
    } // fim Operacoes
}