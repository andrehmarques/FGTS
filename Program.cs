double salario, fgts;


Console.WriteLine("Calcule seu FGTS!");

Console.Write("Digite seu salário (R$): ");
salario = double.Parse(Console.ReadLine()!);

fgts = salario * 0.08;

Console.Write($"O valor do seu FGTS é: {fgts:C2}");
