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

            Console.WriteLine("Informe um numero: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Informe um numero: ");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Seleciona um opção: ");
            Console.WriteLine("\t1 - Soma ");
            Console.WriteLine("2 - Subtração ");
            Console.WriteLine("3 - Multiplicação ");
            Console.WriteLine("4 Divisão ");

            short opcao = short.Parse(Console.ReadLine());

            switch(opcao){
                case 1: Console.WriteLine("Soma: "+Soma(num1, num2)); break;
                case 2: Console.WriteLine("Soma: "+Subtracao(num1, num2)); break;
                case 3: Console.WriteLine("Soma: "+Multiplicacao(num1, num2)); break;
                case 4: Console.WriteLine("Soma: "+Divisao(num1, num2)); break;
                default: Menu(); break;
            }
        }

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

    }
}