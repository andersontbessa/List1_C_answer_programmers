//exercicio usando if e else, e ternário também.

//alunos que foram aprovados, recuperação e reprovados. Reprovados =< 5. De 5 a 6 de recuperação. Menor que 7 é reprovado.


//USANDO IF ELSE
using System;

float nota = 0;

List<float> listaDeIdade;
listaDeIdade = new List<float>();


Console.WriteLine("Digite a nota: ");
float aluno = float.Parse(Console.ReadLine());
listaDeIdade.Add(aluno);

foreach (var i in listaDeIdade)
{
    if (i < 5)
    {
        Console.WriteLine("Reprovado");
    };

    if (i >= 5 && i <= 6)
    {
        Console.WriteLine("Recuperação");
    };
    if (i >= 7)
    {
        Console.WriteLine("Aprovado");
    };

}


//USANDO TERNÁRIO
/*
using System;

float nota = 0;

List<float> listaDeIdade;
listaDeIdade = new List<float>();


Console.WriteLine("Digite a nota: ");
float aluno = float.Parse(Console.ReadLine());
listaDeIdade.Add(aluno);

foreach (var i in listaDeIdade)
{
    var x = (i >= 7 ? "Aprovado" : "Reprovado");
    Console.WriteLine(x);


}
*/