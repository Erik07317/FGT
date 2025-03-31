double salario;
Console.Write("Digite o numero do salário de funcionário: ");
salario = double.Parse(Console.ReadLine()!);
double FGTS;
FGTS = 0.08*salario;

Console.WriteLine($"Seu valor do sálario parcelado é {FGTS:C2}");
