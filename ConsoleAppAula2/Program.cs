//Se o aluno tiver mais que tres faltas = reprova.
//Se a nota do aluno for menor que 60 = reprova.

/* Teste de notas

int nota = 0;
int faltas = 0;
string opcao = "S";

while (true)
{
Console.WriteLine("Informe a nota: ");
nota = int.Parse(Console.ReadLine());

Console.WriteLine("Informe o numero de faltas: ");
faltas = int.Parse(Console.ReadLine());

if (nota >= 60 || faltas <= 3)
{
    Console.WriteLine($"Aprovado");
}
else
    Console.WriteLine($"Reprovado");

    Console.WriteLine("Deseja continuar? (s/n)");
    opcao = Console.ReadLine();
    if (opcao != "s")
    {
        break;
    }
    else { Console.Clear(); }
}
*/

#region Estrutura de repetição

//FOR
/*
int contador = 0;
int tabuada;

Console.WriteLine($"Informe a tabuada ");
tabuada = Convert.ToInt32(Console.ReadLine());


for (contador = 0; contador < 10; contador++)
{
    Console.WriteLine(
        $"{tabuada} x {contador} = {tabuada * contador}");
}
*/

//WHILE
/*
int contador = 0;

while(contador<10)
{
    Console.WriteLine(contador);
    contador++;
}

contador = 0;
do{

    Console.WriteLine(contador);
    contador++;
} while(contador<10);
*/

//Foreach
/*
string[] nomes = {"Abacaxi", "Maça", "Banana"};
int[] numeros = { 1, 2, 3, 4, 5, 6 };

foreach (int i in numeros)
{
    Console.WriteLine(i);
}

Console.ReadKey();

*/





#endregion

/*Idade Aluno
int idadeAluno;
bool MaiorDeIdade(int idade)
{
    if (idade >= 18)
    {
        return(true);
    }
    else {
        return (false);
    }
}
void MaiorDeIdade(int idade)
{
    if (idade >= 18)
    {
        return (true);
    }
    else
    {
        return (false);
    }
}
idadeAluno(15);

Console.WriteLine("Informe sua idade: ");
idadeAluno = Convert.ToInt32(Console.ReadLine());

if (MaiorDeIdade(idadeAluno) == true)
{
    Console.WriteLine("Aluno maior de idade");
}else
{
    Console.WriteLine("Aluno menor de idade");
}
*/

//Função para somar do tipo void
//Função que retorne a multiplicação

void MetodoSomar(int num1, int num2)
{
    Console.WriteLine(
        $"Soma dos Valores: {num1 + num2}");
}
MetodoSomar(10, 20);
MetodoSomar(100, 200);