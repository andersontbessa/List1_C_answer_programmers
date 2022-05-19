
//reposta 1 sem usuário:

int idade_min = 20;
int idade_max = 50;
int media_alu;


media_alu = (idade_min + idade_max) / 2;


Console.WriteLine(media_alu); 

// resposta 2 com usuário

float aluno = 0;
float idade = 0;
float media = 0;
float soma = 0;

List<float> listaDeIdade;
listaDeIdade = new List<float>();

for (idade = 1; idade < 3; idade++)
{
    Console.WriteLine("Digite a idade número " + idade + ":");
    aluno = float.Parse(Console.ReadLine());
    listaDeIdade.Add(aluno);
}

foreach (var i in listaDeIdade)
{
    soma += i;


}
media = soma / (idade - 1);
Console.WriteLine(media);