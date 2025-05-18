double salarioHora, horasTrabalhadas, horasExtras;

Console.WriteLine("------ Bem-vindo(a) programas de horas extras ------");

Console.Write("Digite seu salario/hora (em R$): ");
while(!double.TryParse(Console.ReadLine(), out salarioHora) || salarioHora <= 0){
    Console.WriteLine("Número inválido! Digite novamente seu salario/hora (em R$):");
}


Console.Write("Digite o total de horas trabalhadas: ");
while (!double.TryParse(Console.ReadLine(), out horasTrabalhadas) || horasTrabalhadas < 0){
    Console.WriteLine("Número inválido! Digite novamente o total de horas trabalhadas (números positivos):");
}

Console.Write("Digite o número de horas extras trabalhadas: ");
while (!double.TryParse(Console.ReadLine(), out horasExtras) || horasExtras < 0) {
    Console.WriteLine("Número inválido! Digite novamente o total de horas extras trabalhadas (números positivos):");
}

double salarioSemHorasExtras = salarioHora * horasTrabalhadas;
double salarioFinal = CalcularSalario(salarioHora, horasTrabalhadas, horasExtras);

Console.WriteLine($"Salario total sem acréscimo de horas extras: {salarioSemHorasExtras:C2}");

Console.WriteLine($"Salario total com acréscimo de horas extras: {salarioFinal:C2}");

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
