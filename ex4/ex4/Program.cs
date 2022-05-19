//4 ####################################################
float fahrenheit = 0;
float celsius = 0;

Console.WriteLine("Escreva a temperatura em celsius:");
celsius = float.Parse(Console.ReadLine());
fahrenheit = ((9 * celsius) + 160) / 5;
Console.WriteLine("conversão celsius para fahrenheit:" + fahrenheit);