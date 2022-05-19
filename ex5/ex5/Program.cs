//5 ####################################################

float fahrenheit = 0;
float celsius = 0;

Console.WriteLine("Escreva a temperatura em celsius:");
fahrenheit = float.Parse(Console.ReadLine());
celsius = ((fahrenheit - 32) * 5 / 9);
Console.WriteLine("conversão fahrenheit para celsius:" + celsius);