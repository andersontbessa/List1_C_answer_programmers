//8 ##############################################################

double A = 0;
double B = 0;

//LISTA PARA A
List<Double> list1 = new List<Double>();
Console.WriteLine("Escreva o valor de A:");
A = double.Parse(Console.ReadLine());
list1.Add(A);

//LISTA PARA B
List<Double> list2 = new List<Double>();
Console.WriteLine("Escreva o valor de B:");
B = double.Parse(Console.ReadLine());
list2.Add(B);


List<Double> listresult = new List<Double>();
for (int count = 0; count <= list1.Count - 1; count++)
{
    listresult.Add(list1[count] - list2[count]);
}
foreach (var i in listresult)
{
    Console.WriteLine("o valor da subtração de A e B é: " + i);



    if (i < 0)
    {
        Console.WriteLine("TOTAL NEGATIVO");

    }
    else
    {
        Console.WriteLine("TOTAL POSITIVO");

    }
}