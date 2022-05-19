//2 ######################################################.
double real = 0;
double euros = 5.28d;
double results = 0;

Console.WriteLine("Valor a ser convertido:");
real = double.Parse(Console.ReadLine());

results = real*euros;
Console.WriteLine("resultado da conversão de euros para real:"+ results); 