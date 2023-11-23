using System;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Qual operação deseja fazer: ");
        Console.WriteLine("1- ADIÇÃO: ");
        Console.WriteLine("2- SUBTRAÇÃO: ");
        Console.WriteLine("3- MULTIPLICAÇÃO: ");
        Console.WriteLine("4- DIVISÃO: \n" );



        Console.ReadLine();

        int operacao = int.Parse(Console.ReadLine());


        Console.WriteLine("Digite o primeiro número: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.WriteLine("Digite o segundo número: ");
        int num2 = int.Parse(Console.ReadLine());

        int resultado = 0;

        switch(operacao) 
        {
            case 1:
                {
                    resultado = num1 + num2;
                    break;
                }
           case 2: 
                {
                    resultado = num1 - num2;
                    break;

                }
            case 3:
                {
                    resultado = num1 * num2;
                    break;
                }
            case 4:
                {
                    resultado = num1 / num2;
                    break;
                }
            default:
                Console.WriteLine("Número inválido, digite outro número.");
                break;
        }
        Console.WriteLine("O resultado da operação com os números {0} e {1} é: {2}", num1, num2, resultado);
        Console.ReadLine() ;
    }
}

