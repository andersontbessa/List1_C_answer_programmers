//7 ######################################################

float aluno = 0;
float nota = 0;
float media = 0;
float soma = 0;

List<float> listaDeNota;
listaDeNota = new List<float>();

for (nota = 1; nota < 5; nota++)
{
    Console.WriteLine("Escreva a nota numero " + nota + ":");
    aluno = float.Parse(Console.ReadLine());
    listaDeNota.Add(aluno);
}

foreach (var i in listaDeNota)
{
    soma += i;

}
media = soma / (nota - 1);
Console.WriteLine(media);

if (media >= 7)
{
    Console.WriteLine("APROVADO!!!");
}
else
{
    Console.WriteLine("REPROVADO!!!");
}
