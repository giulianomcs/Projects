using System;

class Calculadora {
    static void Main(string[] args) {
        double num1, num2, resultado;
        char operador;

        Console.Write("Digite o primeiro número: ");
        num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite o segundo número: ");
        num2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Digite um operador (+, -, *, /): ");
        operador = Convert.ToChar(Console.ReadLine());

        switch(operador) {
            case '+':
                resultado = num1 + num2;
                Console.WriteLine("{0} + {1} = {2}", num1, num2, resultado);
                break;

            case '-':
                resultado = num1 - num2;
                Console.WriteLine("{0} - {1} = {2}", num1, num2, resultado);
                break;

            case '*':
                resultado = num1 * num2;
                Console.WriteLine("{0} * {1} = {2}", num1, num2, resultado);
                break;

            case '/':
                if (num2 == 0) {
                    Console.WriteLine("Erro: divisão por zero");
                } else {
                    resultado = num1 / num2;
                    Console.WriteLine("{0} / {1} = {2}", num1, num2, resultado);
                }
                break;

            default:
                Console.WriteLine("Operador inválido");
                break;
        }
    }
}
