/* If idade
//int idade;
//Console.WriteLine("Informe sua idade!");

//idade = Convert.ToInt32(
//    Console.ReadLine());

//if (idade >= 18)
//{
//    Console.WriteLine($"Sua idade {idade}, você é maior de idade!");
//}
//else
//{
//    Console.WriteLine($"Sua idade {idade}, você é menor de idade!");
//}

//Console.WriteLine($"Sua idade é {idade}");
*/

/*Exemplo salário mínimo ou salário comum

//const decimal salario = 1518m;
//Console.WriteLine("Informe seu salário!");

//decimal salarioFuncionario;

//salarioFuncionario = Convert.ToDecimal(
//    Console.ReadLine());

//if (salarioFuncionario >= salario)
//{
//    Console.WriteLine($"Seu salário {salarioFuncionario:C}, é maior que o minimo!");
//}
//else
//{
//    Console.WriteLine($"Seu salário {salarioFuncionario:C}, é menor que o minímo!");
//}
*/

float num1 = 0f;
float num2 = 0f;
string operacaoMatematica;

Console.WriteLine("Informe a operação:\n" +
    "+ ou - * ou /");
operacaoMatematica = Console.ReadLine();

Console.WriteLine("Informe o primeiro valor");
num1 = float.Parse(Console.ReadLine());

Console.WriteLine("Informe o segundo valor");
num2 = float.Parse(Console.ReadLine());

if(operacaoMatematica == "+")
{
    Console.WriteLine($"Soma: {num1+num2}");
}
else if(operacaoMatematica == "-")
{
    Console.WriteLine($"Subtração: {num1-num2}");
}
else if (operacaoMatematica == "*")
{
    Console.WriteLine($"Multiplicação: {num1*num2}");
}
else if (operacaoMatematica == "/")
{
    Console.WriteLine($"Divisão: {num1/num2}");
}
else { Console.WriteLine("Operação Invalida"); }