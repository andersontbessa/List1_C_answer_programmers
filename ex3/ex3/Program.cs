//3 ######################################################

//resposta 1:

float salario_com_comissao = (float)(500000 * 0.05);
Console.WriteLine(salario_com_comissao); 

 //resposta 2 com usuário:

float pessoa = 0;
float idade = 0;
float results = 0;

List<float> listaComSalario;
listaComSalario = new List<float>();


Console.WriteLine("Digite o seu salário:");
pessoa = float.Parse(Console.ReadLine());
listaComSalario.Add(pessoa);

foreach (float i in listaComSalario)
{
    results = (float)(i * 0.05);
    Console.WriteLine("A sua comissão do mês será no valor de: " + results);
}