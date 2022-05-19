//6 #################################################

float altura = 0;
float peso = 0;

Console.WriteLine("Digite a sua altura: ");
altura = float.Parse(Console.ReadLine());
peso = ((float)((72.7 * altura) - 58));
Console.WriteLine("O peso ideal para você é: " + peso);