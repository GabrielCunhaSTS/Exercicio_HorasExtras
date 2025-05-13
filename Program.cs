double salarioHora, horasTrabalhadas, horasExtras;

Console.WriteLine("------ Bem-vindo(a) programas de horas extras ------");

do {
    Console.Write("Digite seu salario/hora (em R$): ");
} while(!double.TryParse(Console.ReadLine(), out salarioHora) || salarioHora <= 0);

do {
    Console.Write("Digite o total de horas trabalhadas: ");
} while (!double.TryParse(Console.ReadLine(), out horasTrabalhadas) || horasTrabalhadas < 0);

do {
    Console.Write("Digite o número de horas extras trabalhadas: ");
} while (!double.TryParse(Console.ReadLine(), out horasExtras) || horasExtras < 0);

double salarioFinal = salarioHora * horasTrabalhadas;
double salarioFinalHorasExtras = CalcularSalario(salarioHora, horasTrabalhadas, horasExtras);

Console.WriteLine($"Salario total sem acrescimo de horas extras: {salarioFinal:C2}");

Console.WriteLine($"Salario total com acrescimo de horas extras: {salarioFinalHorasExtras:C2}");

Console.Write("\nPressione qualquer tecla para finalizar o programa!");
Console.ReadKey();
Console.Clear();

double CalcularSalario(double salarioHora, double horasTrabalhadas, double horasExtras)
{
    double valorHoraTrabalhada = salarioHora * horasTrabalhadas;
    double valorHorasExtras = horasExtras * (salarioHora * 1.40);

    double salarioTotal = valorHoraTrabalhada + valorHorasExtras;

    return salarioTotal;
}
